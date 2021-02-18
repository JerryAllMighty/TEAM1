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
    public partial class frmWorkOrdersStatus : BedFactory.BaseForms.BaseForm2
    {
        public frmWorkOrdersStatus()
        {
            InitializeComponent();
        }

        CheckBox headerCheck = new CheckBox();


        private void frmWorkOrdersStatus_Load(object sender, EventArgs e)
        {
            //dgvWOC.SetGridCheckBox("");
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "";
            chk.Name = "chk";
            chk.Width = 30;
            dgvWOS.Columns.Add(chk);

            dgvWOS.SetGridViewColumn("작업지시번호", "WO_Num");
            dgvWOS.SetGridViewColumn("상세공정명", "Process_Name_D");
            dgvWOS.SetGridViewColumn("작업장명", "WP_Name");
            dgvWOS.SetGridViewColumn("자재명", "Mat_Name");
            dgvWOS.SetGridViewColumn("작업지시상태", "WO_Status");
            dgvWOS.SetGridViewColumn("계획수량", "WO_Plan_Cnt");
            dgvWOS.SetGridViewColumn("지시수량", "WO_Order_Cnt");
            dgvWOS.SetGridViewColumn("작업내용", "WO_Detail");
            dgvWOS.SetGridViewColumn("작업담당자", "WO_D_Emp_Num");
            dgvWOS.SetGridViewColumn("출고여부", "IsShip");
            dgvWOS.SetGridViewColumn("계획시작일", "ProductionDate");
            dgvWOS.SetGridViewColumn("계획납기일", "DeadLine");

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
            dtpFrom.Value = DateTime.Now.AddDays(-7);
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

        //조회
        private void btnSelect_Click(object sender, EventArgs e)
        {
            int wpNum = 0;
            if (cboWp.SelectedValue != null)
                wpNum = (cboWp.SelectedValue.ToString() == "") ? 0 : Convert.ToInt32(cboWp.SelectedValue);

            string matNum = null;
            if (cboMat.SelectedValue != null)
                matNum = (cboMat.SelectedValue.ToString() == null) ? "" : cboMat.SelectedValue.ToString();

            int wsNum = 0;
            if (cboWs.SelectedValue != null)
                wsNum = (cboWs.SelectedValue.ToString() == "") ? 0 : Convert.ToInt32(cboWs.SelectedValue);


            string dtFrom = dtpFrom.Value.ToShortDateString();
            string dtTo = dtpTo.Value.ToShortDateString();


            WorkOrderService service = new WorkOrderService();
            List<WorkOrderVO> wolist = service.GetWorkOrdersInfo(wpNum, matNum, wsNum, dtFrom, dtTo);
            dgvWOS.DataSource = wolist;
        }


        public override void btn5_Click(object sender, EventArgs e)
        {
            if (dgvWOS.SelectedRows.Count < 1)
            {
                MessageBox.Show("확정할 작업지시예정정보를 선택해주세요.");
                return;
            }
            else if (MessageBox.Show($"이 자재의 작업지시예정을 확정하시겠습니까?", "확정확인", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            dgvWOS.EndEdit();

            List<int> chkWoList = new List<int>();

            //체크된 정보 얻어오는것
            for (int i = 0; i < dgvWOS.Rows.Count; i++)
            {
                bool isCellChecked = (bool)dgvWOS.Rows[i].Cells["chk"].EditedFormattedValue;
                if (isCellChecked)
                {
                    chkWoList.Add(Convert.ToInt32(dgvWOS.Rows[i].Cells["WO_Num"].Value));
                }
            }

            WorkOrderService service = new WorkOrderService();
            if (service.UpdateWorkOrderDate(chkWoList))
            {
                dgvWOS.ClearSelection();
                btnSelect.PerformClick();
            }
        }

        public override void btn1_Click(object sender, EventArgs e)
        {
            if (dgvWOS.SelectedRows.Count < 1)
            {
                MessageBox.Show("삭제할 작업지시정보를 선택해주세요.");
                return;
            }

            else if (MessageBox.Show($"작업지시정보를 삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            dgvWOS.EndEdit();

            List<int> nums = new List<int>();

            //체크된 정보 얻어오는것
            for (int i = 0; i < dgvWOS.Rows.Count; i++)
            {
                bool isCellChecked = (bool)dgvWOS.Rows[i].Cells["chk"].EditedFormattedValue;
                if (isCellChecked)
                {
                    nums.Add(Convert.ToInt32(dgvWOS.Rows[i].Cells["WO_Num"].Value));
                }
            }

            WorkOrderService service = new WorkOrderService();
            bool result = service.DeleteWorkOrdersInfo(nums);

            if (result)
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.DeleteSuccess);
                dgvWOS.ClearSelection();
                btnSelect.PerformClick();
            }
            else
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.DeleteFail);
            }
        }
    }
}
