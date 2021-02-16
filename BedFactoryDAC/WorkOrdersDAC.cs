using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryDAC
{
    public class WorkOrdersDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection Conn;

        public WorkOrdersDAC()
        {
            strConn = this.ConnectionString;
            Conn = new SqlConnection(strConn);
            Conn.Open();
        }

        public void Dispose()
        {
            if (Conn != null)
            {
                this.Dispose();
            }
        }


        /// <summary>
        /// 조건으로 작업지시현황 조회
        /// </summary>
        /// <param name="wpNum"></param>
        /// <param name="matNum"></param>
        /// <param name="wsNum"></param>
        /// <param name="dtFrom"></param>
        /// <param name="dtTo"></param>
        /// <returns></returns>
        public List<WorkOrdersVO> GetWorkOrdersInfo(int wpNum, string matNum, int wsNum, DateTime dtFrom, DateTime dtTo)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(@"select WO.WO_Num, P.Process_Name_D, WP.WP_Name, M.Mat_Name, PP.ProductionDate as FirstDate, SM.LastDate, WO.WO_Status, WO.WO_Plan_Cnt,
                                      WO.WO_Order_Cnt, WO.WO_Detail, WO.IsShip, WO.WO_D_Emp_Num, convert(char(8), WO.WO_StartTime, 24) as WO_StartTime, convert(char(8), WO.WO_FinishTime, 24) as WO_FinishTime
                               from tblWorkOrders WO inner join tblWorkplace WP on WO.WP_Num = WP.WP_Num
                               inner join tblProcess P on WO.Process_Num = P.Process_Num
                               inner join tblMaterials M on WO.Mat_Num = M.Mat_Num
                               inner join tblProductionPlan_D PP on WO.ProductionPlan_D_Num = PP.ProductionPlan_D_Num
                               inner join tblSalesMaster SM on WO.SalesMaster_Num = SM.SalesMaster_Num
                       where PP.ProductionDate >= @dtFrom and SM.LastDate <= @dtTo ");

                if (wpNum > 0)
                    sb.Append(" and WP.WP_Name = @wpNum");
                if (!string.IsNullOrEmpty(matNum))
                    sb.Append(" and  M.Mat_Name = @matNum");
                if (wsNum > 0)
                    sb.Append(" and WO_Status = @wsNum");

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = sb.ToString();
                    cmd.Connection = Conn;

                    if (wpNum > 0)
                        cmd.Parameters.AddWithValue("@wpNum", wpNum);
                    if (!string.IsNullOrEmpty(matNum))
                        cmd.Parameters.AddWithValue("@matNum", matNum);
                    if (wsNum > 0)
                        cmd.Parameters.AddWithValue("@wsNum", wsNum);

                    cmd.Parameters.AddWithValue("@dtFrom", dtFrom.ToShortDateString());
                    cmd.Parameters.AddWithValue("@dtTo", dtTo.ToShortDateString());

                    List<WorkOrdersVO> list = Helper.DataReaderMapToList<WorkOrdersVO>(cmd.ExecuteReader());
                    Conn.Close();

                    return list;
                }
            }

            catch (Exception err)
            {
                Log.WriteError(err.Message);
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public bool DeleteWorkOrdersInfo(List<int> nums)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Conn;
                    cmd.CommandText = @"delete 
                                        from tblWorkOrders
                                        where WO_Num = @WO_Num";

                    int iRowAffect = 0;
                    foreach (int num in nums)
                    {
                        cmd.Parameters["@WO_Num"].Value = num;

                        iRowAffect += cmd.ExecuteNonQuery();
                    }

                    return iRowAffect > 0 ? true : false;
                }
            }
            catch (Exception err)
            {
                Log.WriteError(err.Message);
                return false;
            }
        }

        /// <summary>
        /// 작업지시상태 작업지시확정으로 업데이트
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public bool UpdateStatusWorkOrdersInfo(List<int> nums)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Conn;
                    cmd.CommandText = @"update tblWorkOrders set WO_Status = 'WO002'  
                                        where WO_Num = @WO_Num"; // WO002 = 작업지시확정
                    cmd.Parameters.Add(new SqlParameter("@WO_Num", System.Data.SqlDbType.Int));

                    int iRowAffect = 0;
                    foreach (int num in nums)
                    {
                        cmd.Parameters["@WO_Num"].Value = num;

                        iRowAffect += cmd.ExecuteNonQuery();
                    }

                    return (iRowAffect == nums.Count) ? true : false;
                }
            }
            catch (Exception err)
            {
                Log.WriteError(err.Message);
                return false;
            }
        }
    }
}
