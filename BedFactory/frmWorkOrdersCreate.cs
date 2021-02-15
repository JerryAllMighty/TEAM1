using BedFactory.Util;
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
    public partial class frmWorkOrdersCreate : BedFactory.BaseForms.BaseForm2
    {
        CheckBox headerCheck = new CheckBox();

        public frmWorkOrdersCreate()
        {
            InitializeComponent();
        }

        private void frmWorkOrderCreate_Load(object sender, EventArgs e)
        {
            dgvWOS.SetGridCheckBox("");
            dgvWOS.SetGridViewColumn("작업지시번호", "WO_Num");
            dgvWOS.SetGridViewColumn("상세공정명", "Process_Name_D");
            dgvWOS.SetGridViewColumn("작업장명", "WP_Name");
            dgvWOS.SetGridViewColumn("자재명", "Mat_Name");
            dgvWOS.SetGridViewColumn("작업지시상태", "WO_Status");
            dgvWOS.SetGridViewColumn("계획시작일", "ProductionDate");
            dgvWOS.SetGridViewColumn("계획납기일", "DeadLine");
            dgvWOS.SetGridViewColumn("계획수량", "WO_Plan_Cnt");
            dgvWOS.SetGridViewColumn("지시수량", "WO_Order_Cnt");
            dgvWOS.SetGridViewColumn("작업내용", "WO_Detail");
            dgvWOS.SetGridViewColumn("출고여부", "IsShip");

            // 작업장명 콤보박스 바인딩 (DAC단으로 연결)
            WorkplaceService wpService = new WorkplaceService();
            List<CommonCodeVO> wplist = wpService.GetWorkplaceCombo();
            CommonUtil.ComboBinding(cboWp, wplist, "작업장");

            // 자재명 콤보박스 바인딩 (DAC단으로 연결)
            MaterialsService matService = new MaterialsService();
            List<CommonCodeVO> matlist = matService.GetMaterialsCombo();
            CommonUtil.ComboBinding(cboMat, matlist, "자재");

            //콤보박스 바인딩(공통코드) 
            if (frmCommonCode.commonList == null) // 항상 널 체크
                frmCommonCode.CheckCommonInfo();  // 널일때만 갖다오기
            CommonUtil.CommonCodeBindig(cboWs, frmCommonCode.commonList, "작업상태", "");

            Point point = dgvWOS.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheck.Location = new Point(point.X + 8, point.Y + 2);
            headerCheck.BackColor = Color.Transparent;
            headerCheck.Size = new Size(18, 18);
            headerCheck.Click += HeaderCheck_Click; ;
            dgvWOS.Controls.Add(headerCheck);

            dtpTo.MinDate = dtpFrom.Value.AddDays(-7);
        }

        private void HeaderCheck_Click(object sender, EventArgs e) // ?
        {
            dgvWOS.EndEdit();

            foreach (DataGridViewRow row in dgvWOS.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chk"];
                chk.Value = headerCheck.Checked;
            }
        }


        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {  
            dtpTo.MinDate = dtpFrom.Value;
        }
    }
}
