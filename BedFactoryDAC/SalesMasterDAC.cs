using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryDAC
{
    public class SalesMasterDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;

        public SalesMasterDAC()
        {
            strConn = this.ConnectionString;
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        /// <summary>
        /// 영업마스터를 검색해오는 함수
        /// </summary>
        /// <param name="salesmasterinfo"></param>
        /// <returns></returns>
        public List<SalesMasterVO> GetSalesMaster(SalesMasterVO salesmasterinfo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select Order_Num, Com_Num, Mat_Name, TotalCnt, Ship_Cnt, Deadline, UploadDate, 
                                                Firstman, FirstDate, Lastman, LastDate
                                        from tblSalesMaster
										where convert(char(10), Deadline, 23) = @Deadline
											and convert(char(10), UploadDate, 23) = @UploadDate";
                    cmd.Parameters.AddWithValue("@Deadline", salesmasterinfo.Deadline);
                    cmd.Parameters.AddWithValue("@UploadDate", salesmasterinfo.UploadDate);

                    List<SalesMasterVO> list = Helper.DataReaderMapToList<SalesMasterVO>(cmd.ExecuteReader());

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
        /// 영업 마스터 생성하는 함수
        /// </summary>
        /// <param name="salesmasterinfo"></param>
        /// <returns></returns>
        public bool InsertSalesMaster(SalesMasterVO salesmasterinfo)
        {
            try {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"";
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
        public void Dispose()
        {
            conn.Close();
        }
    }
}
