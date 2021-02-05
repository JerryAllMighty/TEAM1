using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryDAC
{
    public class BORDAC:ConnectionAccess, IDisposable
    {
        string strConn;
        SqlConnection Conn;

        public BORDAC()
        {
            strConn = this.ConnectionString;
            Conn = new SqlConnection(strConn);
            Conn.Open();
        }

        public void Dispose()
        {
            if (Conn != null)
            {
                this.Dispose();
            }
        }

        /// <summary>
        /// 작업장과 자재명을 조건으로 품목 조회
        /// </summary>
        /// <param name="prcNum">공정상세명</param>
        /// <param name="wpNum">작업장명</param>
        /// <param name="matNum">자재명</param>
        /// <returns></returns>
        public List<BORVO> GetBorInfo(int prcNum, int wpNum, string matNum)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(@"select BOR_Num, R.Process_Num, R.WP_Num, R.Mat_Num, P.Process_Name_D, W.WP_Name, M.Mat_Category, 
                                   M.Mat_Name, R.Tact_Time, R.IsUse, R.BOR_Comment, R.Firstman, R.Firstdate, R.Lastman, R.Lastdate
                              from tblBOR R inner join tblMaterials M on R.Mat_Num = M.Mat_Num
			                              inner join tblWorkplace W on R.WP_Num = W.WP_Num
			                              inner join tblProcess P on R.Process_Num = P.Process_Num
                             where 1=1 ");

                if (prcNum > 0)
                    sb.Append(" and R.Process_Num = @prcNum");
                if (wpNum > 0)
                    sb.Append(" and R.WP_Num = @wpNum");
                if (!string.IsNullOrEmpty(matNum))
                    sb.Append(" and R.Mat_Num = @matNum");

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Conn;
                    cmd.CommandText = sb.ToString();

                    if (prcNum > 0)
                        cmd.Parameters.AddWithValue("@prcNum", prcNum);
                    if (wpNum > 0)
                        cmd.Parameters.AddWithValue("@wpNum", wpNum);
                    if (!string.IsNullOrEmpty(matNum))
                        cmd.Parameters.AddWithValue("@matNum", matNum);

                    List<BORVO> list = Helper.DataReaderMapToList<BORVO>(cmd.ExecuteReader());
                    Conn.Close();

                    return list;
                }

            }
            catch(Exception err)
            {
                Log.WriteError(err.Message);
                return null;
            }
        }

        /// <summary>
        /// BOR정보 등록
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public bool InsertBORInfo(BORVO vo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = Conn;
                    cmd.CommandText = @"insert into tblBOR (Process_Num, WP_Num, Mat_Num, BOR_Comment,
                                                    Tact_Time, IsUse, Firstman,  Lastman)
                                        values (@Process_Num, @WP_Num, @Mat_Num, @Tact_Time,
                                                @IsUse,@BOR_Comment, @Firstman, @Lastman) ";
  
                    cmd.Parameters.AddWithValue("@Process_Num", vo.Process_Num);
                    cmd.Parameters.AddWithValue("@WP_Num", vo.WP_Num);
                    cmd.Parameters.AddWithValue("@Mat_Num", vo.Mat_Num);
                    cmd.Parameters.AddWithValue("@Tact_Time", vo.Tact_Time);
                    cmd.Parameters.AddWithValue("@IsUse", vo.IsUse);
                    cmd.Parameters.AddWithValue("@BOR_Comment", vo.BOR_Comment);
                    cmd.Parameters.AddWithValue("@Firstman", vo.Firstman);   
                    cmd.Parameters.AddWithValue("@Lastman", vo.Lastman);
      

                    int iRowAffect = cmd.ExecuteNonQuery();
                    Conn.Close();

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
        /// BOR 정보 수정
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public bool UpdateBORInfo(BORVO vo)  // => update 구문 두번 써야 하므로 프로시저 사용
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Conn;
                cmd.CommandText = @"update tblBOR set Process_Num=@Process_Num, WP_Num=@WP_Num, Mat_Num=@Mat_Num, 
				                    Tact_Time=@Tact_Time, IsUse=@IsUse, BOR_Comment = @BOR_Comment, Lastman=@Lastman, Lastdate=getdate()
				                    where BOR_Num = @BOR_Num ";

               
                cmd.Parameters.AddWithValue("@Process_Num", vo.Process_Num);
                cmd.Parameters.AddWithValue("@WP_Num", vo.WP_Num);
                cmd.Parameters.AddWithValue("@Mat_Num", vo.Mat_Num);
                cmd.Parameters.AddWithValue("@Tact_Time", vo.Tact_Time);
                cmd.Parameters.AddWithValue("@IsUse", vo.IsUse);
                cmd.Parameters.AddWithValue("@BOR_Comment", vo.BOR_Comment);
                cmd.Parameters.AddWithValue("@Lastman", vo.Lastman);
                cmd.Parameters.AddWithValue("@BOR_Num", vo.BOR_Num);

                int iRowAffect = cmd.ExecuteNonQuery();

                return iRowAffect > 0 ? true : false;
            }
        }


    }
}
