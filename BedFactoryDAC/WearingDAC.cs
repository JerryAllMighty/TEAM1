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

        /// <summary>
        /// 자재재고현황
        /// </summary>
        /// <returns></returns>
        public List<WearingVO> StockState()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select  W.Str_Num, S.Str_Kind, W.Mat_Num, M.Mat_Name, M.Mat_Category
		                                        , (W.Mat_Cnt - isnull(SD.Ship_Cnt, 0)) Mat_Cnt
                                        from(
                                        select Str_Num, Mat_Num, Sum(Mat_Cnt) Mat_Cnt 
                                        from tblWearing group by Str_Num, Mat_Num
                                        ) W left outer join tblStorages S on W.Str_Num = S.Str_Num
                                        join tblMaterials M on W.Mat_Num = M.Mat_Num
                                        join (select Str_Num, Mat_Num, sum(Ship_Cnt) Ship_Cnt 
                                        				   from tblShipment_D group by Str_Num, Mat_Num) SD 
                                        				 on SD.Str_Num = W.Str_Num and SD.Mat_Num = W.Mat_Num
                                        order by W.Str_Num";

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

        /// <summary>
        /// 이력조회
        /// </summary>
        /// <param name="sNum"></param>
        /// <param name="mNum"></param>
        /// <returns></returns>
        public List<WearingVO> StockStateSearch(int sNum, int mNum)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select W.Str_Num, S.Str_Kind, W.Mat_Num, M.Mat_Name, M.Mat_Category, Mat_Cnt, W.FirstDate, W_Category 
                                          from tblWearing W join tblStorages S on W.Str_Num = S.Str_Num
                                          				  join tblMaterials M on W.Mat_Num = M.Mat_Num
                                         where W.Str_Num = @Str_Num and W.Mat_Num = @Mat_Num";

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

        /// <summary>
        /// 입출고현황
        /// </summary>
        /// <param name="sNum"></param>
        /// <param name="mNum"></param>
        /// <returns></returns>
        public List<WearingVO> WOState(DateTime fromDate, DateTime toDate)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select FirstDate, Category, W_Category, Str_Num, Str_Kind, Mat_Name, Mat_Category, Mat_Cnt
                                        from
                                        (select W.FirstDate, '입고' Category, W_Category, W.Str_Num, S.Str_Kind, M.Mat_Name, M.Mat_Category, Mat_Cnt 
                                        from tblWearing W join tblStorages S on W.Str_Num = S.Str_Num
                                        	 join tblMaterials M on W.Mat_Num = M.Mat_Num
                                        union
                                        select S.Lastdate FirstDate, '출고' Category, S.Ship_Detail W_Category, SD.Str_Num
                                               , ST.Str_Kind, M.Mat_Name, M.Mat_Category, Ship_Cnt Mat_Cnt
                                        from tblShipment_D SD join tblShipment S on SD.Ship_Num = S.Ship_Num
                                        	 join tblStorages ST on SD.Str_Num = ST.Str_Num
                                        	 join tblMaterials M on SD.Mat_Num = M.Mat_Num) A
                                        where FirstDate >= @fromDate and FirstDate <= @toDate
                                        order by FirstDate";

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
    }
}
