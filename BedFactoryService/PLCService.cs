using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BedFactoryService
{
    public class TcpControl
    {
        public TcpClient client;
        public NetworkStream dataStream;

        public TcpControl(string host, int port)
        {
            client = new TcpClient(host, port);
            dataStream = client.GetStream();
        }
    }

    public class ReadDataEventArgs : EventArgs
    {
        public string Data { get; set; }
    }

    public class PLCService
    {
        public delegate void ReacDataEventHandle(object sender, ReadDataEventArgs args);
        public event ReacDataEventHandle ReadData;

        ManualResetEvent m_ThreadTerminateRequest = new ManualResetEvent(false);
        Thread m_Thread;
        NetworkStream recvData;
        TcpControl client;

        bool m_ConnectionSts = false;
        Stopwatch m_AliveTimer = new Stopwatch();

        string hostIP;
        int hostPort;
        string clientName;
        string clientIP;

        public void ThreadStart()
        {
            m_ThreadTerminateRequest.Reset();

            m_Thread = new Thread(ExecuteThreadJob);
            m_Thread.Start();
        }

        public void ThreadStop()
        {
            if (client == null || client.client == null) return;

            lock (m_Thread)
            {
                client.client.Close();
                m_ThreadTerminateRequest.Set();
            }
        }

        public PLCService(string hostIP, int hostPort, string clientName, string clientIP)
        {
            this.hostIP = hostIP;
            this.hostPort = hostPort;
            this.clientName = clientName;
            this.clientIP = clientIP;
        }

        private void ExecuteThreadJob()
        {
            while (!this.m_ThreadTerminateRequest.WaitOne(300))
            {
                try
                {
                    lock (m_Thread)
                    {
                        // 실제 Thread에 필요한 코드 수행                        
                        DoingSchedule();
                    }
                }
                catch (Exception ex)
                {
                    //Log.WriteError("쓰레드 실행 중 오류 : " + ex.Message);
                }
            }
        }

        private void DoingSchedule()
        {
            if (!m_ConnectionSts)
            {
                //연결
                client = new TcpControl(hostIP, hostPort);
                if (client.client.Connected)
                {
                    recvData = client.dataStream;
                    m_ConnectionSts = true;
                    m_AliveTimer.Restart();

                    //Log.WriteInfo("서버 접속");
                }
            }
            else
            {
                //Alive 체크
                if (!m_AliveTimer.IsRunning || m_AliveTimer.Elapsed.TotalMilliseconds > 500000)
                {
                    if (!m_AliveTimer.IsRunning)
                        m_AliveTimer.Restart();

                   // Log.WriteInfo("재접속을 위한 연결종료");
                    m_ConnectionSts = false;
                    client.client.Close();
                    client = new TcpControl(hostIP, hostPort);
                    if (client.client.Connected)
                    {
                        recvData = client.dataStream;
                        m_ConnectionSts = true;
                        m_AliveTimer.Restart();
                        //Log.WriteInfo("재접속 성공");
                    }
                }

                //수신 (실제 생산실적데이터)
                OnReceive();
            }
        }

        private void OnReceive()
        {
            //STX(start of text, 0x02, 아스키 2번)
            //ETX(end of text,  0x03, 아스키 3번)
            //STX머신ID/제품ID/생산수량/불량수량ETXSTX머신ID/제품ID/생산수량/불량수량ETX
            //50|2|1   50|2|0   HeartBeat 

            string readData = "";

            if (client.client.Available > 0)
            {
                byte[] rcvTmp = new byte[client.client.Available]; //초기 받는

                recvData.Read(rcvTmp, 0, rcvTmp.Length);
                readData = Encoding.Default.GetString(rcvTmp).Replace("", "").Replace("", "").Trim();

                //Log.WriteInfo("데이터 수신:" + readData);

                //HeartBeat 인 경우는 stopwatch만 재시작하고 빠져나간다.
                //if (readData.Contains(STR_HEART_BEAT))
                //{
                //    m_AliveTimer.Restart();
                //    readData = readData.Replace(STR_HEART_BEAT, "");
                //}

                readData = readData.Trim();
                if (readData.Length < 1) return;

                if (ReadData != null)
                {
                    ReadDataEventArgs args = new ReadDataEventArgs();
                    args.Data = readData;
                    ReadData(null, args);
                }

                string[] arrData = readData.Split('|');
                if (arrData.Length == 3)
                {
                    //using (SqlCommand cmd = new SqlCommand())
                    //{
                    //    cmd.Connection = conn;
                    //    cmd.CommandText = @"insert into WorkQtyLog(MachineID, ProductID, Qty, BadQty, WorkRegPC, WorkRegIP) values(@MachineID, @ProductID, @Qty, @BadQty, @WorkRegPC, @WorkRegIP)";
                    //    cmd.Parameters.AddWithValue("@MachineID", taskID);
                    //    cmd.Parameters.AddWithValue("@ProductID", arrData[0]);
                    //    cmd.Parameters.AddWithValue("@Qty", int.Parse(arrData[1]));
                    //    cmd.Parameters.AddWithValue("@BadQty", int.Parse(arrData[2]));
                    //    cmd.Parameters.AddWithValue("@WorkRegPC", clientName);
                    //    cmd.Parameters.AddWithValue("@WorkRegIP", clientIP);

                    //    cmd.ExecuteNonQuery();
                    //}
                }
            }
        }
    }
}
