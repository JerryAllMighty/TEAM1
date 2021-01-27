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
        /// <param name="prcName">공정명</param>
        /// <returns></returns>
        /// 
        public List<ProcessVO> GetProcessDetailInfo(string prcCategory, string prcName)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"select Process_Num, Process_Category, Code_Name as Process_Category_Name, Process_Name, Process_Condition, 
      Firstman, CONVERT(varchar(10), Firstdate, 23) Firstdate, Lastman, CONVERT(varchar(10), Lastdate, 23) Lastdate, IsDeleted
from tblProcess inner join CommonCode C on Process_Category = Code_Num
where 1 = 1 ");

            if (!string.IsNullOrEmpty(prcCategory))
                sb.Append(" and Process_Category = @prcCategory");
            if (!string.IsNullOrEmpty(prcName))
                sb.Append(" and Process_Name like @prcName");

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = sb.ToString();
                cmd.Connection = Conn;

                if (!string.IsNullOrEmpty(prcCategory))
                    cmd.Parameters.AddWithValue("@Process_Category", prcCategory);

                if (!string.IsNullOrEmpty(prcName))
                    cmd.Parameters.AddWithValue("@Process_Name", $"'%{prcName}%'");

                List<ProcessVO> list = Helper.DataReaderMapToList<ProcessVO>(cmd.ExecuteReader());
                Conn.Close();

                return list;
            }
        }

        /// <summary>
        /// 공정 정보 등록
        /// </summary>
        /// <param name="prv"></param>
        /// <returns></returns>
        public bool InsertProcessInfo(ProcessVO vo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Conn;
                    cmd.CommandText = @"insert into tblProcess (Process_Category, Process_Name, Process_Condition, IsDeleted) 
                                    value (@Process_Category, @Process_Name, @Process_Condition, @IsDeleted, @Firstman, @Lastman) ";

                    cmd.Parameters.AddWithValue("@Process_Category", vo.Process_Category);
                    cmd.Parameters.AddWithValue("@Process_Name", vo.Process_Name);
                    cmd.Parameters.AddWithValue("@Process_Condition", vo.Process_Condition);
                    cmd.Parameters.AddWithValue("@IsDeleted", vo.IsDeleted);
                    cmd.Parameters.AddWithValue("@Firstman", vo.IsDeleted);
                    cmd.Parameters.AddWithValue("@Lastman", vo.IsDeleted);

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

        public bool UpdateProcessInfo(ProcessVO vo, string prcCategory)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Conn;
                cmd.CommandText = @"update tblProcess 
                                    set Process_Category = @Process_Category, 
                                        Process_Name = @Process_Name, Process_Condition = @Process_Condition,
                                        IsDeleted = @IsDeleted, Lastman=@Lastman, Lastdate=getdate()   
                                    where Process_Num = @Process_Num";

                cmd.Parameters.AddWithValue("@Process_Category", vo.Process_Category);
                cmd.Parameters.AddWithValue("@Process_Name", vo.Process_Name);
                cmd.Parameters.AddWithValue("@Process_Condition", vo.Process_Condition);
                cmd.Parameters.AddWithValue("@IsDeleted", vo.IsDeleted);
                cmd.Parameters.AddWithValue("@Lastman", vo.Lastman);
                cmd.Parameters.AddWithValue("@Process_Num", vo.Process_Num);

                int iRowAffect = cmd.ExecuteNonQuery();

                return iRowAffect > 0 ? true : false;
            }
        }

    }
}
