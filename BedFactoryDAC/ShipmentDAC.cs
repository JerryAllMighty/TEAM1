using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryDAC
{
    public class ShipmentDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;

        public ShipmentDAC()
        {
            strConn = this.ConnectionString;
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        /// <summary>
        /// 작업지시의 자재의 하위 BOM의 자재를 자동 출고요청서 발행 및 출고대기 항목 출력
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <returns></returns>
        public List<ShipmentVO> AutoShipLoad(DateTime fromDate, DateTime toDate)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = @"SP_AutoShip";

                    cmd.ExecuteNonQuery();

                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = @"select Ship_D_Num, WO_Num, S.Firstdate, M.Mat_Name, M.Mat_Category, SS.Str_Kind, Ship_Cnt
                                        from tblShipment_D SD join tblShipment S on SD.Ship_Num = S.Ship_Num
                                        join tblMaterials M on SD.Mat_Num = M.Mat_Num
                                        join tblStorages SS on SS.Str_Num = SD.Str_Num
                                        where Ship_Status = '출고대기'
                                              and S.FirstDate >= @fromDate and S.FirstDate <= @toDate";
                    cmd.Parameters.AddWithValue("@fromDate", fromDate.Date);
                    cmd.Parameters.AddWithValue("@toDate", toDate.Date);

                    List<ShipmentVO> list = Helper.DataReaderMapToList<ShipmentVO>(cmd.ExecuteReader());
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
        /// 완제품 출하
        /// </summary>
        /// <param name="order_Num">주문번호</param>
        public bool Shipmentcomplete(int order_Num)
        {
            SqlTransaction trans = conn.BeginTransaction();

            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.Transaction = trans;
                    cmd.CommandText = @"update tblOrders set Order_Status = '출하완료'
                                        where Order_Num = @Order_Num";
                    cmd.Parameters.AddWithValue("@Order_Num", order_Num);
                    cmd.ExecuteNonQuery();

                    trans.Commit();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception err)
            {
                Log.WriteError(err.Message);
                trans.Rollback();
                return false;
            }
        }

        /// <summary>
        /// 자재불출에서 작업지시가져오기
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <returns></returns>
        public List<ShipmentVO> WorkOrdersLoad(DateTime fromDate, DateTime toDate)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select PPD.ProductionDate, WO_Num, WP_Name, P.Process_Name_D, Mat_Name, WO_Order_Cnt, WO_Status
                                        from tblWorkOrders WO join tblProductionPlan_D PPD on WO.ProductionPlan_D_Num = PPD.ProductionPlan_D_Num
                                        	 join tblWorkplace WP on WO.WP_Num = WP.WP_Num join tblProcess P on P.Process_Num = WO.Process_Num
                                        	 join tblMaterials M on WO.Mat_Num = M.Mat_Num
                                        where WO_Status = '작업예정' and ProductionDate >= @fromDate and ProductionDate <= @toDate";
                    cmd.Parameters.AddWithValue("@fromDate", fromDate.Date);
                    cmd.Parameters.AddWithValue("@toDate", toDate.Date);

                    List<ShipmentVO> list = Helper.DataReaderMapToList<ShipmentVO>(cmd.ExecuteReader());
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
        /// 작업지시 자재의 하위 BOM가져오기
        /// </summary>
        /// <param name="woNum"></param>
        /// <returns></returns>
        public List<ShipmentVO> WorkOrdersByShip(int woNum)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select M.Mat_Num, M.Mat_Name, M.Mat_Category, S.Str_Kind, (WO.WO_Order_Cnt*Cnt) WO_Order_Cnt, isnull(SD.Ship_Cnt, 0) Ship_Cnt
                                        from tblWorkOrders WO join tblBOM B on WO.Mat_Num = B.Mat_Num 
                                        	 join tblMaterials M on B.Use_Mat_Num = M.Mat_Num
                                        	 join tblStorages S on S.Str_Kind = M.Mat_Category
                                        	 left outer join tblShipment_D SD on WO.WO_Num = SD.WO_Num
                                        where WO.WO_Num = @WO_Num";
                    cmd.Parameters.AddWithValue("@WO_Num", woNum);

                    List<ShipmentVO> list = Helper.DataReaderMapToList<ShipmentVO>(cmd.ExecuteReader());
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
        /// 자재불출요청에서 필요한 자재 수동으로 불출
        /// </summary>
        /// <param name="vo"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool InsertShipment(ShipmentVO vo, int id)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into tblShipment (Ship_Detail, Firstman, Lastman)
                                        			values ('자재차감', @id, @id)
                                        insert into tblShipment_D (Ship_Num, Str_Num, Mat_Num, Ship_Cnt, Ship_Status, WO_Num)
                                        			values ((select MAX(Ship_Num) from tblShipment), 
                                        			(select Str_Num from tblStorages where Str_Kind = @Mat_Category), @Mat_Num, @Ship_Cnt, 'Y', @WO_Num)";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@Mat_Category", vo.Mat_Category);
                    cmd.Parameters.AddWithValue("@Mat_Num", vo.Mat_Num);
                    cmd.Parameters.AddWithValue("@Ship_Cnt", vo.Ship_Cnt);
                    cmd.Parameters.AddWithValue("@WO_Num", vo.WO_Num);

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

        public bool ShipmentFinish(string num)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update tblShipment_D set Ship_Status = '출고완료' where Ship_D_Num = @Ship_D_Num";
                    cmd.Parameters.AddWithValue("@Ship_D_Num", num);

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

        public bool InsertShipment()
        {
            SqlTransaction trans = conn.BeginTransaction();

            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.Transaction = trans;
                    cmd.CommandText = @"insert into tbl";
                    cmd.Parameters.AddWithValue("@Ship_D_Num", "");

                    int cnt = cmd.ExecuteNonQuery();
                    conn.Close();

                    trans.Commit();
                    return cnt > 0;
                }
            }
            catch (Exception err)
            {
                Log.WriteError(err.Message);
                trans.Rollback();
                return false;
            }
        }
    }
}
