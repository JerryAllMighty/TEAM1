using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryDAC
{
    public class BalzooDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;

        public BalzooDAC()
        {
            strConn = this.ConnectionString;
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        /// <summary>
        ///  발주 PK를 가져오는 함수
        /// </summary>
        /// <returns></returns>
        public int GetBalzooNum()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select max(Bz_Num) from tblBalzoo";

                    int iRowAffect = Convert.ToInt32(cmd.ExecuteScalar());

                    return iRowAffect > 0 ? iRowAffect : 0;
                }
            }
            catch (Exception err)
            {
                Log.WriteError(err.Message);
                return 0;
            }
        }

        /// <summary>
        /// 계획 생성시 발주 마스터를 넣는 함수
        /// </summary>
        /// <param name="Com_Num"></param>
        /// <param name="FirstMan"></param>
        /// <returns></returns>
        public bool InsertMasterBalzoo(int Com_Num, int FirstMan)
        {
            try {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into tblBalzoo(Com_Num, FirstMan)
                                            values(@Com_Num, @FirstMan)";
                    cmd.Parameters.AddWithValue("@Com_Num", Com_Num);
                    cmd.Parameters.AddWithValue("@FirstMan", FirstMan);

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
        /// 발주 상세 테이블 입력
        /// </summary>
        /// <param name="Com_Num"></param>
        /// <param name="FirstMan"></param>
        /// <returns></returns>
        public bool InsertDetailBalzoo(string Bz_D_Num,int Bz_Num, string Mat_Num, int BzCnt, string Status, string expecteddate, string isCancel)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into tblBalzoo_D(Bz_D_Num,Bz_Num, Mat_Num, Bz_Cnt, Bz_D_Status, ExpectedDate, Bz_IsCancel)
                                            values(@Bz_D_Num,@Bz_Num, @Mat_Num, @Bz_Cnt, @Bz_D_Status, @ExpectedDate, @Bz_IsCancel)";
                    cmd.Parameters.AddWithValue("@Bz_D_Num", Bz_D_Num);
                    cmd.Parameters.AddWithValue("@Bz_Num", Bz_Num);
                    cmd.Parameters.AddWithValue("@Mat_Num", Mat_Num);
                    cmd.Parameters.AddWithValue("@Bz_Cnt", BzCnt);
                    cmd.Parameters.AddWithValue("@Bz_D_Status", Status);
                    cmd.Parameters.AddWithValue("@ExpectedDate", expecteddate);
                    cmd.Parameters.AddWithValue("@Bz_IsCancel", isCancel);


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
        public List<BalzooVO> BalzooSelect(DateTime fromDate, DateTime toDate)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select BD.Bz_Num, Bz_D_Num, C.Com_Name, M.Mat_Name, Bz_Cnt, Bz_D_Status, ExpectedDate
                                          from tblBalzoo_D BD join tblBalzoo B on BD.Bz_Num = B.Bz_Num join tblMaterials M on BD.Mat_Num = M.Mat_Num
                                                join tblCompany C on B.Com_Num = C.Com_Num
                                         where Bz_IsCancel = 'N' and ExpectedDate >= @fromDate and ExpectedDate <= @toDate";
                    cmd.Parameters.AddWithValue("@fromDate", fromDate.Date);
                    cmd.Parameters.AddWithValue("@toDate", toDate.Date);

                    List<BalzooVO> list = Helper.DataReaderMapToList<BalzooVO>(cmd.ExecuteReader());
                    conn.Close();
                    return list;
                }
            }
            catch (Exception err)
            {
                Log.WriteError(err.Message);
                return null;
            }
        }

        public List<BalzooVO> WarehousingWait(DateTime fromDate, DateTime toDate)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select Bz_D_Num, Com_Name, Mat_Name, Bz_Cnt, Mat_Cnt, (Bz_Cnt - Mat_Cnt) R_Quantity, ExpectedDate
                                          from
                                          (select BD.Bz_D_Num, C.Com_Name, M.Mat_Name, Bz_Cnt
                                          	   , sum(isnull(W.Mat_Cnt, 0)) Mat_Cnt, Bz_D_Status, ExpectedDate
                                            from tblBalzoo_D BD join tblBalzoo B on BD.Bz_Num = B.Bz_Num join tblMaterials M on BD.Mat_Num = M.Mat_Num
                                                                join tblCompany C on B.Com_Num = C.Com_Num
                                          		   left outer join tblWearing W on BD.Bz_D_Num = W.Bz_D_Num
                                           where Bz_IsCancel = 'N' and Bz_D_Status = 'N' and ExpectedDate >= @fromDate and ExpectedDate <= @toDate
                                          group by BD.Bz_D_Num, Com_Name, Mat_Name, Bz_Cnt, Bz_D_Status, ExpectedDate) A";
                    cmd.Parameters.AddWithValue("@fromDate", fromDate.Date);
                    cmd.Parameters.AddWithValue("@toDate", toDate.Date);

                    List<BalzooVO> list = Helper.DataReaderMapToList<BalzooVO>(cmd.ExecuteReader());
                    conn.Close();
                    return list;
                }
            }
            catch (Exception err)
            {
                Log.WriteError(err.Message);
                return null;
            }
        }

        public bool StateIsWait(WearingVO vo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"SP_WearingWait";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Bz_D_Num", vo.Bz_D_Num);
                    cmd.Parameters.AddWithValue("@FirstMan", vo.FirstMan);
                    cmd.Parameters.AddWithValue("@Mat_Cnt", vo.Mat_Cnt);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception err)
            {
                Log.WriteError(err.Message);
                return false;
            }
        }

        public List<BalzooVO> BalzooAndM_Use(int dNum)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select M.Mat_Name, MaterialUse_Cnt, MP.Firstdate, Mat_Cnt, MP.Mat_Num
                                          from tblMaterialUsePlan MP join tblMaterials M on MP.Mat_Num = M.Mat_Num
                                          	   join (select  W.Mat_Num, (W.Mat_Cnt - isnull(SD.Ship_Cnt, 0)) Mat_Cnt
                                          		     from(
                                          		          select Str_Num, Mat_Num, Sum(Mat_Cnt) Mat_Cnt 
                                          			   	  from tblWearing group by Str_Num, Mat_Num
                                          			      ) W join tblStorages S on W.Str_Num = S.Str_Num
                                          			     join tblMaterials M on W.Mat_Num = M.Mat_Num
                                          		         left outer join (select Str_Num, Mat_Num, sum(Ship_Cnt) Ship_Cnt 
                                          		                          from tblShipment_D group by Str_Num, Mat_Num) SD 
                                          	          on SD.Str_Num = W.Str_Num and SD.Mat_Num = W.Mat_Num) A
                                          	   on A.Mat_Num = MP.Mat_Num
                                         where MP.Demand_Plan_Num = @Demand_Plan_Num";
                    cmd.Parameters.AddWithValue("@Demand_Plan_Num", dNum);

                    List<BalzooVO> list = Helper.DataReaderMapToList<BalzooVO>(cmd.ExecuteReader());
                    conn.Close();
                    return list;
                }
            }
            catch (Exception err)
            {
                Log.WriteError(err.Message);
                return null;
            }
        }

        public List<BalzooVO> SearchPlanNum()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select Demand_Plan_Num from tblDemandPlan";

                    List<BalzooVO> list = Helper.DataReaderMapToList<BalzooVO>(cmd.ExecuteReader());
                    conn.Close();
                    return list;
                }
            }
            catch (Exception err)
            {
                Log.WriteError(err.Message);
                return null;
            }
        }

        public List<BalzooVO> BalzooCompany()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select Com_Code, Com_Name, Com_Num from tblCompany where Com_Type = '발주'";

                    List<BalzooVO> list = Helper.DataReaderMapToList<BalzooVO>(cmd.ExecuteReader());
                    conn.Close();
                    return list;
                }
            }
            catch (Exception err)
            {
                Log.WriteError(err.Message);
                return null;
            }
        }

        public bool BalzooInsert(List<BalzooVO> list, int comNum, int id)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into tblBalzoo (Com_Num, FirstMan, FirstDate)
                                        			   values (@Com_Num, @id, @Date)
                                        select MAX(Bz_Num) from tblBalzoo";
                    cmd.Parameters.AddWithValue("@Com_Num", comNum);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now.Date);

                    int cnt = Convert.ToInt32(cmd.ExecuteScalar());

                    cmd.CommandText = @"insert into tblBalzoo_D (Bz_D_Num, Bz_Num, Mat_Num, Bz_Cnt)
				                                         values (@Bz_D_Num, @Bz_Num, @Mat_Num, @Bz_Cnt)";
                    cmd.Parameters.Add("@Bz_D_Num", System.Data.SqlDbType.NChar);
                    cmd.Parameters.Add("@Bz_Num", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@Mat_Num", System.Data.SqlDbType.NChar);
                    cmd.Parameters.Add("@Bz_Cnt", System.Data.SqlDbType.Int);
                    foreach(BalzooVO vo in list)
                    {
                        cmd.Parameters["@Bz_D_Num"].Value = "A" + DateTime.Now.ToString("yyMMddfff");
                        cmd.Parameters["@Bz_Num"].Value = cnt;
                        cmd.Parameters["@Mat_Num"].Value = vo.Mat_Num;
                        cmd.Parameters["@Bz_Cnt"].Value = vo.Bz_Cnt;

                        cmd.ExecuteNonQuery();
                    }

                    conn.Close();
                    return true;
                }
            }
            catch (Exception err)
            {
                Log.WriteError(err.Message);
                return false;
            }
        }

        public bool BalzooDateUpdate(List<string> list, DateTime date)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update tblBalzoo_D set ExpectedDate = @Date where Bz_D_Num = @Bz_D_Num";
                    cmd.Parameters.AddWithValue("@Date", date);
                    cmd.Parameters.Add("@Bz_D_Num", System.Data.SqlDbType.NChar);

                    foreach (string num in list)
                    {
                        cmd.Parameters["@Bz_D_Num"].Value = num;

                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
                }
            }
            catch (Exception err)
            {
                Log.WriteError(err.Message);
                return false;
            }
        }

        public bool BalzooCancel(List<string> list)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update tblBalzoo_D set Bz_IsCancel = 'Y' where Bz_D_Num = @Bz_D_Num";
                    cmd.Parameters.Add("@Bz_D_Num", System.Data.SqlDbType.NChar);

                    foreach (string num in list)
                    {
                        cmd.Parameters["@Bz_D_Num"].Value = num;

                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    return true;
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
