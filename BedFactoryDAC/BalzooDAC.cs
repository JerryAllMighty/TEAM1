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
    }
}
