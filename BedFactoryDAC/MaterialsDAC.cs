using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryDAC
{
    public class MaterialsDAC : ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection conn;

        public MaterialsDAC(string strConn) 
        { 
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public MaterialsDAC()
        {
            strConn = this.ConnectionString;
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public bool DeleteMaterilas(string id)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update tblMaterials set IsDeleted = 'Y'
                                    where Mat_Num = @Mat_Num";
                    cmd.Parameters.AddWithValue("@Mat_Num", id);

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
        /// 전체 자재정보 출력
        /// </summary>
        /// <returns></returns>
        public List<MaterialsVO> GetAllMaterials()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select Mat_Num, Mat_Name, Mat_Category, Mat_Kind, Mat_Size, BOM_Num, FirstMan, FirstDate, LastMan, LastDate from tblMaterials
                                        where IsDeleted = 'N'";

                    List<MaterialsVO> list = Helper.DataReaderMapToList<MaterialsVO>(cmd.ExecuteReader());

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
        /// 신규자재 등록
        /// </summary>
        /// <param name="vo">등록자재 정보</param>
        /// <param name="codeName">등록자재 코드</param>
        /// <returns></returns>
        public string NewMaterials(MaterialsVO vo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into tblMaterials (Mat_Num, Mat_Name, Mat_Category, Mat_Kind, Mat_Size, BOM_Num, FirstMan, FirstDate, LastMan, LastDate)
                                        values (
	                                        (select left(Code_Num, 2) + (select REPLICATE(0, 8 - len(count(*))) + CONVERT(varchar, count(*)) from tblMaterials) from CommonCode where Code_Name = @Mat_Category),
	                                        @Mat_Name, @Mat_Category, @Mat_Kind, @Mat_Size, @FirstMan, @LastMan
                                        )";
                    cmd.Parameters.AddWithValue("@Mat_Name", vo.Mat_Name);
                    cmd.Parameters.AddWithValue("@Mat_Category", vo.Mat_Category);
                    cmd.Parameters.AddWithValue("@Mat_Kind", vo.Mat_Kind);
                    cmd.Parameters.AddWithValue("@Mat_Size", vo.Mat_Size);
                    cmd.Parameters.AddWithValue("@FirstMan", vo.FirstMan);
                    cmd.Parameters.AddWithValue("@LastMan", vo.LastMan);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"select top 1 Mat_Num from tblMaterials order by FirstDate";
                    string i = cmd.ExecuteScalar().ToString();

                    return i;
                }
            }
            catch (Exception err)
            {
                Log.WriteError(err.Message);
                return null;
            }
        }

        /// <summary>
        /// 자재정보 수정
        /// </summary>
        /// <param name="vo">자재정보</param>
        /// <returns></returns>
        public bool UpdateMaterilas(MaterialsVO vo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"update tblMaterials 
                                        set Mat_Name = @Mat_Name, Mat_Category = @Mat_Category, Mat_Kind = @Mat_Kind, Mat_Size = @Mat_Size,
	                                        LastMan = @LastMan, LastDate = getdate()
                                        where Mat_Num = @Mat_Num";
                    cmd.Parameters.AddWithValue("@Mat_Name", vo.Mat_Name);
                    cmd.Parameters.AddWithValue("@Mat_Category", vo.Mat_Category);
                    cmd.Parameters.AddWithValue("@Mat_Kind", vo.Mat_Kind);
                    cmd.Parameters.AddWithValue("@Mat_Size", vo.Mat_Size);
                    cmd.Parameters.AddWithValue("@LastMan", vo.LastMan);

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

        /// <summary>
        /// 자재명을 콤보박스에 바인딩
        /// </summary>
        /// <returns></returns>
        public List<CommonCodeVO> GetMaterialsCombo()
        {
            string sql = @"select cast(Mat_Num as nvarchar) as Code_Num, Mat_Name as Code_Name, '자재' as Category
                           from tblMaterials 
                           where Isdeleted = 'N' ";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                List<CommonCodeVO> list = Helper.DataReaderMapToList<CommonCodeVO>(cmd.ExecuteReader());
                conn.Close();

                return list;
            }
        }
    }

}
