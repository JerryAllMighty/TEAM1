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
                    cmd.CommandText = @"select Ship_D_Num, WO_D_Num, S.Firstdate, M.Mat_Name, M.Mat_Category, SD.Str_Num, Ship_Cnt
                                        from tblShipment_D SD join tblShipment S on SD.Ship_Num = S.Ship_Num
                                        join tblMaterials M on SD.Mat_Num = M.Mat_Num
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
    }
}
