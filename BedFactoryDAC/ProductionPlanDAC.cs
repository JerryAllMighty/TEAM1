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

        public bool InsertProductionPlan()
        {
            try {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"";

                    cmd.Parameters.AddWithValue();

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
