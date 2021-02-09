using BedFactoryVO;
using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryAPI
{
    public class MaterialsDAC
    {
        string strConn;
        ILog log = null;

        public MaterialsDAC(string strConn, ILog log) { this.strConn = strConn; this.log = log; }

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
                    cmd.Connection = new SqlConnection(strConn);
                    cmd.CommandText = @"select Mat_Num, Mat_Name, Mat_Category, Mat_Kind, Mat_Size, FirstMan, FirstDate, LastMan, LastDate from tblMaterials
                                        where IsDeleted = 'N'";

                    cmd.Connection.Open();
                    List<MaterialsVO> list = Helper.DataReaderMapToList<MaterialsVO>(cmd.ExecuteReader());
                    cmd.Connection.Close();

                    return list;
                }
            }
            catch (Exception err)
            {
                log.Error(err.Message);
                return null;
            }
        }
    }
}
