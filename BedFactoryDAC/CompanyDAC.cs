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
        /// <param name="comCode">업체타입</param>
        /// <param name="comName">업체명</param>
        /// <returns></returns>
        public List<CompanyVO> GetCompanyInfo(string comCode, string comName)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(@"select Com_Num, Com_Code, Code_Name as Com_Type, Com_Name, Com_Represent, Com_Addr, Com_Phone, 
	                           Com_Manager, Com_Info,IsUse, FirstMan, FirstDate, LastMan, LastDate
                               from tblCompany inner join tblCommonCode C on Com_Code = Code_Num
                               where 1 = 1 ");

                if (!string.IsNullOrEmpty(comCode))
                    sb.Append(" and Com_Code = @comCode");
                if (!string.IsNullOrEmpty(comName))
                    sb.Append(" and Com_Name like @comName");

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = sb.ToString();
                    cmd.Connection = Conn;

                    if (!string.IsNullOrEmpty(comCode))
                        cmd.Parameters.AddWithValue("@comCode", comCode);
                    if (!string.IsNullOrEmpty(comName))
                        cmd.Parameters.AddWithValue("@comName", $"%{comName}%");

                    List<CompanyVO> list = Helper.DataReaderMapToList<CompanyVO>(cmd.ExecuteReader());
                    Conn.Dispose();
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
        /// 업체 정보 등록
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public bool InsertCompnayInfo(CompanyVO vo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Conn;
                    cmd.CommandText = @"insert into tblCompany (Com_Code, Com_Name, Com_Addr, Com_Represent,
                                                                Com_Phone, Com_Info, IsUse, FirstMan, LastMan)
                                        values (@Com_Code, @Com_Name, @Com_Addr, @Com_Represent, @Com_Phone, 
                                                  @Com_Manager, @Com_Info, @IsUse, @FirstMan, @LastMan) ";

                    cmd.Parameters.AddWithValue("Com_Code", vo.Com_Code);
                    cmd.Parameters.AddWithValue("Com_Name", vo.Com_Name);
                    cmd.Parameters.AddWithValue("Com_Addr", vo.Com_Addr);
                    cmd.Parameters.AddWithValue("Com_Represent", vo.Com_Represent);
                    cmd.Parameters.AddWithValue("Com_Phone", vo.Com_Phone);
                    cmd.Parameters.AddWithValue("Com_Manager", vo.Com_Manager);
                    cmd.Parameters.AddWithValue("Com_Info", vo.Com_Info);
                    cmd.Parameters.AddWithValue("IsUse", vo.IsUse);
                    cmd.Parameters.AddWithValue("FirstMan", vo.FirstMan);
                    cmd.Parameters.AddWithValue("LastMan", vo.LastMan);

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
        /// 업체 정보 수정
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public bool UpdateCompnayInfo(CompanyVO vo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Conn;
                    cmd.CommandText = @"update tblCompany 
                                       set Com_Code = @Com_Code, Com_Name = @Com_Name, Com_Addr= @Com_Addr, Com_Represent= @Com_Represent, Com_Manager= @Com_Manager,
                                           Com_Phone = @Com_Phone,Com_Info = @Com_Info, IsUse = @IsUse, LastMan = @LastMan, LastDate = getdate()
					                 where Com_Num = @Com_Num ";

                    cmd.Parameters.AddWithValue("Com_Code", vo.Com_Code);
                    cmd.Parameters.AddWithValue("Com_Name", vo.Com_Name);
                    cmd.Parameters.AddWithValue("Com_Addr", vo.Com_Addr);
                    cmd.Parameters.AddWithValue("Com_Represent", vo.Com_Represent);
                    cmd.Parameters.AddWithValue("Com_Manager", vo.Com_Manager);
                    cmd.Parameters.AddWithValue("Com_Phone", vo.Com_Phone);
                    cmd.Parameters.AddWithValue("Com_Info", vo.Com_Info);
                    cmd.Parameters.AddWithValue("IsUse", vo.IsUse);
                    cmd.Parameters.AddWithValue("LastMan", vo.LastMan);
                    cmd.Parameters.AddWithValue("Com_Num", vo.Com_Num);

                    int iRowAffect = cmd.ExecuteNonQuery();

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
        /// 
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// 회사정보삭제
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public bool DeleteComInfo(int num)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Conn;
                    cmd.CommandText = @"delete 
                                        from tblCompany
                                        where Com_Num = @Com_Num";

                    cmd.Parameters.AddWithValue("@Com_Num", num);

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
    }
}
