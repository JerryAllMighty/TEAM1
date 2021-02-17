using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryDAC
{
    public class ShiftsDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;

        public ShiftsDAC()
        {
            strConn = this.ConnectionString;
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        public List<ShiftVO> ShiftsSelect()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select Shift_Num, Shift_Name, S.WP_Num, WP.WP_Name, Start_Time, End_Time, Start_Date
                                               , End_Date, IsUse, S.LastMan, S.LastDate
                                               , Convert(int, Row_Number() over(order by Shift_Num)) Rownum
                                               , PeopleCnt
                                          from tblShifts S join tblWorkplace WP on S.WP_Num = WP.WP_Num";
                    List<ShiftVO> list = Helper.DataReaderMapToList<ShiftVO>(cmd.ExecuteReader());
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

        public int ShiftInsert(ShiftVO shift)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = @"SP_ShiftCheckInsert";

                    cmd.Parameters.Add("@Amount", System.Data.SqlDbType.Int);
                    cmd.Parameters["@Amount"].Direction = System.Data.ParameterDirection.Output;

                    cmd.Parameters.AddWithValue("@Shift_Name", shift.Shift_Name);
                    cmd.Parameters.AddWithValue("@WP_Num", shift.WP_Num);
                    cmd.Parameters.AddWithValue("@Start_Time", shift.Start_Time);
                    cmd.Parameters.AddWithValue("@End_Time", shift.End_Time);
                    cmd.Parameters.AddWithValue("@Start_Date", shift.Start_Date);
                    cmd.Parameters.AddWithValue("@End_Date", shift.End_Date);
                    cmd.Parameters.AddWithValue("@FirstMan", shift.FirstMan);
                    cmd.Parameters.AddWithValue("@FirstDate", shift.FirstDate);
                    cmd.Parameters.AddWithValue("@IsUse", shift.IsUse);
                    cmd.Parameters.AddWithValue("@PeopleCnt", shift.PeopleCnt);

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

        public int ShiftUpdate(ShiftVO shift)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = @"SP_ShiftCheckUpdate";

                    cmd.Parameters.Add("@Amount", System.Data.SqlDbType.Int);
                    cmd.Parameters["@Amount"].Direction = System.Data.ParameterDirection.Output;

                    cmd.Parameters.AddWithValue("@Shift_Name", shift.Shift_Name);
                    cmd.Parameters.AddWithValue("@WP_Num", shift.WP_Num);
                    cmd.Parameters.AddWithValue("@Start_Time", shift.Start_Time);
                    cmd.Parameters.AddWithValue("@End_Time", shift.End_Time);
                    cmd.Parameters.AddWithValue("@Start_Date", shift.Start_Date);
                    cmd.Parameters.AddWithValue("@End_Date", shift.End_Date);
                    cmd.Parameters.AddWithValue("@LastMan", shift.LastMan);
                    cmd.Parameters.AddWithValue("@LastDate", shift.LastDate);
                    cmd.Parameters.AddWithValue("@IsUse", shift.IsUse);
                    cmd.Parameters.AddWithValue("@Shift_Num", shift.Shift_Num);
                    cmd.Parameters.AddWithValue("@PeopleCnt", shift.PeopleCnt);

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

        public bool ShiftDelete(int num)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"delete from tblShifts_D where Shift_Num = @Shift_Num
                                        delete from tblShifts where Shift_Num = @Shift_Num";
                    cmd.Parameters.AddWithValue("@Shift_Num", num);
                    int cnt = cmd.ExecuteNonQuery();
                    conn.Close();
                    return cnt > 0;
                }
            }
            catch (Exception err)
            {
                Log.WriteError(err.Message);
                return false;
            }
        }

        public List<ShiftVO> ShiftChangeSelect()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select S.Shift_Num, WP_Name, S.Shift_Name, Change_Date, S.Start_Time Before_Start_Time
                                               , S.End_Time After_End_Time, S.PeopleCnt Before_PeopleCnt, Start_Date, End_Date
                                               , isnull(SD.Start_Time, s.Start_Time) Start_Time
	                                           , isnull(SD.End_Time, S.End_Time) End_Time, isnull(SD.PeopleCnt, S.PeopleCnt) PeopleCnt
                                          from tblShifts S left outer join tblShifts_D SD on S.Shift_Num = SD.Shift_Num
											   join tblWorkplace WP on S.WP_Num = WP.WP_Num";
                    List<ShiftVO> list = Helper.DataReaderMapToList<ShiftVO>(cmd.ExecuteReader());
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

        public bool ShiftChangeIandU(ShiftVO shift)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = @"SP_ShiftDateChange";

                    cmd.Parameters.AddWithValue("@Shift_Num", shift.Shift_Num);
                    cmd.Parameters.AddWithValue("@Start_Time", shift.Start_Time);
                    cmd.Parameters.AddWithValue("@End_Time", shift.End_Time);
                    cmd.Parameters.AddWithValue("@Change_Date", shift.Change_Date);
                    cmd.Parameters.AddWithValue("@PeopleCnt", shift.PeopleCnt);

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
