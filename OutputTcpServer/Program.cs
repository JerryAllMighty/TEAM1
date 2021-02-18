using log4net.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TCPData
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1 service = new Service1();
            service.taskID = args[0];
            service.hostIP = args[1];
            service.hostPort = int.Parse(args[2]);
            service.OnStart();

            Console.ReadLine();
        }
    }

    public class Service1
    {
        LoggingUtility loggingUtility;
        TcpListener listener;
        Timer timer1;
        TcpClient tc;
        NetworkStream stream;

        LoggingUtility Log { get { return loggingUtility; } }
        
        public string taskID { get; set; }
        public string hostIP { get; set; }
        public int hostPort { get; set; }

        public void OnStart()
        {
            loggingUtility = LoggingUtility.GetLoggingUtility(taskID, Level.Debug, 30);

            Console.WriteLine("서비스 시작");
            Log.WriteInfo("서비스 시작");

            if (listener == null)
            {
                listener = new TcpListener(IPAddress.Parse(hostIP), hostPort);
            }

            AsyncEchoServer();
        }

        private async void AsyncEchoServer()
        {
            listener.Start();
            while (true)
            {
                tc = await listener.AcceptTcpClientAsync().ConfigureAwait(false);
                stream = tc.GetStream();

                timer1 = new Timer(3000);
                timer1.Elapsed += Timer1_Elapsed;
                timer1.Enabled = true;
                timer1.AutoReset = true;
               // await Task.Factory.StartNew(AsyncTcpProcess, tc);
            }
        }

        private void Timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            Random rnd = new Random((int)DateTime.UtcNow.Ticks);

            //50|2|1
            string msg = $"{rnd.Next(1, 4)}|{rnd.Next(0, 2)}";
            byte[] buff = Encoding.Default.GetBytes(msg);

            stream.Write(buff, 0, buff.Length);
            Console.WriteLine(msg);
            Log.WriteInfo("데이터전송: " + msg);
        }

        public void OnStop()
        {
            listener.Stop();
        }
    }
}
