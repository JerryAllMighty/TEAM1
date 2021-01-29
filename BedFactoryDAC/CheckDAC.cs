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
        /// 검사항목정보 등록
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
                    cmd.CommandText = @"insert into tblCheckInfo(CheckName, CheckKind, Check_Detail, Firstman, Lastman)
                                            values(@CheckName, @CheckKind, @Check_Detail, @Firstman, @Lastman)";
                    cmd.Parameters.AddWithValue("@CheckName", vo.CheckName);
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
        /// 검사항목정보 출력
        /// </summary>
        /// <returns></returns>
        public List<CheckInfoVO> GetCheckInfo()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select Check_Info_Num, CheckName, CheckKind, Check_Detail, Firstman, Firstdate, Lastman, Lastdate
                                    from tblCheckInfo";

                List<CheckInfoVO> list = Helper.DataReaderMapToList<CheckInfoVO>(cmd.ExecuteReader());

                return list;
            }
        }

        /// <summary>
        /// 검사항목정보 수정
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
                                        set CheckName = @CheckName, CheckKind = @CheckKind, Check_Detail = @Check_Detail, Lastman = @Lastman, Lastdate = @Lastdate)
                                        where Check_Info_Num = @Check_Info_Num";
                    cmd.Parameters.AddWithValue("@CheckName", vo.CheckName);
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



        /// <summary>
        /// 자재번호 당 검사항목 출력
        /// </summary>
        /// <param name="mat_Num">자재번호</param>
        /// <returns></returns>
        public List<CheckVO> GetCheck(string mat_Num)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select Check_Num, CheckKind, Lastman, Lastdate, Mat_Num, Check_Info_Num
                                    from tblCheck as c
                                    join tblCheckinfo as ci on c.Check_Num = ci.Check_Num
                                    where Mat_Num = @Mat_Num";
                cmd.Parameters.AddWithValue("@Mat_Num", mat_Num);

                List<CheckVO> list = Helper.DataReaderMapToList<CheckVO>(cmd.ExecuteReader());

                return list;
            }
        }

        /// <summary>
        /// 자재번호 당 검사항목 수정
        /// </summary>
        /// <param name="vo"></param>
        /// <param name="check_Info_Num">검사항목</param>
        /// <returns></returns>
        public bool InsertCheck(string mat_Num, int check_Info_Num, int lastMan)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into tblCheck set Mat_Num = @Mat_Num, Check_Info_Num = @Check_Info_Num, Lastman = @Lastman, Lastdate = getdate()";
                    cmd.Parameters.AddWithValue("@Mat_Num", mat_Num);
                    cmd.Parameters.AddWithValue("@Check_Info_Num", check_Info_Num);
                    cmd.Parameters.AddWithValue("@Lastman", lastMan);

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

        public bool DeleteCheck(string mat_Num)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"delete from tblCheck where Mat_Num = @Mat_Num";
                    cmd.Parameters.AddWithValue("@Mat_Num", mat_Num);

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
