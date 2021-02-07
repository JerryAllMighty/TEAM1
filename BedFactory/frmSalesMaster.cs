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
        /// 처음 영업마스터에 대한 정보를 가져올 때는 날짜만을 기준으로 필터링 후 가져온다, 이후 린큐로 추가 필터링 후 바인딩 예정
        /// </summary>
        public SalesMasterVO salesmasterinfo
        {
            get
            {
                return new SalesMasterVO
                {
                    Deadline = Convert.ToDateTime(dtpDeadline.Value.ToShortDateString()),
                    UploadDate = Convert.ToDateTime(dtpUploadDate.Value.ToShortDateString())
                };
            }
        }

        public DemandVO demandinfo
        {
            get
            {
                return new DemandVO
                {
                    Order_Num = dgvSalesMaster[]

                }
                ;
            }
        }

        public frmSalesMaster()
        {
            InitializeComponent();
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
                companyList.ForEach(p => cboCompany.ValueMember = p.Com_Num.ToString());
                companyList.ForEach(p => cboCompany.DisplayMember = p.Com_Name.ToString());
                cboCompany.SelectedIndex = 0;
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

        ///// <summary>
        ///// 영업마스터 로드
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btn4_Click_1(object sender, EventArgs e)
        //{
        //    SalesMasterService service = new SalesMasterService();
        //    service.GetSalesMaster();
        //}

        /// <summary>
        /// 수요계획 생성
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn3_Click_1(object sender, EventArgs e)
        {
            DemandPlanService service = new DemandPlanService();
            service.InsertDemandPlan(demandinfo);

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
                
                var SelectList = (from item in list
                 where item.Order_Num == Convert.ToInt32(txtOrder_Num.Text) && item.Com_Num == Convert.ToInt32(cboCompany.SelectedValue)
                       && item.Mat_Name == txtSubject_Name.Text
                 select item).ToList();

                dgvSalesMaster.DataSource = SelectList;
            }
        }

        /// <summary>
        /// 데이터 그리드 뷰 컬럼 세팅
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesMaster_Load(object sender, EventArgs e)
        {
            dgvSalesMaster.SetGridViewColumn("주문 번호", "Order_Num");
            dgvSalesMaster.SetGridViewColumn("업체 번호", "Com_Num");
            dgvSalesMaster.SetGridViewColumn("품목명", "Mat_Name");
            dgvSalesMaster.SetGridViewColumn("총 수량", "TotalCnt");
            dgvSalesMaster.SetGridViewColumn("출고 수량", "Ship_Cnt");
            dgvSalesMaster.SetGridViewColumn("납기일", "Deadline");
            dgvSalesMaster.SetGridViewColumn("업로드 날짜", "UploadDate");
            dgvSalesMaster.SetGridViewColumn("최초 등록자", "Firstman");
            dgvSalesMaster.SetGridViewColumn("최초 등록일", "FirstDate");
            dgvSalesMaster.SetGridViewColumn("최종 등록자", "Lastman");
            dgvSalesMaster.SetGridViewColumn("최종 등록일", "LastDate");
        }

        //Order_Num = Convert.ToInt32(txtOrder_Num.Text),
        //            Com_Num = Convert.ToInt32(cboCompany.Text),
        //            Mat_Name = txtSubject_Name.Text,
        //            Deadline = Convert.ToDateTime(dtpDeadline.Value.ToString()),
        //            UploadDate = Convert.ToDateTime(dtpUploadDate.Value.ToShortDateString())
    }
}
