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
    public partial class frmWorkplaceManagement : BedFactory.BaseForms.BaseForm2
    {
        public frmWorkplaceManagement()
        {
            InitializeComponent();
        }

        private void frmWorkplaceManagement_Load(object sender, EventArgs e)
        {
            dgvWorkplace.SetGridCheckBox("선택");
            dgvWorkplace.SetGridViewColumn("작업장번호", "WP_Num");
            dgvWorkplace.SetGridViewColumn("작업장명", "WP_Name"); // 공정명 + 숫자로 등록
            dgvWorkplace.SetGridViewColumn("상세공정명", "Process_Name_Detail");
            dgvWorkplace.SetGridViewColumn("특이사항", "WP_Note");
            dgvWorkplace.SetGridViewColumn("비고", "WP_Other"); 
            dgvWorkplace.SetGridViewColumn("정보삭제여부", "IsDeleted");
            dgvWorkplace.SetGridViewColumn("최초등록자", "Firstman");
            dgvWorkplace.SetGridViewColumn("최초등록일", "Firstdate");
            dgvWorkplace.SetGridViewColumn("최종등록자", "Lastman");
            dgvWorkplace.SetGridViewColumn("최종수정일", "Lastdate");
            dgvWorkplace.SetGridViewColumn("공정번호", "Process_Num", visibility: false);


            // 공정상세명 콤보박스 바인딩 (DAC단으로 연결)
            ProcessService service = new ProcessService();
            List<CommonCodeVO> list = service.GetProcessCombo();
            CommonUtil.ComboBinding(cboProcessName, list, "공정");
        }

        //조회버튼
        private void btnSelect_Click(object sender, EventArgs e)
        {
            int prcNum = 0;
            if (cboProcessName.SelectedValue != null)
                prcNum = (cboProcessName.SelectedValue.ToString() == "") ? 0 : Convert.ToInt32(cboProcessName.SelectedValue);

            string wpName = txtPlaceName.Text.Trim();

            WorkplaceService service = new WorkplaceService();
            List<WorkplaceVO> list = service.GetWorkplaceInfo(prcNum, wpName);
            dgvWorkplace.DataSource = list;
        }

        //등록버튼
        public override void btn3_Click(object sender, EventArgs e)
        {
            frmWorkplaceReg frm = new frmWorkplaceReg();
            frm.ShowDialog();
        }

        //수정버튼
        //데이터그리드뷰 셀을 선택하고 수정버튼 누를시 or 셀 더블클릭시 => 등록,수정폼에 정보 바인딩 되고 수정 가능하게끔 코딩
        public override void btn2_Click(object sender, EventArgs e)
        {
            //팝업호출
            if (dgvWorkplace.SelectedRows.Count < 1) return;

            var item = dgvWorkplace.SelectedRows[0];

            WorkplaceVO vo = new WorkplaceVO
            {
                WP_Num = Convert.ToInt32(item.Cells["WP_Num"].Value),
                Process_Num = Convert.ToInt32(item.Cells["Process_Num"].Value),
                WP_Name = item.Cells["WP_Name"].Value.ToString(),
                WP_Note = item.Cells["WP_Note"].Value.ToString(),
                WP_Other = item.Cells["WP_Other"].Value.ToString(),
                IsDeleted = item.Cells["IsDeleted"].Value.ToString()
            };

            frmWorkplaceReg frm = new frmWorkplaceReg();
            frm.editWorkSpace = vo;         // ??
            frm.IsEditMode = true;        // ??
            frm.ShowDialog();
        }

        //삭제버튼
        public override void btn1_Click(object sender, EventArgs e)
        {
            if (dgvWorkplace.SelectedRows.Count < 1)
            {
                MessageBox.Show("삭제할 작업장 정보를 선택해주세요.");
                return;
            }

            if (MessageBox.Show($"{dgvWorkplace[1, dgvWorkplace.SelectedRows[0].Index].Value} 번 공정정보를 삭제하시겠습니까?"
                , "삭제확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                WorkplaceService service = new WorkplaceService();
                bool result = service.DeleteWorkplaceInfo(Convert.ToInt32(dgvWorkplace[1, dgvWorkplace.SelectedRows[0].Index].Value));

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
