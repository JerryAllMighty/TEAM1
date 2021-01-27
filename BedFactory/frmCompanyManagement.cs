using BedFactory.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            CommonUtil.SetInitGridView(dgvComList);
            CommonUtil.AddGridTextColumn(dgvComList, "거래처번호", "Process_Num");
            CommonUtil.AddGridTextColumn(dgvComList, "거래처이름", "Process_Name");
            CommonUtil.AddGridTextColumn(dgvComList, "거래처구분", "Process_D_Num");
            CommonUtil.AddGridTextColumn(dgvComList, "공정상세명", "Process_D_Name");
            CommonUtil.AddGridTextColumn(dgvComList, "거래처담당직원", "Firstman");
            CommonUtil.AddGridTextColumn(dgvComList, "최초등록자", "FirstMan");
            CommonUtil.AddGridTextColumn(dgvComList, "최초등록일", "Firstdate");
            CommonUtil.AddGridTextColumn(dgvComList, "최종등록자", "Lastman");
            CommonUtil.AddGridTextColumn(dgvComList, "최종수정일", "Lastdate");


        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            
        }
    }
}
