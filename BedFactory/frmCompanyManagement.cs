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
    public partial class frmCompanyManagement : BedFactory.BaseForms.BaseForm2
    {
        public frmCompanyManagement()
        {
            InitializeComponent();
        }

        private void frmWorkspaceManagement_Load(object sender, EventArgs e)

        {
            dgvComList.SetGridCheckBox("선택");
            dgvComList.SetGridViewColumn("업체번호", "Com_Num");
            dgvComList.SetGridViewColumn("업체코드", "Com_Code", visibility : false);
            dgvComList.SetGridViewColumn("업체구분", "Com_Type");
            dgvComList.SetGridViewColumn("업체이름", "Com_Name");
            dgvComList.SetGridViewColumn("업체대표자", "Com_Represent");
            dgvComList.SetGridViewColumn("담당직원", "Com_Manager");
            dgvComList.SetGridViewColumn("업체주소", "Com_Addr");
            dgvComList.SetGridViewColumn("업체전화번호", "Com_Phone");
            dgvComList.SetGridViewColumn("업체정보", "Com_Info");
            dgvComList.SetGridViewColumn("사용여부", "IsUse");
            dgvComList.SetGridViewColumn("최초등록자", "FirstMan");
            dgvComList.SetGridViewColumn("최초등록일", "Firstdate");
            dgvComList.SetGridViewColumn("최종등록자", "Lastman");
            dgvComList.SetGridViewColumn("최종수정일", "Lastdate");

            if (frmCommonCode.commonList == null) // 항상 널 체크
                frmCommonCode.CheckCommonInfo();  // 널일때만 갖다오기

            CommonUtil.CommonCodeBindig(cboComType_Code, frmCommonCode.commonList, "업체", "");
        }

        //조회버튼
        private void btnSelect_Click(object sender, EventArgs e)
        {
            string comCode = (cboComType_Code.SelectedValue == null) ? "" : cboComType_Code.SelectedValue.ToString();
            string comName = txtComName.Text.Trim();

            CompanyService service = new CompanyService();
            List<CompanyVO> list = service.GetCompanyInfo(comCode, comName);
            dgvComList.DataSource = list;
        }

        //등록버튼
        public override void btn3_Click(object sender, EventArgs e)
        {
            frmCompanyInfoReg frm = new frmCompanyInfoReg();
            frm.ShowDialog();
        }

        //수정버튼
        public override void btn2_Click(object sender, EventArgs e)
        {
            if (dgvComList.SelectedRows.Count < 1) return;

            var item = dgvComList.SelectedRows[0];

            CompanyVO showVO = new CompanyVO
            {
                Com_Num = Convert.ToInt32(item.Cells["Com_Num"].Value.ToString()),
                Com_Code = item.Cells["Com_Code"].Value.ToString(),
                Com_Name = item.Cells["Com_Name"].Value.ToString(),
                Com_Represent = item.Cells["Com_Represent"].Value.ToString(),
                Com_Phone = item.Cells["Com_Phone"].Value.ToString(),
                Com_Manager = Convert.ToInt32(item.Cells["Com_Manager"].Value.ToString()),
                Com_Info = item.Cells["Com_Info"].Value.ToString(),
                IsUse = item.Cells["IsUse"].Value.ToString()
            };

            frmCompanyInfoReg frm = new frmCompanyInfoReg();
            frm.editCompany = showVO;
            frm.IsEditMode = true;
            frm.ShowDialog();
        }



        //삭제버튼
        private void btn1_Click_1(object sender, EventArgs e)
        {
            //삭제

                if (dgvComList.SelectedRows.Count < 1)
                {
                    MessageBox.Show("삭제할 BOR정보를 선택해주세요.");
                    return;
                }

                if (MessageBox.Show($"{dgvComList[1, dgvComList.SelectedRows[0].Index].Value} 번 근무일정을 삭제하시겠습니까?"
                    , "삭제확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                   CompanyService service = new CompanyService();
                    bool result = service.DeleteComInfo(Convert.ToInt32(dgvComList[1, dgvComList.SelectedRows[0].Index].Value));

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
