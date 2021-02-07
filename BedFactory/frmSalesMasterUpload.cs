using BedFactory.Pop_up;
using BedFactoryService;
using BedFactoryVO;
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

        public SalesMasterVO SalesInfo {
            get
            {
                return new SalesMasterVO
                {
                    Order_Num = Convert.ToInt32(dgvSalesMasterUpload[0, 0].Value.ToString()),
                    Com_Num = Convert.ToInt32(dgvSalesMasterUpload[1, 0].Value.ToString()),
                    Mat_Name = dgvSalesMasterUpload[2, 0].Value.ToString(),
                    TotalCnt = Convert.ToInt32(dgvSalesMasterUpload[3, 0].Value.ToString()),
                    Ship_Cnt = Convert.ToInt32(dgvSalesMasterUpload[4, 0].Value.ToString()),
                    Deadline = Convert.ToDateTime(dgvSalesMasterUpload[5, 0].Value.ToString().Replace("-","")),
                    UploadDate = Convert.ToDateTime(dgvSalesMasterUpload[6, 0].Value.ToString().Replace("-", "")),
                    Firstman = Convert.ToInt32(dgvSalesMasterUpload[7, 0].Value.ToString()),
                    Lastman = Convert.ToInt32(dgvSalesMasterUpload[9, 0].Value.ToString())
                };
            }
        }
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
            dgvSalesMasterUpload.SetGridViewColumn("주문 번호", "Order_Num");
            dgvSalesMasterUpload.SetGridViewColumn("업체 번호", "Com_Num");
            dgvSalesMasterUpload.SetGridViewColumn("품목명", "Mat_Name");
            dgvSalesMasterUpload.SetGridViewColumn("총 수량", "TotalCnt");
            dgvSalesMasterUpload.SetGridViewColumn("출고 수량", "Ship_Cnt");
            dgvSalesMasterUpload.SetGridViewColumn("납기일", "Deadline");
            dgvSalesMasterUpload.SetGridViewColumn("업로드 날짜", "UploadDate");
            dgvSalesMasterUpload.SetGridViewColumn("최초 등록자", "Firstman");
            dgvSalesMasterUpload.SetGridViewColumn("최초 등록일", "FirstDate");
            dgvSalesMasterUpload.SetGridViewColumn("최종 등록자", "Lastman");
            dgvSalesMasterUpload.SetGridViewColumn("최종 등록일", "LastDate");
        }

        /// <summary>
        /// 영업마스터 테이블에 등록한다
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            SalesMasterService service = new SalesMasterService();
            if (service.InsertSalesMaster(SalesInfo))
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.InsertSuccess);
            }
            else
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.InsertFail);
            }
        }
    }
}
