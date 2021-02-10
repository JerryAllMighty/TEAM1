using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BedFactory
{
    public partial class frmUserGroupManagement : BedFactory.BaseForms.BaseForm2
    {
        public frmUserGroupManagement()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 폼이 로드될 때, 데이터그리드뷰들 컬럼 세팅
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmUserGroupManagement_Load(object sender, EventArgs e)
        {
            //사용자 목록 세팅
            dgvUserList.SetGridViewColumn("직원ID", "Emp_ID");
            dgvUserList.SetGridViewColumn("직원명", "Emp_Name");

            //사용자 그룹 목록 세팅
            dgvUserGroupList.SetGridViewColumn("그룹코드", "Code_Num");
            dgvUserGroupList.SetGridViewColumn("그룹명", "Code_Name");

            //그룹별 직원 리스트 세팅
            dgvGroupEmpList.SetGridCheckBox("ModifyGroup");
            dgvGroupEmpList.SetGridViewColumn("직원ID", "Emp_ID");
            dgvGroupEmpList.SetGridViewColumn("직원명", "Emp_Name");
        }


        /// <summary>
        /// 저장 버튼 클릭시 변경 내용 저장
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1_Click_1(object sender, EventArgs e)
        {

        }

     
    }
}
