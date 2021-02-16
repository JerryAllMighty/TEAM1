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
using BedFactory.Pop_up;

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
            dgvWOC.SetGridCheckBox("");
            dgvWOC.SetGridViewColumn("작업지시번호", "WO_Num");
            dgvWOC.SetGridViewColumn("상세공정명", "Process_Name_D");
            dgvWOC.SetGridViewColumn("작업장명", "WP_Name");
            dgvWOC.SetGridViewColumn("자재명", "Mat_Name");
            dgvWOC.SetGridViewColumn("작업지시상태", "WO_Status");
            dgvWOC.SetGridViewColumn("계획시작일", "ProductionDate");
            dgvWOC.SetGridViewColumn("계획납기일", "DeadLine");
            dgvWOC.SetGridViewColumn("계획수량", "WO_Plan_Cnt");
            dgvWOC.SetGridViewColumn("지시수량", "WO_Order_Cnt");
            dgvWOC.SetGridViewColumn("작업내용", "WO_Detail");
            dgvWOC.SetGridViewColumn("작업담당자", "WO_D_Emp_Num");
            dgvWOC.SetGridViewColumn("출고여부", "IsShip");
            dgvWOC.SetGridViewColumn("작업경과시간", "WO_StartTime");
            dgvWOC.SetGridViewColumn("작업중지시간", "WO_FinishTime");

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

            Point point = dgvWOC.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheck.Location = new Point(point.X + 8, point.Y + 2);
            headerCheck.BackColor = Color.Transparent;
            headerCheck.Size = new Size(18, 18);
            headerCheck.Click += HeaderCheck_Click; ;
            dgvWOC.Controls.Add(headerCheck);

            dtpTo.MinDate = dtpFrom.Value.AddDays(-7);
            dtpFrom.Value = DateTime.Now.AddDays(-7);
        }

        //전체체크/해제
        private void HeaderCheck_Click(object sender, EventArgs e) // ?
        {
            dgvWOC.EndEdit();

            foreach (DataGridViewRow row in dgvWOC.Rows)
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


            DateTime dtFrom = dtpFrom.Value;
            DateTime dtTo = dtpTo.Value;


            WorkOrdersService service = new WorkOrdersService();
            List<WorkOrdersVO> wolist = service.GetWorkOrdersInfo(wpNum, matNum, wsNum, dtFrom, dtTo);
            dgvWOC.DataSource = wolist;
        }

        //작업지시를 확정하는 버튼
        public override void btn5_Click(object sender, EventArgs e)
        {
            dgvWOC.EndEdit();

            //체크된 정보 얻어오는것
            List<WorkOrdersVO> chkWoList = new List<WorkOrdersVO>();

            for (int i = 0; i < dgvWOC.Rows.Count; i++)
            {
                bool isCellChecked = (bool)dgvWOC.Rows[i].Cells["chk"].EditedFormattedValue;
                if (isCellChecked == true)
                {
                  // chkWoList.Add(dgvWOC.Rows[i].Cells[1].Value.ToString());
                }
            }

            MessageBox.Show(String.Join(", ", chkWoList));
        }

        //작업지시 등록 버튼
        public override void btn2_Click(object sender, EventArgs e)
        {
            frmWorkOrdersCreatePOPUP frm = new frmWorkOrdersCreatePOPUP();
            frm.ShowDialog();
        }

        //작업지시 삭제
        private void btnWOdelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvWOC.Rows)
            {
                if (dgvWOC.SelectedRows.Count < 1)
                {
                    MessageBox.Show("삭제할 작업지시정보를 선택해주세요.");
                    return;
                }

                if (MessageBox.Show($"{dgvWOC[1, dgvWOC.SelectedRows[0].Index].Value} 번 작업지시정보를 삭제하시겠습니까?"
                    , "삭제확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    WorkOrdersService service = new WorkOrdersService();

                    bool result = service.DeleteWorkOrdersInfo(Convert.ToInt32(dgvWOC[1, dgvWOC.SelectedRows[0].Index].Value));

                    if (result)
                    {
                        MessageBox.Show(BedFactory.Properties.Settings.Default.DeleteSuccess);
                    }
                    else
                    {
                        MessageBox.Show(BedFactory.Properties.Settings.Default.DeleteFail);
                    }
                }
            }
        }
    }
}
