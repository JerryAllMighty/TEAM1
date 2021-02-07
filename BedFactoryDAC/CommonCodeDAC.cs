using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryDAC
{
    public class CommonCodeDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;

        public CommonCodeDAC()
        {
            strConn = this.ConnectionString;
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        /// <summary>
        /// 공통코드 정보를 모두 가져오는 함수
        /// </summary>
        /// <returns></returns>
        public List<CommonCodeVO> GetCommonCodeInfo()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select Code_Num, Code_Name, Category, P_Code from tblCommonCode";

                    List<CommonCodeVO> list = Helper.DataReaderMapToList<CommonCodeVO>(cmd.ExecuteReader());
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
        /// 공통코드 정보에 등록하는 함수
        /// </summary>
        /// <returns></returns>
        public bool InsertCommonCode(CommonCodeVO commoncodeinfo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into tblCommonCode(Code_Num, Code_Name, Category, P_Code)
                                            values(@Code_Num, @Code_Name, @Category, @P_Code)";
                    cmd.Parameters.AddWithValue("@Code_Num", commoncodeinfo.Code_Num);
                    cmd.Parameters.AddWithValue("@Code_Name", commoncodeinfo.Code_Name);
                    cmd.Parameters.AddWithValue("@Category", commoncodeinfo.Category);
                    cmd.Parameters.AddWithValue("@P_Code", commoncodeinfo.P_Code);

                    int iRowAffect =  cmd.ExecuteNonQuery();

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
        /// 공통코드 정보 수정하는 함수
        /// </summary>
        /// <returns></returns>

        public bool UpdateCommonCode(CommonCodeVO commoncodeinfo, string currentCodeNum)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update tblCommonCode
                                                    set
                                                    Code_Num = @Code_Num,
                                                    Code_Name= @Code_Name,
                                                    Category= @Category, 
                                                    P_Code= @P_Code
                                                    where Code_Num = @currentCodeNum";

                    cmd.Parameters.AddWithValue("@Code_Num", commoncodeinfo.Code_Num);
                    cmd.Parameters.AddWithValue("@Code_Name", commoncodeinfo.Code_Name);
                    cmd.Parameters.AddWithValue("@Category", commoncodeinfo.Category);
                    cmd.Parameters.AddWithValue("@P_Code", commoncodeinfo.P_Code);
                    cmd.Parameters.AddWithValue("@currentCodeNum", currentCodeNum);

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
        /// 공통코드 정보 삭제하는 함수
        /// </summary>
        /// <returns></returns>
        public bool DeleteCommonCode(CommonCodeVO commoncodeinfo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"delete 
                                        from tblCommonCode
                                        where Code_Num = @Code_Num";

                    cmd.Parameters.AddWithValue("@Code_Num", commoncodeinfo.Code_Num);

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
