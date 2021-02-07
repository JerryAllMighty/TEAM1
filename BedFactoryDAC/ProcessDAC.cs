using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryDAC
{
    public class ProcessDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection Conn;

        public ProcessDAC()
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
        /// 검색조건에 따른 공정 정보 조회
        /// </summary>
        /// <param name="prcCategory">공정분류</param>
        /// <param name="prcName">상세공정명</param>
        /// <returns></returns>
        /// 
        public List<ProcessVO> GetProcessInfo(string prcCode, string prcName)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(@"select Process_Num, Process_Code, Code_Name as Process_Category, Process_Name_D, Process_Condition, 
                        Firstman, Firstdate, Lastman, Lastdate, IsDeleted
                        from tblProcess inner join tblCommonCode C on Process_Code = Code_Num
                        where 1 = 1 ");

                if (!string.IsNullOrEmpty(prcCode))
                    sb.Append(" and Process_Code = @prcCode");
                if (!string.IsNullOrEmpty(prcName))
                    sb.Append(" and Process_Name_D like @prcName"); // 앞글자 쓰면 해당하는 목록 보이게끔

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = sb.ToString();
                    cmd.Connection = Conn;

                    if (!string.IsNullOrEmpty(prcCode))
                        cmd.Parameters.AddWithValue("@prcCode", prcCode);

                    if (!string.IsNullOrEmpty(prcName))
                        cmd.Parameters.AddWithValue("@prcName", $"%{prcName}%");

                    List<ProcessVO> list = Helper.DataReaderMapToList<ProcessVO>(cmd.ExecuteReader());
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
        /// 공정 정보 등록
        /// <param name="vo">등록목록</param>
        /// </summary>
        public bool InsertProcessInfo(ProcessVO vo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Conn;
                    cmd.CommandText = @"insert into tblProcess (Process_Code, Process_Name_D, Process_Condition, IsDeleted, Firstman, Lastman) 
                                        values (@Process_Code, @Process_Name_D, @Process_Condition, @IsDeleted, @Firstman, @Lastman) ";

                    cmd.Parameters.AddWithValue("@Process_Code", vo.Process_Code);
                    cmd.Parameters.AddWithValue("@Process_Name_D", vo.Process_Name_D);
                    cmd.Parameters.AddWithValue("@Process_Condition", vo.Process_Condition);
                    cmd.Parameters.AddWithValue("@IsDeleted", vo.IsDeleted);
                    cmd.Parameters.AddWithValue("@Firstman", vo.Firstman);
                    cmd.Parameters.AddWithValue("@Lastman", vo.Lastman);

                    int iRowAffect = cmd.ExecuteNonQuery();
                    Conn.Close();

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
        /// 공정 정보 수정
        /// </summary>
        /// <param name="vo">수정목록</param>
        /// <returns></returns>
        public bool UpdateProcessInfo(ProcessVO vo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Conn;
                    cmd.CommandText = @"update tblProcess 
                                           set Process_Code = @Process_Code,
                                               Process_Name_D = @Process_Name_D, Process_Condition = @Process_Condition,
                                               IsDeleted = @IsDeleted, Lastman=@Lastman, Lastdate=getdate() 
                                         where Process_Num = @Process_Num ";

                    cmd.Parameters.AddWithValue("@Process_Code", vo.Process_Code);
                    cmd.Parameters.AddWithValue("@Process_Name_D", vo.Process_Name_D);
                    cmd.Parameters.AddWithValue("@Process_Condition", vo.Process_Condition);
                    cmd.Parameters.AddWithValue("@IsDeleted", vo.IsDeleted);
                    cmd.Parameters.AddWithValue("@Lastman", vo.Lastman);
                    cmd.Parameters.AddWithValue("@Process_Num", vo.Process_Num);

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
        /// 상세공정을 콤보박스에 바인딩
        /// </summary>
        /// <returns></returns>
        public List<CommonCodeVO> GetProcessCombo()
        {
            string sql = @"select cast(Process_Num as nvarchar) as Code_Num, Process_Name_D as Code_Name, '공정' as Category
                           from tblProcess 
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
