using BedFactoryVO;
using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryDAC
{
    public class MaterialsDAC : IDisposable
    {
        SqlConnection conn;
        ILog log = null;

        public MaterialsDAC(ILog log, string strConn) 
        { 
            this.log = log;
            conn = new SqlConnection(strConn);
            conn.Open();
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
                log.Error("GetAllMaterials() 오류 : " + err.Message);
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
