using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryDAC
{
    public class OrderDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;

        public OrderDAC()
        {
            strConn = this.ConnectionString;
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public List<OrderVO> GetOrders()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select Order_Num, Order_Date, Order_Status, od.Com_Num, IsCanceled, od.FirstMan, od.FirstDate, od.LastMan, od.LastDate, Com_Name
                                        from tblOrders as od
                                        join tblCompany as cp on od.Com_Num = cp.Com_Num";

                    List<OrderVO> list = Helper.DataReaderMapToList<OrderVO>(cmd.ExecuteReader());

                    return list;
                }
            }
            catch (Exception err)
            {
                Log.WriteError(err.Message);
                return null;
            }
        }

        public void Dispose()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
