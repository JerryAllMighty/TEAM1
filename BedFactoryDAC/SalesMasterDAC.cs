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
                    StringBuilder sb = new StringBuilder();

                    cmd.Connection = conn;
                    cmd.CommandText = @"select convert(nvarchar(10), SM.SalesMaster_Num) SalesMaster_Num, convert(nvarchar(10), SM.Order_Num) Order_Num ,
                                                convert(nvarchar(10), O.Com_Num) Com_Num, C.Com_Name, convert(nvarchar(10), M.Mat_Num) Mat_Num,
                                                M.Mat_Name, convert(nvarchar(10), OD.Product_Cnt) Product_Cnt,
                                                convert(nvarchar(10), SM.Deadline, 23) Deadline,
                                                convert(nvarchar(10), SM.UploadDate, 23) UploadDate , convert(nvarchar(10),  SM.Firstman) Firstman,
                                                convert(nvarchar(10), SM.FirstDate, 23) FirstDate, convert(nvarchar(10),  SM.Lastman) Lastman,
                                                convert(nvarchar(10), SM.LastDate, 23) LastDate
                                                from tblSalesMaster SM
                                                inner join tblOrders O
                                                on SM.Order_Num = O.Order_Num
                                                inner join tblOrders_D OD
                                                on O.Order_Num = OD.Order_Num
                                                inner join tblMaterials M
                                                on OD.Mat_Num = M.Mat_Num
                                                inner join tblCompany C
                                                on O.Com_Num = C.Com_Num
										where convert(nvarchar(10), SM.Deadline, 23) = @Deadline
										  and convert(nvarchar(10), SM.UploadDate, 23) = @UploadDate" + sb.ToString();
                    cmd.Parameters.AddWithValue("@Deadline", salesmasterinfo.Deadline);
                    cmd.Parameters.AddWithValue("@UploadDate", salesmasterinfo.UploadDate);
                    cmd.Parameters.AddWithValue("@Order_Num", salesmasterinfo.Order_Num);

                    if (salesmasterinfo.Order_Num.Length > 0)
                        sb.Append(" and convert(nvarchar(10),SM.Order_Num) = @Order_Num");
                    if (salesmasterinfo.Com_Name.Length > 0)
                        sb.Append(" and convert(nvarchar(10), C.Com_Name) = @Com_Name");
                    if (salesmasterinfo.Mat_Name.Length > 0)
                        sb.Append(" and convert(nvarchar(10),M.Mat_Name) = @Mat_Name");

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

        public List<SalesMasterVO> GetSalesMasterBySalesMasterNum(string salesmasternum)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    StringBuilder sb = new StringBuilder();

                    cmd.Connection = conn;
                    cmd.CommandText = @"";

                   

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
                    cmd.CommandText = @"insert into tblSalesMaster (Order_Num, TotalCnt, Deadline, UploadDate, Firstman, Lastman)
                                                   values(Convert(int, @Order_Num), Convert(int, (select sum(Product_Cnt) from tblOrders_D where Order_Num = @Order_Num)),
		                                        Convert(nvarchar(10), @Deadline), Convert(nvarchar(10), @UploadDate), Convert(int, @Firstman), Convert(int, @Lastman))";
                    cmd.Parameters.AddWithValue("@Order_Num", salesmasterinfo.Order_Num);
                    cmd.Parameters.AddWithValue("@Deadline", salesmasterinfo.Deadline);
                    cmd.Parameters.AddWithValue("@UploadDate", salesmasterinfo.UploadDate);
                    cmd.Parameters.AddWithValue("@Firstman", salesmasterinfo.Firstman);
                    cmd.Parameters.AddWithValue("@Lastman", salesmasterinfo.Lastman);

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
