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
using System.Windows.Forms;

namespace BedFactory
{
    public partial class frmSalesMaster : BedFactory.BaseForms.BaseForm2
    {
        /// <summary>
        /// 영업마스터를 조회할 때 정보를 한 번에 넘겨주기 위한 프로퍼티
        /// </summary>
        public SalesMasterVO salesmasterinfo
        {
            get
            {
                return new SalesMasterVO
                {
                    Deadline = dtpDeadline.Value.ToString("yyyy-MM-dd"),
                    UploadDate = dtpUploadDate.Value.ToString("yyyy-MM-dd"),
                    Order_Num = txtOrder_Num.Text,
                    Com_Name = cboCompany.Text,
                    Mat_Name = txtSubject_Name.Text
                };
            }
        }

        /// <summary>
        /// 수요 계획을 생성할 때 정보를 넘겨주기 위한 프로퍼티
        /// </summary>
        public DemandVO demandinfo
        {
            get
            {
                return new DemandVO
                {
                    Order_Num = dgvSalesMaster.CurrentRow.Cells[1].Value.ToString(),
                    SalesMaster_Num = dgvSalesMaster.CurrentRow.Cells[0].Value.ToString(),
                    FirstMan = dgvSalesMaster.CurrentRow.Cells[9].Value.ToString(),
                    LastMan = dgvSalesMaster.CurrentRow.Cells[11].Value.ToString()
                }
                ;
            }
        }

        public frmSalesMaster()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 데이터 그리드 뷰 컬럼 세팅
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesMaster_Load(object sender, EventArgs e)
        {
            dgvSalesMaster.SetGridViewColumn("영업마스터 번호", "SalesMaster_Num");
            dgvSalesMaster.SetGridViewColumn("주문 번호", "Order_Num");
            dgvSalesMaster.SetGridViewColumn("업체 번호", "Com_Num");
            dgvSalesMaster.SetGridViewColumn("업체 명", "Com_Name");
            dgvSalesMaster.SetGridViewColumn("품목 번호", "Mat_Num");
            dgvSalesMaster.SetGridViewColumn("품목명", "Mat_Name");
            dgvSalesMaster.SetGridViewColumn("수량", "Product_Cnt");
            dgvSalesMaster.SetGridViewColumn("납기일", "Deadline");
            dgvSalesMaster.SetGridViewColumn("업로드 날짜", "UploadDate");
            dgvSalesMaster.SetGridViewColumn("최초 등록자", "Firstman");
            dgvSalesMaster.SetGridViewColumn("최초 등록일", "FirstDate");
            dgvSalesMaster.SetGridViewColumn("최종 등록자", "Lastman");
            dgvSalesMaster.SetGridViewColumn("최종 등록일", "LastDate");
        }

        /// <summary>
        /// 컨트롤 포커스 받을시 콤보 박스 바인딩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboStatus_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 컨트롤 포커스 받을시 콤보 박스 바인딩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboCompany_Enter(object sender, EventArgs e)
        {
            CompanyService service = new CompanyService();
            List<CompanyVO> companyList = service.GetEveryCompanyName();
            if (companyList != null)
            {

                //companyList.Insert(0, new CompanyVO {Com_Num = 0, Com_Name = "" });
                companyList.ForEach(p => cboCompany.ValueMember = p.Com_Num.ToString());
                companyList.ForEach(p => cboCompany.DisplayMember = p.Com_Name.ToString());
            }
        }

        /// <summary>
        /// 컨트롤 포커스 받을시 콤보 박스 바인딩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboDestination_Enter(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// 수요계획 생성
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn3_Click_1(object sender, EventArgs e)
        {
            DemandPlanService service = new DemandPlanService();
            if (service.InsertDemandPlan(demandinfo))
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.InsertSuccess);
            }
            else
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.InsertFail);
            }

        }

        /// <summary>
        /// 영업마스터 수동 생성
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2_Click_1(object sender, EventArgs e)
        {
            frmSalesOrder frm = new frmSalesOrder();
            frm.Show();
            frm.Activate();
        }

        /// <summary>
        /// 조회 버튼 클릭시 원하는 내용을 그리드 뷰에 바인딩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            SalesMasterService service = new SalesMasterService();
            List<SalesMasterVO> list = service.GetSalesMaster(salesmasterinfo);
            if (list != null)
            {
                dgvSalesMaster.DataSource = list;
            }
        }


    }
}
