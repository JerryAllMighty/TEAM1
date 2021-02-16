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
    }
}
