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
    public partial class frmProcessManagement : BedFactory.BaseForms.BaseForm2
    {
        public frmProcessManagement()
        {
            InitializeComponent();
        }

        private void frmFacilitiesManagement_Load(object sender, EventArgs e)
        {
            //컬럼추가
            //그리드뷰 바인딩
            dgvProcessInfo.SetGridCheckBox("선택");
            dgvProcessInfo.SetGridViewColumn("공정번호", "Process_Num");
            dgvProcessInfo.SetGridViewColumn("공정코드", "Process_Code");
            dgvProcessInfo.SetGridViewColumn("공정분류", "Process_Category");
            dgvProcessInfo.SetGridViewColumn("상세공정명", "Process_Name_D");
            dgvProcessInfo.SetGridViewColumn("공정조건", "Process_Condition");
            dgvProcessInfo.SetGridViewColumn("사용여부", "IsDeleted");
            dgvProcessInfo.SetGridViewColumn("최초등록자", "Firstman");
            dgvProcessInfo.SetGridViewColumn("최초등록일", "Firstdate");
            dgvProcessInfo.SetGridViewColumn("최종등록자", "Lastman");
            dgvProcessInfo.SetGridViewColumn("최종수정일", "Lastdate");
            dgvProcessInfo.SetGridViewColumn("공정분류ID", "Process_Category", visibility: false);

            //콤보박스 바인딩(공통코드)  : 예시
            if (frmCommonCode.commonList == null) // 항상 널 체크
                frmCommonCode.CheckCommonInfo();  // 널일때만 갖다오기

            CommonUtil.CommonCodeBindig(cboCategory_Code, frmCommonCode.commonList, "공정", "");
        }



        //조회버튼
        private void btnSelect_Click_1(object sender, EventArgs e)
        {
            string prcCode = (cboCategory_Code.SelectedValue == null) ? "" : cboCategory_Code.SelectedValue.ToString();

            string prcName = txtName.Text.Trim();

            ProcessService service = new ProcessService();
            List<ProcessVO> list = service.GetProcessInfo(prcCode, prcName);
            dgvProcessInfo.DataSource = list;
        }


        // 등록버튼
        public override void btn3_Click(object sender, EventArgs e)
        {
            // 팝업호출
            frmProcessReg frm = new frmProcessReg();
            frm.ShowDialog();
        }


        // 수정버튼
        // 데이터그리드뷰 셀을 선택하고 수정버튼 누를시 or 셀 더블클릭시 => 등록,수정폼에 정보 바인딩 되고 수정 가능하게끔 코딩
        public override void btn2_Click(object sender, EventArgs e)
        {
            //팝업호출
            if (dgvProcessInfo.SelectedRows.Count < 1) return;

            var item = dgvProcessInfo.SelectedRows[0];

            ProcessVO vo = new ProcessVO
            {
                Process_Num = Convert.ToInt32(item.Cells["Process_Num"].Value.ToString()),
                Process_Code = item.Cells["Process_Code"].Value.ToString(),
                Process_Name_D = item.Cells["Process_Name_D"].Value.ToString(),
                Process_Condition = item.Cells["Process_Condition"].Value.ToString(),
                IsDeleted = item.Cells["IsDeleted"].Value.ToString()
            };

            frmProcessReg frm = new frmProcessReg();
            frm.EditProcess = vo;
            frm.IsEditMode = true;
            frm.ShowDialog();
        }


        // 삭제버튼
        public override void btn1_Click(object sender, EventArgs e)
        {
            if (dgvProcessInfo.SelectedRows.Count < 1)
            {
                MessageBox.Show("삭제할 공정정보를 선택해주세요.");
                return;
            }

            if (MessageBox.Show($"{dgvProcessInfo[1, dgvProcessInfo.SelectedRows[0].Index].Value} 번 공정정보를 삭제하시겠습니까?"
                , "삭제확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ProcessService service = new ProcessService();
                bool result = service.DeleteProcessInfo(Convert.ToInt32(dgvProcessInfo[1, dgvProcessInfo.SelectedRows[0].Index].Value));

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
