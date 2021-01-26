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
        /// 검색조건에 따른 설비군 정보 조회
        /// </summary>
        /// <param name="fcsName">공정분류</param>
        /// <param name="fcsNum">공정상세번호</param>
        /// <returns></returns>
        /// 
        public List<ProcessDetailVO> GetProcessDetailInfo(string procCate, string procdNum)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"select P.Process_Category, Process_D_Num, D.Process_Num, Process_D_Name, Process_D_Condition, 
                       D.Firstman, D.Lastman, CONVERT(varchar(10) , D.Firstdate, 23) Firstdate, 
	                   CONVERT(varchar(10) , D.Lastdate, 23) Lastdate, D.IsDeleted
                       from tblProcess P inner join tblProcess_D D on D.Process_Num = P.Process_Num
                       where 1 = 1");

            if (!string.IsNullOrEmpty(procCate))
                sb.Append(" and P.Process_Category = @procCate");
            if (!string.IsNullOrEmpty(procdNum))
                sb.Append(" and Process_D_Num = @procdNum");

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = sb.ToString();
                cmd.Connection = Conn;

                cmd.Parameters.AddWithValue("@P.Process_Category", procCate);
                cmd.Parameters.AddWithValue("@Process_D_Num", procdNum);

                List<ProcessDetailVO> list = Helper.DataReaderMapToList<ProcessDetailVO>(cmd.ExecuteReader());
                Conn.Close();

                return list;
            }
        }

        //설비군 삭제
        public string DeleteFacilities()
        {
            return null;
        }
    }
}
