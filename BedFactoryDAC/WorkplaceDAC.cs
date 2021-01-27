using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryDAC
{
    public class WorkplaceDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection Conn;

        public WorkplaceDAC()
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
        /// 검색조건에 따른 작업장 정보 조회
        /// </summary>
        /// <param name="prcName">공정명</param>
        /// <param name="wpName">작업장명</param>
        /// <returns></returns>
        public List<WorkplaceVO> GetWorkplaceInfo(string prcName, string wpName)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(@"select WP_Num, W.Process_Num, P.Process_Name, WP_Name, W.Firstman, W.Firstdate, W.Lastman, W.Lastdate, W.IsDeleted
                        from tblWorkplace W inner join tblProcess P on W.Process_Num = P.Process_Num
                        where 1 = 1 ");

                if (!string.IsNullOrEmpty(prcName))
                    sb.Append(" and P.Process_Name = @prcName");
                if (!string.IsNullOrEmpty(wpName))
                    sb.Append(" and WP_Name like @wpName"); // 앞글자 쓰면 해당하는 목록 보이게끔

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = sb.ToString();
                    cmd.Connection = Conn;

                    if (!string.IsNullOrEmpty(prcName))
                        cmd.Parameters.AddWithValue("@Process_Name", prcName);
                    if (!string.IsNullOrEmpty(wpName))
                        cmd.Parameters.AddWithValue("@Process_Name", $"'%{wpName}%'");

                    List<WorkplaceVO> list = Helper.DataReaderMapToList<WorkplaceVO>(cmd.ExecuteReader());
                    Conn.Close();

                    return list;
                }
            }
            catch(Exception err)
            {
                Log.WriteError(err.Message);
                return null;
            }
        }

        /// <summary>
        /// 작업장 정보 등록
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public bool InsertWorkplaceInfo(WorkplaceVO vo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Conn;
                    cmd.CommandText = @"insert tblWorkplace (WP_Name, WP_Note, WP_Other, IsDeleted, Firstman, Lastman)
                                    values (@WP_Name, @WP_Note, @WP_Other, @IsDeleted, @Firstman, @Lastman) ";

                    cmd.Parameters.AddWithValue("WP_Name", vo.WP_Name);
                    cmd.Parameters.AddWithValue("WP_Note", vo.WP_Note);
                    cmd.Parameters.AddWithValue("WP_Other", vo.WP_Other);
                    cmd.Parameters.AddWithValue("IsDeleted", vo.IsDeleted);
                    cmd.Parameters.AddWithValue("Firstman", vo.Firstman);
                    cmd.Parameters.AddWithValue("Lastman", vo.Lastman);

                    int iRowAffect = cmd.ExecuteNonQuery();
                    Conn.Close();

                    return iRowAffect > 0 ? true : false;
                }
            }

            catch(Exception err)
            {
                Log.WriteError(err.Message);
                return false;
            }
        }

        /// <summary>
        /// 작업장 정보 수정
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public bool UpdateWorkplaceInfo(WorkplaceVO vo)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Conn;
                cmd.CommandText = @"update tblWorkplace 
                                    set WP_Name=@WP_Name, WP_Note=@WP_Note, WP_Other=@WP_Other, IsDeleted=@IsDeleted, 
                                    Lastman=@Lastman, Lastdate=@Lastdate
                                    where WP_Num = =@WP_Num ";

                cmd.Parameters.AddWithValue("WP_Name", vo.WP_Name);
                cmd.Parameters.AddWithValue("WP_Note", vo.WP_Note);
                cmd.Parameters.AddWithValue("WP_Other", vo.WP_Other);
                cmd.Parameters.AddWithValue("IsDeleted", vo.IsDeleted);
                cmd.Parameters.AddWithValue("Lastman", vo.Lastman);
                cmd.Parameters.AddWithValue("Lastdate", vo.Lastdate);

                int iRowAffect = cmd.ExecuteNonQuery();

                return iRowAffect > 0 ? true : false;
            }
        }
    }
}
