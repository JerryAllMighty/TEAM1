using BedFactory.Util;
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

namespace BedFactory.Pop_up
{
    public partial class frmWorkOrdersCreatePOPUP : Form
    {
        ProductionPlanVO productionplan;

        public WorkOrderVO workorderinfo
        {
            get
            {
                return new WorkOrderVO
                {
                    ProductionPlan_D_Num = productionplan.ProductionPlan_D_Num,
                    WP_Num = productionplan.WP_Num,
                    Mat_Num = productionplan.Mat_Num,
                    WO_Status = cboWOS.Text,
                    WO_Plan_Cnt = txtPlanCnt.Text,
                    WO_Order_Cnt = txtOrderCnt.Text,
                    WO_Detail = txtDetail.Text,
                    WO_D_Emp_Num = txtEmp.Text,
                    WO_Date = dtpFrom.Value.ToShortDateString(),
                    IsShip = "N"
                };
            }
        }
        public frmWorkOrdersCreatePOPUP(ProductionPlanVO vo)
        {
            InitializeComponent();
            productionplan = vo;
        }

        private void frmWorkOrdersCreatePOPUP_Load(object sender, EventArgs e)
        {
            txtWpName.Text = productionplan.WP_Name;
            dtpFrom.Value = Convert.ToDateTime(productionplan.ProductionDate);
            txtPlanCnt.Text = productionplan.ProductionCnt;
            txtMatName.Text = productionplan.Mat_Name;
            txtOrderCnt.Text = productionplan.ProductionCnt;


            //콤보박스 바인딩(공통코드) 
            if (frmCommonCode.commonList == null) // 항상 널 체크
                frmCommonCode.CheckCommonInfo();  // 널일때만 갖다오기
            CommonUtil.CommonCodeBindig(cboWOS, frmCommonCode.commonList, "작업상태", "");
        }


        //등록
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cboPrcName.SelectedValue == null || cboWpName.SelectedValue == null || cboMatName.SelectedValue == null || cboWOS.SelectedValue == null)
                return;


            if (cboPrcName.SelectedValue.ToString().Length < 1 || cboWpName.SelectedValue.ToString().Length < 1 || cboMatName.SelectedValue.ToString().Length < 1 || cboWOS.SelectedValue.ToString().Length < 1)
                return;

            WorkOrderService service = new WorkOrderService();
            bool bResult = false;

            WorkOrderVO vo = new WorkOrderVO
            {
                Process_Num = cboMatName.SelectedValue.ToString(),
                WP_Num = cboMatName.SelectedValue.ToString(),
                Mat_Num = cboMatName.SelectedValue.ToString(),
                WO_Status = cboWOS.SelectedValue.ToString(),
                WO_Plan_Cnt = txtDetail.Text,
                WO_Order_Cnt = txtDetail.Text,
                WO_Detail = txtDetail.Text,
                WO_D_Emp_Num = txtDetail.Text,
                IsShip = (rdoY.Checked) ? "Y" : "N",
                //    ProductionDate = 
            };

            //      bResult = service.InsertWorkOrdderInfo(vo);
            if (bResult)
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.InsertSuccess);
                this.Close();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 작업지시 저장
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            WorkOrderService service = new WorkOrderService();
            if (service.InsertWorkOrdderInfo2(workorderinfo))
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.InsertSuccess);
            }
            else
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.InsertFail);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
