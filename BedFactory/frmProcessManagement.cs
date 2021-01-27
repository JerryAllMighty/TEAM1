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
  
            dgvProcessInfo.SetGridViewColumn("공정번호", "Process_Num");
            dgvProcessInfo.SetGridViewColumn("공정분류", "Process_Category_Name");
            dgvProcessInfo.SetGridViewColumn("공정명", "Process_Name");
            dgvProcessInfo.SetGridViewColumn("공정조건", "Process_D_Condition");
            dgvProcessInfo.SetGridViewColumn("정보삭제여부", "IsDeleted");
            dgvProcessInfo.SetGridViewColumn("최초등록자", "Firstman");
            dgvProcessInfo.SetGridViewColumn("최초등록일", "Firstdate");
            dgvProcessInfo.SetGridViewColumn("최종등록자", "Lastman");
            dgvProcessInfo.SetGridViewColumn("최종수정일", "Lastdate");

            //콤보박스 바인딩

        }


        //조회버튼
        public void btnSelect_Click(object sender, EventArgs e)
        {
            string prcCategory = cboCategory.SelectedValue.ToString();
            string prcName = txtName.Text.Trim();

            ProcessService service = new ProcessService();
            List<ProcessVO> list = service.GetProcessInfo(prcCategory, prcName);
            dgvProcessInfo.DataSource = list;
        }


        // 등록버튼
        public override void btn2_Click(object sender, EventArgs e)
        {
            //팝업호출
            frmProcessReg frm = new frmProcessReg();
            frm.ShowDialog();
        }


        // 수정버튼
        public override void btn3_Click(object sender, EventArgs e)
        {
            //팝업호출
        }


        // 삭제버튼
        public override void btn1_Click(object sender, EventArgs e)
        {

        }

    }
}
