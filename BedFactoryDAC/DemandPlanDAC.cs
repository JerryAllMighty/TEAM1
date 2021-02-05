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
        }


        public bool InsertDemandPlan(DemandVO demandinfo)
        {
            try {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into tblDemandPlan(Order_Num, Mat_Num, FirstMan, LastMan)
	                                            values (@Order_Num, @Mat_Num, @FirstMan,  @LastMan)";
                    cmd.Parameters.AddWithValue("Order_Num", demandinfo.Order_Num);
                    cmd.Parameters.AddWithValue("Order_Num", demandinfo.Mat_Num);
                    cmd.Parameters.AddWithValue("Order_Num", demandinfo.FirstMan);
                    cmd.Parameters.AddWithValue("Order_Num", demandinfo.LastMan);

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
