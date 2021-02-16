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
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "";
            chk.Name = "chk";
            chk.Width = 30;
            dgvWOS.Columns.Add(chk);

            dgvWOS.SetGridViewColumn("지시일", "WO_Date"); // 지시완료 버튼을 누른 순간 날짜를 저장
            dgvWOS.SetGridViewColumn("작업장명", "WP_Name");
            dgvWOS.SetGridViewColumn("자재코드", "Mat_Num");
            dgvWOS.SetGridViewColumn("자재명", "Mat_Name");
            dgvWOS.SetGridViewColumn("작업상태", "WO_Status");
            dgvWOS.SetGridViewColumn("창고", "Str_Kind"); // 창고테이블
            dgvWOS.SetGridViewColumn("지시량", "WO_Order_Cnt"); //작업지시생성
            dgvWOS.SetGridViewColumn("양품량", "GoodsCnt"); //직업이력테이블
            dgvWOS.SetGridViewColumn("불량", "ErrorCnt");  //직업이력테이블


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
            List<WorkOrderStatusVO> wolist = service.GetWorkOrdersStatusInfo(wpNum, matNum, wsNum, dtFrom, dtTo);
            dgvWOS.DataSource = wolist;
        }


    }
}
