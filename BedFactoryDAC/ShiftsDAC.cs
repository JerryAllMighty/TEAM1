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
                    cmd.CommandText = @"select Shift_Num, Shift_Name, WP_Num, Start_Time, End_Time, Start_Date
                                               , End_Date, FirstMan, FirstDate, LastMan, LastDate, IsUse
                                               , Row_Number() over(order by Shift_Num) Rownum
                                          from tblShifts";
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
                    cmd.CommandText = @"delete from tblShifts where Shift_Num = @Shift_Num";
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
    }
}
