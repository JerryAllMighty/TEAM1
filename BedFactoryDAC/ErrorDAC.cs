using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BedFactoryVO;

namespace BedFactoryDAC
{
    public class ErrorDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;

        public ErrorDAC()
        {
            strConn = this.ConnectionString;
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public List<ErrorHistoryVO> GetErrorHistory()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select wh.WH_Num, wh.WO_Num, WorkCnt, ErrorKind, ErrorCnt, wh.Firstman, wh.Firstdate, convert(decimal(8, 2), 100 * ErrorCnt / WorkCnt) as persent, Mat_Name, Mat_Category
                                        from tblWorkHistory as wh
                                        join tblWorkOrders as wo on wh.WO_Num = wo.WO_Num
                                        join tblMaterials as mt on wo.Mat_Num = mt.Mat_Num";

                    List<ErrorHistoryVO> list = Helper.DataReaderMapToList<ErrorHistoryVO>(cmd.ExecuteReader());


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
