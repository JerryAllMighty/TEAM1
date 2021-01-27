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
        /// <param name="fcsName">공정분류</param>
        /// <param name="fcsNum">공정상세번호</param>
        /// <returns></returns>
        /// 
        public List<ProcessDetailVO> GetProcessDetailInfo(string prcName, string prcName_D)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"select P.Process_Category, D.Process_D_Num, D.Process_D_Name,  
                        D.Firstman, CONVERT(varchar(10), D.Firstdate, 23) Firstdate, 
	                    D.Lastman, CONVERT(varchar(10), D.Lastdate, 23) Lastdate, D.IsDeleted, Process_D_Condition
                        from tblProcess P inner join tblProcess_D D on D.Process_Num = P.Process_Num
                        where 1 = 1");

            if (!string.IsNullOrEmpty(prcName))
                sb.Append(" and P.Process_Category = @prcName");
            if (!string.IsNullOrEmpty(prcName_D))
                sb.Append(" and Process_D_Name = @prcName_D");

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = sb.ToString();
                cmd.Connection = Conn;

                cmd.Parameters.AddWithValue("@P.Process_Category", prcName);
                cmd.Parameters.AddWithValue("@Process_D_Name", prcName_D);

                List<ProcessDetailVO> list = Helper.DataReaderMapToList<ProcessDetailVO>(cmd.ExecuteReader());
                Conn.Close();

                return list;
            }
        }

        /// <summary>
        /// 공정 전체 정보 조회
        /// </summary>
        /// <returns></returns>
        public List<ProcessDetailVO> GetProcessDetailAllInfo()
        {
            string sql = @"select P.Process_Category, D.Process_D_Num, D.Process_D_Name,  
                           D.Firstman, CONVERT(varchar(10), D.Firstdate, 23) Firstdate, 
	                       D.Lastman, CONVERT(varchar(10), D.Lastdate, 23) Lastdate, D.IsDeleted, Process_D_Condition
                           from tblProcess P inner join tblProcess_D D on D.Process_Num = P.Process_Num
                           where 1 = 1";
                        
            using (SqlCommand cmd = new SqlCommand(sql, Conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<ProcessDetailVO> list = Helper.DataReaderMapToList<ProcessDetailVO>(reader);

                Conn.Close();
                return list;
            }
        }


    }
}
