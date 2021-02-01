using BedFactory.Pop_up;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BedFactory
{
    public partial class frmSalesMasterUpload : Form
    {
        public DataTable datasource { get {return (DataTable)dgvSalesMasterUpload.DataSource; }
            set { dgvSalesMasterUpload.DataSource = value; } }


        public frmSalesMasterUpload()
        {
            InitializeComponent();
        }

        //영업 마스터 업로드 팝업을 띄운다
        private void button1_Click(object sender, EventArgs e)
        {
            frmSalesMasterRegister frm = new frmSalesMasterRegister(this);
            frm.ShowDialog();
            frm.Activate();
        }

        /// <summary>
        /// 데이터 그리드 뷰 세팅
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesMasterUpload_Load(object sender, EventArgs e)
        {
            dgvSalesMasterUpload.SetGridViewColumn("마스터 버전 번호", "MasterVersion_Num");
            dgvSalesMasterUpload.SetGridViewColumn("작업 지시 번호", "WO_Num");
            dgvSalesMasterUpload.SetGridViewColumn("업체 번호", "Com_Num");
            dgvSalesMasterUpload.SetGridViewColumn("품목명", "Nat_Name");
            dgvSalesMasterUpload.SetGridViewColumn("총 수량", "TotalCnt");
            dgvSalesMasterUpload.SetGridViewColumn("출고 수량", "Ship_cnt");
            dgvSalesMasterUpload.SetGridViewColumn("납기일", "Deadline");
            dgvSalesMasterUpload.SetGridViewColumn("업로드 날짜", "Uploaddate");
            dgvSalesMasterUpload.SetGridViewColumn("최초 등록자", "Firstman");
            dgvSalesMasterUpload.SetGridViewColumn("최초 등록일", "FirstDate");
            dgvSalesMasterUpload.SetGridViewColumn("최종 등록자", "Lastman");
            dgvSalesMasterUpload.SetGridViewColumn("최종 등록일", "LastDate");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
