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
    public partial class frmCompanyManagement : BedFactory.BaseForms.BaseForm1
    {
        public frmCompanyManagement()
        {
            InitializeComponent();
        }

        private void frmFacilitiesManagement_Load(object sender, EventArgs e)
        {
            //컬럼추가
            //그리드뷰 바인딩
           dvgProcessInfo.SetGridViewColumn( "공정번호", "Process_Num");
           dvgProcessInfo.SetGridViewColumn( "공정명", "Process_Name");
           dvgProcessInfo.SetGridViewColumn( "공정상세번호", "Process_D_Num");
           dvgProcessInfo.SetGridViewColumn( "공정상세명", "Process_D_Name");
           dvgProcessInfo.SetGridViewColumn( "최초등록자", "Firstman");
           dvgProcessInfo.SetGridViewColumn( "최초등록일", "Firstdate");
           dvgProcessInfo.SetGridViewColumn( "최종등록자", "Lastman");
           dvgProcessInfo.SetGridViewColumn( "최종수정일", "Lastdate");
           dvgProcessInfo.SetGridViewColumn( "공정조건", "Process_D_Condition");
           dvgProcessInfo.SetGridViewColumn( "정보삭제여부", "IsDeleted");


            //콤보박스 바인딩
        }


        //조회버튼
        public override void btnSelect_Click(object sender, EventArgs e)
        {
            string prcName = ""; //cboName.SelectedValue.ToString();
            string prcName_D = "";

            ProcessService service = new ProcessService();
            List<ProcessDetailVO> list = service.GetProcessDetailInfo(prcName, prcName_D);
            dvgProcessInfo.DataSource = list;
        }


        // 등록버튼
        private void btn2_Click(object sender, EventArgs e)
        {

        }

        // 삭제버튼
        private void btn1_Click(object sender, EventArgs e)
        {

        }
    }
}
