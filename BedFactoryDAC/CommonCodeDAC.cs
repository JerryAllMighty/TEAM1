using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryDAC
{
    public class CommonCodeDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;

        public CommonCodeDAC()
        {
            strConn = this.ConnectionString;
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public DataTable GetCommonCodeInfo()
        {
            try {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select Code_Num, Code_Name, Category, P_Code from CommonCode";

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt != null ? dt : null;
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
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
