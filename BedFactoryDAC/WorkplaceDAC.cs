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
        public List<WorkplaceVO> GetWorkplaceInfo(int prcNum, string wpName)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(@"select WP_Num, W.Process_Num, P.Process_Name_D as Process_Name_Detail, 
	                       WP_Name, WP_Note, WP_Other, W.IsDeleted, W.Firstman, W.Firstdate, W.Lastman, W.Lastdate
	                       from tblWorkplace W inner join tblProcess P on W.Process_Num = P.Process_Num
                           where 1=1 ");

                if (prcNum > 0)
                    sb.Append(" and W.Process_Num = @prcNum");
                if (!string.IsNullOrEmpty(wpName))
                    sb.Append(" and WP_Name like @wpName"); // 앞글자 쓰면 해당하는 목록 보이게끔

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = sb.ToString();
                    cmd.Connection = Conn;

                    if (prcNum > 0)
                        cmd.Parameters.AddWithValue("@prcNum", prcNum);
                    if (!string.IsNullOrEmpty(wpName))
                        cmd.Parameters.AddWithValue("@wpName", $"%{wpName}%");

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
                    cmd.CommandText = @"insert into tblWorkplace (Process_Num, WP_Name, WP_Note, WP_Other, IsDeleted, Firstman, Lastman)
                                    values (@Process_Num, @WP_Name, @WP_Note, @WP_Other, @IsDeleted, @Firstman, @Lastman) ";

                    cmd.Parameters.AddWithValue("@Process_Num", vo.Process_Num);
                    cmd.Parameters.AddWithValue("@WP_Name", vo.WP_Name);
                    cmd.Parameters.AddWithValue("@WP_Note", vo.WP_Note);
                    cmd.Parameters.AddWithValue("@WP_Other", vo.WP_Other);
                    cmd.Parameters.AddWithValue("@IsDeleted", vo.IsDeleted);
                    cmd.Parameters.AddWithValue("@Firstman", vo.Firstman);
                    cmd.Parameters.AddWithValue("@Lastman", vo.Lastman);

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
        public bool UpdateWorkplaceInfo(WorkplaceVO vo)  // => update 구문 두번 써야 하므로 프로시저 사용
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Conn;
                cmd.CommandText = @"update tblWorkplace 
                                       set Process_Num=@Process_Num, WP_Name=@WP_Name, WP_Note=@WP_Note, WP_Other=@WP_Other,
                                           IsDeleted=@IsDeleted, Lastman=@Lastman, Lastdate=getdate() 
                                     where WP_Num=@WP_Num ";

                cmd.Parameters.AddWithValue("@Process_Num", vo.Process_Num);
                cmd.Parameters.AddWithValue("@WP_Name", vo.WP_Name);
                cmd.Parameters.AddWithValue("@WP_Note", vo.WP_Note);
                cmd.Parameters.AddWithValue("@WP_Other", vo.WP_Other);
                cmd.Parameters.AddWithValue("@IsDeleted", vo.IsDeleted);
                cmd.Parameters.AddWithValue("@Lastman", vo.Lastman);
                cmd.Parameters.AddWithValue("@WP_Num", vo.WP_Num);

                int iRowAffect = cmd.ExecuteNonQuery();

                return iRowAffect > 0 ? true : false;
            }
        }


        /// <summary>
        /// 작업장을 콤보박스에 바인딩
        /// </summary>
        /// <returns></returns>
        public List<CommonCodeVO> GetWorkplaceCombo()
        {
            string sql = @"select cast(WP_Num as nvarchar) as Code_Num, WP_Name as Code_Name, '작업장' as Category
                           from tblWorkplace 
                           where Isdeleted = 'N' ";

            using (SqlCommand cmd = new SqlCommand(sql, Conn))
            {
                List<CommonCodeVO> list = Helper.DataReaderMapToList<CommonCodeVO>(cmd.ExecuteReader());
                Conn.Close();

                return list;
            }
        }
    }
}
