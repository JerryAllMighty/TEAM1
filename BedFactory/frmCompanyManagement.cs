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
            dgvComList.SetGridViewColumn("거래처번호", "Process_Num");
            dgvComList.SetGridViewColumn("거래처이름", "Process_Name");
            dgvComList.SetGridViewColumn("거래처구분", "Process_D_Num");
            dgvComList.SetGridViewColumn("공정상세명", "Process_D_Name");
            dgvComList.SetGridViewColumn("거래처담당직원", "Firstman");
            dgvComList.SetGridViewColumn("최초등록자", "FirstMan");
            dgvComList.SetGridViewColumn("최초등록일", "Firstdate");
            dgvComList.SetGridViewColumn("최종등록자", "Lastman");
            dgvComList.SetGridViewColumn("최종수정일", "Lastdate");


        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            
        }
    }
}
