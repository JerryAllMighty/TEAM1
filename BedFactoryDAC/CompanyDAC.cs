using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryDAC
{
    public class CompanyDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection Conn;

        public CompanyDAC()
        {
            strConn = ConnectionString;
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
        /// 검색조건에 따른 업체 정보 조회
        /// </summary>
        /// <param name="comNum">업체번호</param>
        /// <param name="comName">업체명</param>
        /// <param name="comType">업체타입</param>
        /// <returns></returns>
        public List<CompanyVO> GetCompanyInfo(string comNum, string comName, string comType)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"select C.Com_Num, C.Com_Name, Com_Addr, Com_Represent, Com_Phone, Com_Category, Com_Emp_Num, Com_Info, 
	                    C.FirstMan, CONVERT(varchar(10), C.FirstDate, 23) FirstDate,
	                    C.LastMan, CONVERT(varchar(10), C.LastDate, 23) LastDate
                        from tblCompany C inner join tblOrders O on C.Com_Num = O.Com_Num
                        where 1 = 1 ");

            if (!string.IsNullOrEmpty(comNum))
                sb.Append(" and C.Com_Num = @comNum");
            if (!string.IsNullOrEmpty(comName))
                sb.Append(" and C.Com_Name = @comName");
            if (!string.IsNullOrEmpty(comType))
                sb.Append(" and C.Com_Category = @comType");

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = sb.ToString();
                cmd.Connection = Conn;

                cmd.Parameters.AddWithValue("@Com_Num", comNum);
                cmd.Parameters.AddWithValue("@Com_Name", comName);
                cmd.Parameters.AddWithValue("@Com_Category", comType);

                List<CompanyVO> list = Helper.DataReaderMapToList<CompanyVO>(cmd.ExecuteReader());
                Conn.Dispose();
                return list;
            }



        }


        public List<CompanyVO> GetEveryCompanyName()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Conn;
                    cmd.CommandText = @"select Com_Num, Com_Code, Com_Name
                                        from tblCompany";

                    List<CompanyVO> list = Helper.DataReaderMapToList<CompanyVO>(cmd.ExecuteReader());
                    return list != null ? list : null;
                }
            }
            catch (Exception err)
            {
                Log.WriteError(err.Message);
                return null;
            }
        }
    }
}
