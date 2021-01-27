using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryDAC
{
    public class AuthorityDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;

        public AuthorityDAC()
        {
            strConn = this.ConnectionString;
            conn = new SqlConnection(strConn);
            conn.Open();
        }
        /// <summary>
        /// 모든 권한에 관한 정보를 가져온다
        /// </summary>
        /// <returns></returns>
        public List<AuthorityVO> GetAuthorityInfo()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select Auth_Num, ListNum, Auth_Name, FirstMan, FirstDate, LastMan,LastDate, IsDeleted
                                        from tblAuthority";
                     List<AuthorityVO> list = Helper.DataReaderMapToList<AuthorityVO>(cmd.ExecuteReader());

                    return list != null ? list : null;
                }
            }
            catch (Exception err)
            {
                Log.WriteError(err.Message);
                return null;
            }
        }

        public List<AuthorityVO> GetAuthorityInfoByGroupList(string GroupName)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select AL.ListNum,AL.Auth_Department, A.Auth_Num, A.Auth_Name
                                        from tblAuthorityList AL inner join tblAuthority A
                                        on AL.ListNum = A.ListNum
                                        where AL.Auth_Department = @Auth_Department";

                    cmd.Parameters.AddWithValue("@Auth_Department", GroupName);

                    List<AuthorityVO> list = Helper.DataReaderMapToList<AuthorityVO>(cmd.ExecuteReader());

                    return list != null ? list : null;
                }
            }
            catch (Exception err)
            {
                Log.WriteError(err.Message);
                return null;
            }
        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
