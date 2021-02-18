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
        public frmWorkOrdersCreatePOPUP()
        {
            InitializeComponent();
        }

        private void frmWorkOrdersCreatePOPUP_Load(object sender, EventArgs e)
        {
            //콤보박스 바인딩(공통코드)  : 예시
            if (frmCommonCode.commonList == null) // 항상 널 체크
                frmCommonCode.CheckCommonInfo();  // 널일때만 갖다오기

            CommonUtil.CommonCodeBindig(cboPrcName, frmCommonCode.commonList, "공정", "");

            // 작업장명 콤보박스 바인딩 (DAC단으로 연결)
            WorkplaceService wpService = new WorkplaceService();
            List<CommonCodeVO> wplist = wpService.GetWorkplaceCombo();
            CommonUtil.ComboBinding(cboWpName, wplist, "작업장");

            // 자재명 콤보박스 바인딩 (DAC단으로 연결)
            MaterialsService matService = new MaterialsService();
            List<CommonCodeVO> matlist = matService.GetMaterialsCombo();
            CommonUtil.ComboBinding(cboMatName, matlist, "자재");

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

            bResult = service.InsertWorkOrdderInfo(vo);
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
    }
}
