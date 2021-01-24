using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BedFactoryVO;

namespace BedFactoryDAC
{
    
   public class CheckDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;

        public CheckDAC()
        {
            strConn = this.ConnectionString;
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        /// <summary>
        /// 검사항목 등록
        /// </summary>
        /// <param name="vo">검사항목</param>
        /// <returns></returns>
        public bool InsertCheckInfo(CheckInfoVO vo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into tblCheckInfo(CheckKind, Check_Detail, Firstman, Lastman)
                                            values(@CheckKind, @Check_Detail, @Firstman, @Lastman)";
                    cmd.Parameters.AddWithValue("@CheckKind", vo.CheckKind);
                    cmd.Parameters.AddWithValue("@Check_Detail", vo.Check_Detail);
                    cmd.Parameters.AddWithValue("@Firstman", vo.Firstman);
                    cmd.Parameters.AddWithValue("@Lastman", vo.Lastman);

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

        /// <summary>
        /// 검사항목 수정
        /// </summary>
        /// <param name="vo">검사항목</param>
        /// <returns></returns>
        public bool UpdateCheckInfo(CheckInfoVO vo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update tblCheckInfo
                                        set CheckKind = @CheckKind, Check_Detail = @Check_Detail, Lastman = @Lastman, Lastdate = @Lastdate)
                                        where Check_Info_Num = @Check_Info_Num";
                    cmd.Parameters.AddWithValue("@CheckKind", vo.CheckKind);
                    cmd.Parameters.AddWithValue("@Check_Detail", vo.Check_Detail);
                    cmd.Parameters.AddWithValue("@Lastman", vo.Lastman);
                    cmd.Parameters.AddWithValue("@Lastdate", vo.Lastdate);
                    cmd.Parameters.AddWithValue("@Check_Info_Num", vo.Check_Info_Num);

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
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
