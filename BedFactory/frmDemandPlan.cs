using BedFactory.Pop_up;
using BedFactoryService;
using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BedFactory
{
    public partial class frmDemandPlan : BedFactory.BaseForms.BaseForm2
    {
        public DemandVO demandinfo { get {
                return new DemandVO
                {
                    Demand_Plan_Num = lblSalesMaster_Num.Text,
                    Com_Name = cboCompany.Text,
                    LastDate = dtpFrom.Value.ToString("yyyy-MM-dd"),
                    Mat_Name = txtSubjectName.Text
                };
            } }
        public frmDemandPlan()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 검색 조건에 따른 수요 계획 조회 버튼, 내용을 가져와서 그리드 뷰에 바인딩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            DemandPlanService service = new DemandPlanService();
            List<DemandVO> list = service.GetDemandPlan(demandinfo);
            if (list != null)
            {
                dgvDemandPlan.DataSource = list;
            }
        }

        /// <summary>
        /// 폼 로드시 데이터그리드뷰 컬럼 세팅
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDemandPlan_Load(object sender, EventArgs e)
        {
            dgvDemandPlan.SetGridViewColumn("수요 계획 번호","Demand_Plan_Num");
            dgvDemandPlan.SetGridViewColumn("주문 번호", "Order_Num");
            dgvDemandPlan.SetGridViewColumn("영업 마스터 번호", "SalesMaster_Num");
            dgvDemandPlan.SetGridViewColumn("업체명", "Com_Name");
            dgvDemandPlan.SetGridViewColumn("품목명", "Mat_Name");
            dgvDemandPlan.SetGridViewColumn("등록일", "LastDate");


        }

        /// <summary>
        /// 생산계획 생성 버튼 클릭시, 수동으로 생산계획을 만들 수 있는 팝업 호출
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2_Click_1(object sender, EventArgs e)
        {
            frmSalesOrder frm = new frmSalesOrder();
            frm.Show();
            frm.Activate();
        }

    }
}
