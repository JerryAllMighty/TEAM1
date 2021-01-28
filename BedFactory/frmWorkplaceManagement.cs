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
    public partial class frmWorkplaceManagement : BedFactory.BaseForms.BaseForm2
    {
        public frmWorkplaceManagement()
        {
            InitializeComponent();
        }

        private void frmWorkplaceManagement_Load(object sender, EventArgs e)
        {
            dgvWorkplace.SetGridViewColumn("공정번호", "Process_Num");
            dgvWorkplace.SetGridViewColumn("공정명", "Process_Name");
            dgvWorkplace.SetGridViewColumn("작업장번호", "WP_Num");
            dgvWorkplace.SetGridViewColumn("작업장명", "WP_Name"); // 공정명 + 숫자로 등록
            dgvWorkplace.SetGridViewColumn("정보삭제여부", "IsDeleted");
            dgvWorkplace.SetGridViewColumn("최초등록자", "Firstman");
            dgvWorkplace.SetGridViewColumn("최초등록일", "Firstdate");
            dgvWorkplace.SetGridViewColumn("최종등록자", "Lastman");
            dgvWorkplace.SetGridViewColumn("최종수정일", "Lastdate");


            //공정명 바인딩
            ProcessService service = new ProcessService();
            List<CommonCodedVO> list = service.GetProcessCombo();
            CommonUtil.ComboBinding(cboProcessName, list, "공정");
        }

        //조회버튼
        private void btnSelect_Click(object sender, EventArgs e)
        {
            string prcName = cboProcessName.SelectedValue.ToString();
            string wpName = txtPlaceName.Text.Trim();

            WorkplaceService service = new WorkplaceService();
            List<WorkplaceVO> list = service.GetWorkplaceInfo(prcName, wpName);
            dgvWorkplace.DataSource = list;
        }

        //등록버튼
        public override void btn4_Click(object sender, EventArgs e)
        {
            frmWorkplaceReg frm = new frmWorkplaceReg();
            frm.ShowDialog();
        }

        //수정버튼
        //데이터그리드뷰 셀을 선택하고 수정버튼 누를시 or 셀 더블클릭시 => 등록,수정폼에 정보 바인딩 되고 수정 가능하게끔 코딩
        public override void btn3_Click(object sender, EventArgs e)
        {
            frmWorkplaceReg frm = new frmWorkplaceReg();
            frm.ShowDialog();
        }
    }
}
