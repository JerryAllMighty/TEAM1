using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryDAC
{
    public class ProductionPlanDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;

        public ProductionPlanDAC()
        {
            strConn = this.ConnectionString;
            conn = new SqlConnection(strConn);
            conn.Open();
        }
        public int GetPlanNum()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select max(ProductionPlan_Num) from tblProductionPlan";

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception err)
            {
                Log.WriteError(err.Message);
                return 0;
            }
        }
        //public List<BOMVO> GetBOMInfo(DemandVO demandinfo)
        //{
        //    try
        //    {
        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            cmd.Connection = conn;
        //            cmd.CommandText = @"select Convert(nchar(10), B.Mat_Num) Mat_Num , 
        //                                     Convert(nchar(10), B.Use_Mat_Num) Use_Mat_Num,
        //                                    (B.Cnt * OD.Product_Cnt) Cnt,
        //                                    Convert(nchar(10), WP.WP_Num) WP_Num
        //                                    from tblBOM B
        //                                    inner join tblOrders_D OD
        //                                    on OD.Mat_Num =  B.Mat_Num
        //                                    inner join tblOrders O
        //                                    on O.Order_Num = OD.Order_Num
        //                                    inner join tblWorkplace WP
        //                                    on WP.Mat_Num = B.Use_Mat_Num
        //                                    where B.Mat_Num = (
        //                                    select Mat_Num from tblOrders O
        //                                    inner join tblOrders_D OD
        //                                    on O.Order_Num= OD.Order_Num
        //                                    where O.Order_Num = @Order_Num
        //                                    )";

        //            cmd.Parameters.AddWithValue("@Order_Num", demandinfo.Order_Num);


        //            List<BOMVO> list = Helper.DataReaderMapToList<BOMVO>(cmd.ExecuteReader());
        //            return list != null ? list : null;
        //        }
        //    }
        //    catch (Exception err)
        //    {
        //        Log.WriteError(err.Message);
        //        return null;
        //    }
        //}

        /// <summary>
        /// 마스터 생산계획을 생성하는 함수
        /// </summary>
        /// <returns></returns>
        public bool InsertMasterProductionPlan(DemandVO demandinfo, string demandnum)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into tblProductionPlan(Demand_Plan_Num, Firstman, LastMan)
                                        values (@Demand_Plan_Num, @Firstman, @LastMan)";
                    cmd.Parameters.AddWithValue("@Demand_Plan_Num", demandnum);
                    cmd.Parameters.AddWithValue("@Firstman", demandinfo.FirstMan);
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


        /// <summary>
        /// 디테일 생산계획을 생성하는 함수
        /// </summary>
        /// <returns></returns>
        public bool InsertDetailProductionPlan(DemandVO demandinfo, int cnt, string WP_Num, string Mat_Num,int ProductionPlanNum, int adddays)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into tblProductionPlan_D(ProductionPlan_Num, ProductionDate, ProductionCnt,WP_Num, Mat_Num)
                        values(@ProductionPlan_Num, @ProductionDate, @ProductionCnt,@WP_Num, @Mat_Num)";

                    cmd.Parameters.Add("@ProductionPlan_Num", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@ProductionDate", System.Data.SqlDbType.DateTime);
                    cmd.Parameters.Add("@ProductionCnt", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@WP_Num", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@Mat_Num", System.Data.SqlDbType.NChar);

                    cmd.Parameters["@ProductionPlan_Num"].Value = ProductionPlanNum + 1;
                    cmd.Parameters["@ProductionDate"].Value = Convert.ToDateTime(demandinfo.UploadDate).AddDays(adddays);
                    cmd.Parameters["@ProductionCnt"].Value = cnt;
                    cmd.Parameters["@WP_Num"].Value = WP_Num;
                    cmd.Parameters["@Mat_Num"].Value = Mat_Num;

                    int iRowAffect = cmd.ExecuteNonQuery();

                    if (iRowAffect < 1)
                    {
                        return false;
                    }


                    return true;
                }
            }
            catch (Exception err)
            {
                Log.WriteError(err.Message);
                return false;
            }
        }
        public List<ProductionPlanVO> GetProductionPlanInfo(ProductionPlanVO productionplaninfo, string date)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    StringBuilder sb = new StringBuilder();
                    cmd.Connection = conn;
                    cmd.CommandText = @"select Convert(nchar(10), D.Demand_Plan_Num)Demand_Plan_Num, Convert(nchar(10), P.ProductionPlan_Num) ProductionPlan_Num,
										Convert(nchar(10), PD.ProductionPlan_D_Num) ProductionPlan_D_Num , Convert(nchar(10), PD.ProductionDate,23) ProductionDate,
										Convert(nchar(10), PD.ProductionCnt) ProductionCnt,Convert(nchar(10), PD.WP_Num) WP_Num, PD.Mat_Num
										from tblDemandPlan D
										inner join tblProductionPlan P
										on D.Demand_Plan_Num = P.Demand_Plan_Num
										inner join tblProductionPlan_D PD
										on P.ProductionPlan_Num = PD.ProductionPlan_Num
										inner join tblSalesMaster S
										on S.SalesMaster_Num = D.SalesMaster_Num
										where S.Deadline = @Deadline" + sb.ToString();

                    cmd.Parameters.AddWithValue("@Deadline", date);



                    if (productionplaninfo.Demand_Plan_Num.Length > 0)
                    {
                        sb.Append(" and D.Demand_Plan_Num = @Demand_Plan_Num");
                        cmd.Parameters.Add("@Demand_Plan_Num", System.Data.SqlDbType.Int);
                        cmd.Parameters["@Demand_Plan_Num"].Value = productionplaninfo.Demand_Plan_Num;
                    }
                    if (productionplaninfo.WP_Num.Length > 0)
                    {
                        sb.Append(" and D.WP_Num = @WP_Num");
                        cmd.Parameters.Add("@WP_Num", System.Data.SqlDbType.Int);
                        cmd.Parameters["@WP_Num"].Value = productionplaninfo.WP_Num;
                    }


                    List<ProductionPlanVO> list = Helper.DataReaderMapToList<ProductionPlanVO>(cmd.ExecuteReader());
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
        /// 생산계획과 생산 상세 계획을 모두 가져오는 함수
        /// </summary>
        /// <param name="productionplaninfo"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public List<ProductionPlanVO> GetProductionPlanDetail(string productiondate, string productionplannum)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    StringBuilder sb = new StringBuilder();
                    cmd.Connection = conn;
                    cmd.CommandText = @"select Convert(nchar(10), P.ProductionPlan_Num) ProductionPlan_Num, 
                                            Convert(nchar(10), PD.ProductionPlan_D_Num) ProductionPlan_D_Num, 
                                            Convert(nchar(10), PD.ProductionDate,23)ProductionDate,
                                            Convert(nchar(10), PD.WP_Num) WP_Num, PD.Mat_Num, M.Mat_Name, Convert(nchar(10), PD.ProductionCnt) ProductionCnt,
                                            WP.WP_Name
                                            from tblProductionPlan P
                                            inner join tblProductionPlan_D PD
                                            on P.ProductionPlan_Num = PD.ProductionPlan_Num
                                            inner join tblMaterials M
                                            on M.Mat_Num = PD.Mat_Num
                                            inner join tblWorkplace WP
                                            on WP.WP_Num = PD.WP_Num
                                            where PD.ProductionDate = @ProductionDate" + sb.ToString();
                                            
                    cmd.Parameters.AddWithValue("@ProductionDate", productiondate);

                    if (productionplannum.Length > 0)
                    {
                        sb.Append(" and P.ProductionPlan_Num = @ProductionPlan_Num");
                        cmd.Parameters.AddWithValue("@ProductionPlan_Num", productionplannum);
                    }
                    

                    List<ProductionPlanVO> list = Helper.DataReaderMapToList<ProductionPlanVO>(cmd.ExecuteReader());
                    return list != null ? list : null;
                }
            }
            catch (Exception err)
            {
                Log.WriteError(err.Message);
                return null;
            }
        }
        public void Dispose()
        {
            conn.Close();
        }
    }
}
