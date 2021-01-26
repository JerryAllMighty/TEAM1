using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryDAC
{
    public class UnitCostDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;

        public UnitCostDAC()
        {
            strConn = this.ConnectionString;
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        public List<UnitCostVO> UnitCostSelect(string category)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select Convert(int, Row_Number() over(order by Com_Num, Mat_Num)) Rownum, UnitCost_Num
                                               , U.Com_Num, C.Com_Name, U.Mat_Num, M.Mat_Name, Now_UnitCost, Before_UnitCost
                                               , Start_Date, End_Date, U.FirstMan, U.FirstDate, U.LastMan, U.LastDate
                                          from tblUnitCost U join tblCompany C on U.Com_Num = C.Com_Num 
	                                           join tblMaterials M on U.Mat_Num = M.Mat_Num
                                         where C.Com_Category = @Com_Category";

                    cmd.Parameters.AddWithValue("@Com_Category", category);
                    List<UnitCostVO> list = Helper.DataReaderMapToList<UnitCostVO>(cmd.ExecuteReader());
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
