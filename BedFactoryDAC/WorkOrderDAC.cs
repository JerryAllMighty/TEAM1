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
        /// <summary>
        /// 공정 번호로 작업 지시 가져오기
        /// </summary>
        /// <param name="ProcessCode"></param>
        /// <returns></returns>
        public List<WorkOrderVO> GetWorkOrder(string ProcessCode)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select  Convert(nvarchar(10), W.WO_Num) WO_Num, Convert(nvarchar(10), W.WO_D_Emp_Num) WO_D_Emp_Num, Convert(nvarchar(10), W.WP_Num) WP_Num,
                                                Convert(nvarchar(10),W.Mat_Num) Mat_Num, Convert(nvarchar(10),W.WO_Order_Cnt) WO_Order_Cnt, Convert(nvarchar(10),WH.WorkCnt) WorkCnt,
                                                Convert(nvarchar(10),WH.ErrorCnt) Error_Cnt
                                                from tblWorkOrders W
                                                inner join tblProcess P
                                                on P.Process_Num = W.Process_Num
                                                left outer join tblWorkHistory WH
                                                on W.WO_Num = WH.WO_Num
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

        /// <summary>
        /// 작업자 할당을 새롭게 할 때 작업지시내용 업데이트
        /// </summary>
        /// <param name="WOList"></param>
        /// <param name="EmpList"></param>
        /// <returns></returns>
        public bool UpdateWorkOrder(List<WorkOrderVO> WOList, List<EmployeeVO> EmpList)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update tblWorkOrders
                                            set WO_D_Emp_Num = @WO_D_Emp_Num
                                            where WO_Num = @WO_Num ";

                    cmd.Parameters.Add("@WO_D_Emp_Num", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@WO_Num", System.Data.SqlDbType.Int);

                    for (int i = 0; i < EmpList.Count; i++)
                    {
                        cmd.Parameters["@WO_Num"].Value = Convert.ToInt32(WOList[i].WO_Num);
                        cmd.Parameters["@WO_D_Emp_Num"].Value = Convert.ToInt32(EmpList[i].Emp_Num);

                        int iRowAffect = cmd.ExecuteNonQuery();

                        if (iRowAffect < 1)
                            return false;
                    }


                    return true;
                }
            }
            catch (Exception err)
            {
                Log.WriteError(err.Message);
                return false;
            }
        }



        /// <summary>
        /// 현장 마감을 하여 작업 지시 상태를 현장마감으로 바꿔준다
        /// </summary>
        /// <param name="WOList"></param>
        /// <param name="EmpList"></param>
        /// <returns></returns>
        public bool FinishWorkOrder(string WO_Num)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update tblWorkOrders
                                                set WO_Status = '작업 마감'
                                                where WO_Num = @WO_Num";

                    cmd.Parameters.Add("@WO_Num", System.Data.SqlDbType.Int);


                    cmd.Parameters["@WO_Num"].Value = Convert.ToInt32(WO_Num);

                    int iRowAffect = cmd.ExecuteNonQuery();

                    return iRowAffect > 0 ? true : false;
                }
            }
            catch (Exception err)
            {
                Log.WriteError(err.Message);
                return false;
            }
        }
        public void Dispose()
        {
            conn.Close();
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
        public List<WorkOrderVO> GetWorkOrdersInfo(int wpNum, string matNum, int wsNum, string dtFrom, string dtTo)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(@"select Convert(nchar(10), WO.WO_Num)WO_Num, P.Process_Name_D, WP.WP_Name, M.Mat_Name, Convert(nchar(10), PP.ProductionDate, 23) as ProductionDate,
         Convert(nchar(10),SM.Deadline, 23) DeadLine, WO.WO_Status, Convert(nchar(10), WO.WO_Plan_Cnt) WO_Plan_Cnt,
                                      Convert(nchar(10), WO.WO_Order_Cnt)WO_Order_Cnt, WO.WO_Detail, WO.IsShip, Convert(nchar(10), WO.WO_D_Emp_Num) WO_D_Emp_Num,
                                      convert(char(8), WO.WO_StartTime, 24) as WO_StartTime, convert(char(8), WO.WO_FinishTime, 24) as WO_FinishTime
                               from tblWorkOrders WO inner join tblWorkplace WP on WO.WP_Num = WP.WP_Num
                               inner join tblProcess P on WO.Process_Num = P.Process_Num
                               inner join tblMaterials M on WO.Mat_Num = M.Mat_Num
                               inner join tblProductionPlan_D PP on WO.ProductionPlan_D_Num = PP.ProductionPlan_D_Num
                               inner join tblSalesMaster SM on WO.SalesMaster_Num = SM.SalesMaster_Num
                       where Convert(nchar(10), PP.ProductionDate, 23) >= @dtFrom and Convert(nchar(10), SM.LastDate, 23) <= @dtTo ");

                if (wpNum > 0)
                    sb.Append(" and WP.WP_Name = @wpNum");
                if (!string.IsNullOrEmpty(matNum))
                    sb.Append(" and  M.Mat_Name = @matNum");
                if (wsNum > 0)
                    sb.Append(" and WO_Status = @wsNum");

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = sb.ToString();
                    cmd.Connection = conn;

                    if (wpNum > 0)
                        cmd.Parameters.AddWithValue("@wpNum", wpNum);
                    if (!string.IsNullOrEmpty(matNum))
                        cmd.Parameters.AddWithValue("@matNum", matNum);
                    if (wsNum > 0)
                        cmd.Parameters.AddWithValue("@wsNum", wsNum);

                    cmd.Parameters.AddWithValue("@dtFrom", dtFrom.ToString());
                    cmd.Parameters.AddWithValue("@dtTo", dtTo.ToString());

                    List<WorkOrderVO> list = Helper.DataReaderMapToList<WorkOrderVO>(cmd.ExecuteReader());
                    conn.Close();

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
        /// 지시정보 삭제
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public bool DeleteWorkOrdersInfo(List<int> nums)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
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
                    cmd.Connection = conn;
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

        /// <summary>
        /// 작업지시생성에서 자재 검색
        /// </summary>
        /// <param name="matNum"></param>
        /// <returns></returns>
        public List<WorkOrderVO> GetMatCodeInfo(string matNum)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(@"select M.Mat_Num, M.Mat_Name, Convert(nchar(10), WO_Plan_Cnt) as WO_Plan_Cnt
                        from  tblWorkOrders WO inner join tblMaterials M on WO.Mat_Num = M.Mat_Num
                        where 1=1 ");

                if (!string.IsNullOrEmpty(matNum))
                    sb.Append(" and M.Mat_Num = @matNum");

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = sb.ToString();

                    if (!string.IsNullOrEmpty(matNum))
                        cmd.Parameters.AddWithValue("@matNum", matNum);


                    List<WorkOrderVO> list = Helper.DataReaderMapToList<WorkOrderVO>(cmd.ExecuteReader());
                    conn.Close();

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
        /// 작업지시확정할때 날짜 등록
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public bool UpdateWorkOrderDate(WorkOrderVO vo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into tblWorkOrders (WO_Date) 
                                                           values (@WO_Date) ";

                    cmd.Parameters.AddWithValue("@WO_Date", vo.WO_Date);

                    int iRowAffect = cmd.ExecuteNonQuery();
                    conn.Close();

                    return iRowAffect > 0 ? true : false;
                }
            }
            catch (Exception err)
            {
                Log.WriteError(err.Message);
                return false;
            }
        }

        public List<WorkOrderStatusVO> GetWorkOrdersStatusInfo(int wpNum, string matNum, int wsNum, string dtFrom, string dtTo)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(@"select O.WO_Date, W.WP_Name, O.Mat_Num, M.Mat_Name, WO_Status, S.Str_Kind, WO_Order_Cnt, H.ErrorCnt, H.WorkCnt-H.ErrorCnt as GoodsCnt
                            from tblWorkOrders O inner join tblCommonCode C on O.Mat_Num = C.Code_Num
					                             inner join tblMaterials M on O.Mat_Num = M.Mat_Num
			    	                             inner join tblStorages S on O.Str_Num = S.Str_Num
					                             inner join tblWorkHistory H on O.WH_Num = H.WH_Num
					                             inner join tblWorkplace W on O.WP_Num = W.WP_Num
                            where WO_Date = getdate() ");

                if (wpNum > 0)
                    sb.Append(" and WP.WP_Name = @wpNum");
                if (!string.IsNullOrEmpty(matNum))
                    sb.Append(" and  M.Mat_Name = @matNum");
                if (wsNum > 0)
                    sb.Append(" and WO_Status = @wsNum");

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = sb.ToString();
                    cmd.Connection = conn;

                    if (wpNum > 0)
                        cmd.Parameters.AddWithValue("@wpNum", wpNum);
                    if (!string.IsNullOrEmpty(matNum))
                        cmd.Parameters.AddWithValue("@matNum", matNum);
                    if (wsNum > 0)
                        cmd.Parameters.AddWithValue("@wsNum", wsNum);

                    cmd.Parameters.AddWithValue("@dtFrom", dtFrom.ToString());
                    cmd.Parameters.AddWithValue("@dtTo", dtTo.ToString());

                    List<WorkOrderStatusVO> list = Helper.DataReaderMapToList<WorkOrderStatusVO>(cmd.ExecuteReader());
                    conn.Close();

                    return list;
                }
            }

            catch (Exception err)
            {
                Log.WriteError(err.Message);
                return null;
            }
        }
    }
}
