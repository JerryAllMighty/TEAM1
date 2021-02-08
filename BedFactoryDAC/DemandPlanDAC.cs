using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryDAC
{
    public class DemandPlanDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;

        public DemandPlanDAC()
        {
            strConn = this.ConnectionString;
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        /// <summary>
        /// 검색 조건에 따라서 수요 계획을 검색해오는 함수
        /// </summary>
        /// <param name="demandinfo"></param>
        /// <returns></returns>
        public List<DemandVO> GetDemandPlan(DemandVO demandinfo)
        {
            try {
                using (SqlCommand cmd = new SqlCommand())
                {
                    StringBuilder sb = new StringBuilder();
                    cmd.Connection = conn;
                    cmd.CommandText = @"select Convert(nvarchar(10), D.Demand_Plan_Num) Demand_Plan_Num, Convert(nvarchar(10), O.Order_Num) Order_Num ,
                                             Convert(nvarchar(10), SM.SalesMaster_Num) SalesMaster_Num, C.Com_Name, M.Mat_Name,
                                             Convert(nvarchar(10),D.FirstMan) FirstMan, Convert(nvarchar(10), D.FirstDate, 23) FirstDate,
                                             Convert(nvarchar(10),D.LastMan) LastMan, Convert(nvarchar(10), D.LastDate, 23) LastDate
                                        from tblDemandPlan D
                                            inner join tblSalesMaster SM
                                            on D.SalesMaster_Num = SM.SalesMaster_Num
                                            inner join tblOrders O
                                            on SM.Order_Num = O.Order_Num
                                            inner join tblCompany C
                                            on O.Com_Num = C.Com_Num
                                            inner join tblOrders_D OD
                                            on O.Order_Num = OD.Order_Num
                                            inner join tblMaterials M
                                            on OD.Mat_Num = M.Mat_Num
                                            where Convert(nvarchar(10), D.LastDate, 23) = @LastDate" + sb.ToString();
                    cmd.Parameters.AddWithValue("@LastDate", demandinfo.LastDate);
                    cmd.Parameters.AddWithValue("@Demand_Plan_Num", demandinfo.Demand_Plan_Num);
                    cmd.Parameters.AddWithValue("@Com_Name", demandinfo.Com_Name);
                    cmd.Parameters.AddWithValue("@Mat_Name", demandinfo.Mat_Name);

                    if (demandinfo.Demand_Plan_Num.Length > 0)
                        sb.Append(" and D.Demand_Plan_Num = @Demand_Plan_Num");
                    if (demandinfo.Com_Name.Length > 0)
                        sb.Append(" and C.Com_Name = @Com_Name");
                    if (demandinfo.Mat_Name.Length > 0)
                        sb.Append(" and M.Mat_Name = @Mat_Name");


                    List<DemandVO> list = Helper.DataReaderMapToList<DemandVO>(cmd.ExecuteReader());

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
        /// 영업마스터로부터 수요 계획을 생성할 때 호출
        /// </summary>
        /// <param name="demandinfo"></param>
        /// <returns></returns>
        public bool InsertDemandPlan(DemandVO demandinfo)
        {
            try {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into tblDemandPlan(Order_Num, SalesMaster_Num, FirstMan, LastMan)
	                                            values (@Order_Num, @SalesMaster_Num, @FirstMan,  @LastMan)";
                    cmd.Parameters.AddWithValue("@Order_Num", demandinfo.Order_Num);
                    cmd.Parameters.AddWithValue("@SalesMaster_Num", demandinfo.SalesMaster_Num);
                    cmd.Parameters.AddWithValue("@FirstMan", demandinfo.FirstMan);
                    cmd.Parameters.AddWithValue("@LastMan", demandinfo.LastMan);

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
