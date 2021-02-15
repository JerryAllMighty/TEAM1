using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryDAC
{
    public class EmployeeDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;

        public EmployeeDAC()
        {
            strConn = this.ConnectionString;
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public List<EmployeeVO> GetEmployeeListByWPNum(string WPNum)
        {
            try {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select Convert(nchar(10), E.Emp_Num) Emp_Num, Convert(nchar(10), E.Emp_Name) Emp_Name
                                            from tblEmployees E
                                            inner join tblWorkOrders WO
                                            on WO.WO_D_Emp_Num != E.Emp_Num
                                            where WO.WP_Num = @Wp_Num";

                    cmd.Parameters.AddWithValue("@Wp_Num", WPNum);

                    List<EmployeeVO> list = Helper.DataReaderMapToList<EmployeeVO>(cmd.ExecuteReader());
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
