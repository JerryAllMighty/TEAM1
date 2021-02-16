using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryDAC
{
    public class WorkHistoryDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;
        public WorkHistoryDAC()
        {
            strConn = this.ConnectionString;
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        /// <summary>
        /// 생산 실적 저장하는 함수
        /// </summary>
        /// <param name="workhistoryinfo"></param>
        /// <returns></returns>
        public bool UpdateWorkHistoryCnt(WorkHistoryVO workhistoryinfo, string ErrorKind, int ErrorCnt)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SP_WorkHistoryCnt";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@WorkCnt", workhistoryinfo.WorkCnt);
                    cmd.Parameters.AddWithValue("@WO_Num", workhistoryinfo.WO_Num);
                    cmd.Parameters.AddWithValue("@WO_StartTime", workhistoryinfo.WO_StartTime);
                    cmd.Parameters.AddWithValue("@WO_FinishTime", workhistoryinfo.WO_FinishTime);
                    cmd.Parameters.AddWithValue("@ErrorCnt", ErrorCnt);
                    cmd.Parameters.AddWithValue("@ErrorKind", ErrorKind);
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
