using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BedFactoryVO;

namespace BedFactoryDAC
{
    public class BOMDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;

        public BOMDAC()
        {
            strConn = this.ConnectionString;
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public List<BOMVO> GetBOM(string mat_Num)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select BOM_Num, bom.Mat_Num, Use_Mat_Num, Cnt, bom.Firstman, bom.Firstdate, bom.Lastman, bom.Lastdate, bom.IsDeleted
                                        from tblBOM as bom
                                        join tblMaterials as mat on bom.Mat_Num = mat.Mat_Num
                                        where bom.Mat_Num = @mat_Num and bom.IsDeleted = 'N'";
                    cmd.Parameters.AddWithValue("@mat_Num", mat_Num);
                    List<BOMVO> list = Helper.DataReaderMapToList<BOMVO>(cmd.ExecuteReader());

                    return list;
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
