using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryDAC
{
    public class WearingDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;

        public WearingDAC()
        {
            strConn = this.ConnectionString;
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }
        
        public List<WearingVO> WarehousingState(DateTime fromDate, DateTime toDate)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select Wearing_Num, W.Str_Num, S.Str_Kind, W.Mat_Num, M.Mat_Name, Mat_Cnt, W.FirstMan, W.FirstDate 
                                          from tblWearing W join tblStorages S on W.Str_Num = S.Str_Num join tblMaterials M on W.Mat_Num = M.Mat_Num
                                         where W.FirstDate >= @fromDate and W.FirstDate <= @toDate";
                    cmd.Parameters.AddWithValue("@fromDate", fromDate.Date);
                    cmd.Parameters.AddWithValue("@toDate", toDate.Date);

                    List<WearingVO> list = Helper.DataReaderMapToList<WearingVO>(cmd.ExecuteReader());
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

        public int WarehousingCancel(int wearingNum, int cancelCnt)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = @"SP_WearingCancel";

                    cmd.Parameters.Add("@Amount", System.Data.SqlDbType.Int);
                    cmd.Parameters["@Amount"].Direction = System.Data.ParameterDirection.Output;

                    cmd.Parameters.AddWithValue("@Wearing_Num", wearingNum);
                    cmd.Parameters.AddWithValue("@Cancel_Cnt", cancelCnt);

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    return Convert.ToInt32(cmd.Parameters["@Amount"].Value); //1이면 삭제, 2이면 수정
                }
            }
            catch (Exception err)
            {
                Log.WriteError(err.Message);
                return 3;
            }
        }
    }
}
