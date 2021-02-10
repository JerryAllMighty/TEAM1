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
    public partial class frmSalesMasterUpload : BedFactory.BaseForms.BaseForm1
    {
        public DataTable datasource { get {return (DataTable)dgvSalesMasterUpload.DataSource; }
            set { dgvSalesMasterUpload.DataSource = value; } }

        public SalesMasterVO SalesInfo {
            get
            {
                return new SalesMasterVO
                {
                    Order_Num = dgvSalesMasterUpload[0, 0].Value.ToString(),
                    Deadline = dgvSalesMasterUpload[5, 0].Value.ToString(),
                    UploadDate = dgvSalesMasterUpload[5, 0].Value.ToString(),
                    Firstman = dgvSalesMasterUpload[9, 0].Value.ToString(),
                    Lastman = dgvSalesMasterUpload[11, 0].Value.ToString()
                };
            }
        }
        public frmSalesMasterUpload()
        {
            InitializeComponent();
        }

        //
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// 데이터 그리드 뷰 세팅
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesMasterUpload_Load(object sender, EventArgs e)
        {
            dgvSalesMasterUpload.SetGridViewColumn("주문 번호", "주문번호");
            dgvSalesMasterUpload.SetGridViewColumn("주문 상세 번호", "주문상세번호");
            dgvSalesMasterUpload.SetGridViewColumn("품목 번호", "자재번호");
            dgvSalesMasterUpload.SetGridViewColumn("품목명", "자재명");
            dgvSalesMasterUpload.SetGridViewColumn("주문 수량", "수량");
            dgvSalesMasterUpload.SetGridViewColumn("주문 날짜", "주문날짜");
            dgvSalesMasterUpload.SetGridViewColumn("주문 상태", "주문상태");
            dgvSalesMasterUpload.SetGridViewColumn("거래처번호", "거래처번호");
            dgvSalesMasterUpload.SetGridViewColumn("주문취소여부", "주문취소여부");
            dgvSalesMasterUpload.SetGridViewColumn("최초 등록자", "최초등록자");
            dgvSalesMasterUpload.SetGridViewColumn("최초 등록일", "최초등록일");
            dgvSalesMasterUpload.SetGridViewColumn("최종 등록자", "최종등록자");
            dgvSalesMasterUpload.SetGridViewColumn("최종 등록일", "최종등록일");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// 영업 마스터 업로드 팝업을 띄운다
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn3_Click(object sender, EventArgs e)
        {
            frmSalesMasterRegister frm = new frmSalesMasterRegister(this);
            frm.ShowDialog();
            frm.Activate();
        }

        /// <summary>
        /// 영업마스터 테이블에 등록한다
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2_Click(object sender, EventArgs e)
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
