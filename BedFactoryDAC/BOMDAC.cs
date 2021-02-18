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

        /// <summary>
        /// BOM호출
        /// </summary>
        /// <param name="mat_Num">BOM을 호출할 품목</param>
        /// <returns></returns>
        public List<BOMVO> GetBOM(string mat_Num)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select BOM_Num, bom.Mat_Num, Use_Mat_Num, Cnt, bom.Firstman, bom.Firstdate, bom.Lastman, bom.Lastdate, bom.IsDeleted, Mat_Category, Mat_Name
                                        from tblBOM as bom
                                        join tblMaterials as mat on bom.Use_Mat_Num = mat.Mat_Num
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

        /// <summary>
        /// BOM수정
        /// </summary>
        /// <param name="vo">BOM정보</param>
        /// <returns></returns>
        public bool UpdateBOM(BOMVO vo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update tblBOM set Cnt = @Cnt, Lastman = @Lastman, Lastdate = GETDATE()
                                        where BOM_Num = @BOM_Num";
                    cmd.Parameters.AddWithValue("@BOM_Num", vo.BOM_Num);
                    cmd.Parameters.AddWithValue("@Cnt", vo.Cnt);
                    cmd.Parameters.AddWithValue("@Lastman", vo.Lastman);

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
        /// BOM삭제
        /// </summary>
        /// <param name="bom_Num"></param>
        /// <returns></returns>
        public bool DeleteBOM(int bom_Num)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update tblBOM set IsDeleted = 'Y' where BOM_Num = @BOM_Num";
                    cmd.Parameters.AddWithValue("@BOM_Num", bom_Num);

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
        /// BOM등록
        /// </summary>
        public bool InsertBOM(BOMVO vo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into tblBOM (Mat_Num, Use_Mat_Num, Cnt, Firstman, Lastman)
                                        values (@Mat_Num, @Use_Mat_Num, @Cnt, @Firstman, @Lastman)";
                    cmd.Parameters.AddWithValue("@Mat_Num", vo.Mat_Num);
                    cmd.Parameters.AddWithValue("@Use_Mat_Num", vo.Use_Mat_Num);
                    cmd.Parameters.AddWithValue("@Cnt", vo.Cnt);
                    cmd.Parameters.AddWithValue("@Firstman", vo.Firstman);
                    cmd.Parameters.AddWithValue("@Lastman", vo.Lastman);

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

        public bool DropBOM(BOMVO vo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into tblBOM (Mat_Num, Use_Mat_Num, Cnt, Firstman, Lastman)
                                        values (@Mat_Num, @Use_Mat_Num, @Cnt, @Firstman, @Lastman)";
                    cmd.Parameters.AddWithValue("@Mat_Num", vo.Mat_Num);
                    cmd.Parameters.AddWithValue("@Use_Mat_Num", vo.Use_Mat_Num);
                    cmd.Parameters.AddWithValue("@Cnt", vo.Cnt);
                    cmd.Parameters.AddWithValue("@Firstman", vo.Firstman);
                    cmd.Parameters.AddWithValue("@Lastman", vo.Lastman);

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
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
