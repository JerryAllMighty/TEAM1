﻿using BedFactoryVO;
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

        /// <summary>
        /// 그룹이름으로 해당 그룹에 해당하는 권한 정보를 가져온다
        /// </summary>
        /// <param name="GroupName"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 권한을 추가한다
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public bool InsertAuthority(List<AuthorityVO> list)
        {
            try {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into tblAuthority (ListNum, Auth_Name, FirstMan, LastMan, IsDeleted)
                                            values(@ListNum, @Auth_Name, @FirstMan, @LastMan, @IsDeleted)";

                    cmd.Parameters.Add("@ListNum", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@Auth_Name", System.Data.SqlDbType.NVarChar);
                    cmd.Parameters.Add("@FirstMan", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@LastMan", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@IsDeleted", System.Data.SqlDbType.NChar);

                    for (int i = 0; i < list.Count; i ++)
                    {
                        cmd.Parameters["@ListNum"].Value = list[i].ListNum;
                        cmd.Parameters["@Auth_Name"].Value = list[i].Auth_Name;
                        cmd.Parameters["@FirstMan"].Value = list[i].FirstMan;
                        cmd.Parameters["@LastMan"].Value = list[i].LastMan;
                        cmd.Parameters["@IsDeleted"].Value = list[i].IsDeleted;

                        int iRowAffect = cmd.ExecuteNonQuery();

                        if (iRowAffect < 1)
                            return false;
                    }
                    return true;
                }
            }
            catch (Exception err)
            {
                Log.WriteError(err.Message);
                return false;
            }
        }

        public int GetAuthorityListNum(string GroupCode)
        {
            try {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select ListNum
                                        from tblAuthorityList
                                        where GroupCode = @GroupCode";

                    cmd.Parameters.AddWithValue("@GroupCode", GroupCode);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception err)
            {
                Log.WriteError(err.Message);
                return 0;
            }
        }

        /// <summary>
        /// 직원이 가지고 있는 권한의 메뉴리스트
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public List<AuthorityVO> GetEmployeeAuthName(int num)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select A.Auth_Name
                                          from tblEmployees E 
                                          	 join tblAuthorityList AL on E.Emp_Department = AL.Auth_Department
                                          	 join tblAuthority A on AL.ListNum = A.ListNum
                                          	 where E.Emp_Num = @Emp_Num";

                    cmd.Parameters.AddWithValue("@Emp_Num", num);

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
