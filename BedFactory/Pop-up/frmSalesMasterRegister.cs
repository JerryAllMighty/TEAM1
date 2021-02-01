using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace BedFactory.Pop_up
{
    public partial class frmSalesMasterRegister : Form
    {
        frmSalesMasterUpload form;
        System.Data.DataTable dt;

        public frmSalesMasterRegister(frmSalesMasterUpload frm)
        {
            InitializeComponent();
            form = frm;
        }

        /// <summary>
        /// 영업 마스터 업로드 버튼 클릭시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            form.datasource = dt;
            this.Close();
        }

        /// <summary>
        /// 파일을 선택시 관련 정보를 아래에 바인딩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFileChoice_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Excel Files(*.xls)|*.xls|Excel Files(*.xlsx)|*.xlsx";
            dlg.Title = "영업 마스터 업로드";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
                string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";

                string fileName =  dlg.FileName;
                txtChosenFile.Text = dlg.SafeFileName;
                string fileExtension = System.IO.Path.GetExtension(fileName);
                string strConn = string.Empty;
                string sheetName = string.Empty;

                switch (fileExtension)
                {
                    case ".xls":
                        strConn = string.Format(Excel03ConString, fileName, "Yes");
                        break;
                    case ".xlsx":
                        strConn = string.Format(Excel07ConString, fileName, "Yes");
                        break;
                }
                //첫번째 Sheet 명을 가져옮

                OleDbConnection conn = new OleDbConnection(strConn);
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                conn.Open();
                System.Data.DataTable dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                sheetName = dtSchema.Rows[0]["TABLE_NAME"].ToString();
                conn.Close();

                conn.Open();
                // 엑셀파일을 읽었을때 테이블명은 [Sheet$]
                string sql = "select * from [" + sheetName + "]";
                OleDbDataAdapter oda = new OleDbDataAdapter(sql, conn);
                dt = new System.Data.DataTable();
                oda.Fill(dt);
                conn.Close();

                
            }

        }

        /// <summary>
        /// 취소 버튼 클릭시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
