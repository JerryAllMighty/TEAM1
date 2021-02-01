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

        public List<BalzooVO> BalzooSelect(DateTime fromDate, DateTime toDate)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select BD.Bz_Num, Bz_D_Num, Com_Name, M.Mat_Name, Bz_Cnt, Bz_D_Status, ExpectedDate
                                          from tblBalzoo_D BD join tblBalzoo B on BD.Bz_Num = B.Bz_Num join tblMaterials M on BD.Mat_Num = M.Mat_Num
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
                    cmd.CommandText = @"select BD.Bz_Num, Bz_D_Num, Com_Name, M.Mat_Name, Bz_Cnt, Bz_D_Status, ExpectedDate
                                          from tblBalzoo_D BD join tblBalzoo B on BD.Bz_Num = B.Bz_Num join tblMaterials M on BD.Mat_Num = M.Mat_Num
                                         where Bz_IsCancel = 'N' and ExpectedDate >= @fromDate and ExpectedDate <= @toDate and Bz_D_Status = 'N'";
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

        public bool StateIsWait(string num)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update tblBalzoo_D set Bz_D_Status = 'W' where Bz_D_Num = @Bz_D_Num";
                    cmd.Parameters.AddWithValue("@Bz_D_Num", num);

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
