using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryDAC
{
    public class WorkOrderDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;
        public WorkOrderDAC()
        {
            strConn = this.ConnectionString;
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public List<WorkOrderVO> GetWorkOrder(string ProcessCode)
        {
            try {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select  Convert(nvarchar(10), W.WO_Num) WO_Num, Convert(nvarchar(10), W.WO_D_Emp_Num) WO_D_Emp_Num, Convert(nvarchar(10), W.WP_Num) WP_Num,
                                                Convert(nvarchar(10),W.Mat_Num) Mat_Num, Convert(nvarchar(10),W.WO_Order_Cnt) WO_Order_Cnt, Convert(nvarchar(10),WH.WorkCnt) WorkCnt,
                                                Convert(nvarchar(10),E.Error_Cnt) Error_Cnt
                                                from tblWorkOrders W
                                                inner join tblProcess P
                                                on P.Process_Num = W.Process_Num
                                                left outer join tblWorkHistory WH
                                                on W.WO_Num = WH.WO_Num
                                                inner join tblCheckHistory CH
                                                on CH.Check_Subject_Num = WH.WH_Num
                                                inner join tblErrorHistory E 
                                                on E.Check_History_Num = CH.Check_History_Num
                                                where WO_Status = '작업 지시 확정' and P.Process_Code = @Process_Code";

                    cmd.Parameters.AddWithValue("@Process_Code", ProcessCode);

                    List<WorkOrderVO> list = Helper.DataReaderMapToList<WorkOrderVO>(cmd.ExecuteReader());

                    return list != null ? list : null;
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
            conn.Close();
        }
    }
}
