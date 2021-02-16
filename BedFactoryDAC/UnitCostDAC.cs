using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryDAC
{
    public class UnitCostDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;

        public UnitCostDAC()
        {
            strConn = this.ConnectionString;
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        public List<UnitCostVO> UnitCostSelect(string category, DateTime date)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select Convert(int, Row_Number() over(order by U.Com_Num, U.Mat_Num, Start_Date)) Rownum, UnitCost_Num
                                               , U.Com_Num, C.Com_Name, U.Mat_Num, M.Mat_Name, Now_UnitCost, Before_UnitCost
                                               , Start_Date, End_Date, U.FirstMan, U.FirstDate, U.LastMan, U.LastDate
                                          from tblUnitCost U join tblCompany C on U.Com_Num = C.Com_Num 
	                                           join tblMaterials M on U.Mat_Num = M.Mat_Num
                                         where C.Com_Type = @Com_Category and Start_Date <= @Date and End_Date >= @Date";

                    cmd.Parameters.AddWithValue("@Com_Category", category);
                    cmd.Parameters.AddWithValue("@Date", date.Date);
                    List<UnitCostVO> list = Helper.DataReaderMapToList<UnitCostVO>(cmd.ExecuteReader());
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

        public int UnitCostInsert(UnitCostVO vo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = @"SP_UnitCostInsert";

                    cmd.Parameters.Add("@Amount", System.Data.SqlDbType.Int);
                    cmd.Parameters["@Amount"].Direction = System.Data.ParameterDirection.Output;

                    cmd.Parameters.AddWithValue("@Com_Num", vo.Com_Num);
                    cmd.Parameters.AddWithValue("@Mat_Num", vo.Mat_Num);
                    cmd.Parameters.AddWithValue("@Now_UnitCost", vo.Now_UnitCost);
                    cmd.Parameters.AddWithValue("@Before_UnitCost", vo.Before_UnitCost);
                    cmd.Parameters.AddWithValue("@Start_Date", vo.Start_Date);
                    cmd.Parameters.AddWithValue("@End_Date", vo.End_Date);
                    cmd.Parameters.AddWithValue("@FirstMan", vo.FirstMan);
                    cmd.Parameters.AddWithValue("@FirstDate", vo.FirstDate);

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    return Convert.ToInt32(cmd.Parameters["@Amount"].Value);
                }
            }
            catch (Exception err)
            {
                Log.WriteError(err.Message);
                return 2;
            }
        }

        public int UnitCostUpdate(UnitCostVO vo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = @"SP_UnitCostUpdate";

                    cmd.Parameters.Add("@Amount", System.Data.SqlDbType.Int);
                    cmd.Parameters["@Amount"].Direction = System.Data.ParameterDirection.Output;

                    cmd.Parameters.AddWithValue("@UnitCost_Num", vo.Com_Num);
                    cmd.Parameters.AddWithValue("@Com_Num", vo.Com_Num);
                    cmd.Parameters.AddWithValue("@Mat_Num", vo.Mat_Num);
                    cmd.Parameters.AddWithValue("@Now_UnitCost", vo.Now_UnitCost);
                    cmd.Parameters.AddWithValue("@Before_UnitCost", vo.Before_UnitCost);
                    cmd.Parameters.AddWithValue("@Start_Date", vo.Start_Date);
                    cmd.Parameters.AddWithValue("@End_Date", vo.End_Date);
                    cmd.Parameters.AddWithValue("@LastMan", vo.LastMan);
                    cmd.Parameters.AddWithValue("@LastDate", vo.LastDate);

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    return Convert.ToInt32(cmd.Parameters["@Amount"].Value);
                }
            }
            catch (Exception err)
            {
                Log.WriteError(err.Message);
                return 2;
            }
        }

        public List<CommonCodeVO> UnitCostCombo(string category)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select cast(Com_Num as VARCHAR) Code_Num, Com_Name Code_Name, '거래처' Category from tblCompany where Com_Type = @Category
                                        union
                                        select Mat_Num Code_Num, Mat_Name Code_Name, '자재' Category from tblMaterials";

                    cmd.Parameters.AddWithValue("@Category", category);
                    List<CommonCodeVO> list = Helper.DataReaderMapToList<CommonCodeVO>(cmd.ExecuteReader());
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

        public bool UnitCostDelete(int num)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"delete from tblUnitCost where UnitCost_Num = @UnitCost_Num";

                    cmd.Parameters.Add("@UnitCost_Num", System.Data.SqlDbType.NChar);
                    cmd.Parameters["@UnitCost_Num"].Value = num;

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
    }
}
