using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryDAC
{
    public class MRPDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;

        public MRPDAC()
        {
            strConn = this.ConnectionString;
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public List<BOMVO> GetBOMInfo(DemandVO demandinfo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select B.Mat_Num , B.Use_Mat_Num,  
                                        (B.Cnt * OD.Product_Cnt) Cnt, Convert(nchar(10), WP.WP_Num) WP_Num, 
                                        (select Use_Mat_Num from tblBOM where Mat_Num = B.Use_Mat_Num) Use_Resource_Num,
                                        Convert(nchar(10), (B.Cnt * OD.Product_Cnt * (select Cnt from tblBOM where Mat_Num = B.Use_Mat_Num))) Resource_Cnt, 
                                        Convert(nchar(10), (select sum(Mat_Cnt)  Mat_Cnt from tblWearing where Mat_Num = 
                                        (select Use_Mat_Num from tblBOM where Mat_Num = B.Use_Mat_Num) and W_Category = '구매입고')) CurrentResourceStock  
                                        from tblBOM B
                                        inner join tblOrders_D OD
                                        on OD.Mat_Num =  B.Mat_Num
                                        inner join tblOrders O
                                        on O.Order_Num = OD.Order_Num
                                        inner join tblWorkplace WP
                                        on WP.Mat_Num = B.Use_Mat_Num
                                        where B.Mat_Num = (
                                        select OD.Mat_Num from tblOrders O
                                        inner join tblOrders_D OD
                                        on O.Order_Num= OD.Order_Num
                                        where O.Order_Num = @Order_Num)";

                    cmd.Parameters.AddWithValue("@Order_Num", demandinfo.Order_Num);


                    List<BOMVO> list = Helper.DataReaderMapToList<BOMVO>(cmd.ExecuteReader());
                    return list != null ? list : null;
                }
            }
            catch (Exception err)
            {
                Log.WriteError(err.Message);
                return null;
            }
        }

        public bool InsertMaterialUsePlan(string demandnum, string Use_Resource_Num, int Resource_Cnt)
        {
            try {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    
                    cmd.CommandText = @"insert into tblMaterialUsePlan(Demand_Plan_Num, Mat_Num, MaterialUse_Cnt, Firstman, Lastman)
                                            values(@Demand_Plan_Num, @Mat_Num, @MaterialUse_Cnt, @Firstman, @Lastman)";
                    cmd.Parameters.AddWithValue("@Demand_Plan_Num", demandnum);
                    cmd.Parameters.AddWithValue("@Mat_Num", Use_Resource_Num);
                    cmd.Parameters.AddWithValue("@MaterialUse_Cnt", Resource_Cnt);
                    cmd.Parameters.AddWithValue("@Firstman", 1);
                    cmd.Parameters.AddWithValue("@Lastman", 1);

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
            conn.Open();
        }
    }
}
