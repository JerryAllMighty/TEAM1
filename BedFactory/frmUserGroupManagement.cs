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
    public partial class frmUserGroupManagement : Form
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
            datagridviewControl1.SetGridViewColumn("직원ID", "Emp_ID");
            datagridviewControl1.SetGridViewColumn("직원명", "Emp_Name");

            //사용자 그룹 목록 세팅
            datagridviewControl2.SetGridViewColumn("그룹코드", "Code_Num");
            datagridviewControl2.SetGridViewColumn("그룹명", "Code_Name");

            //그룹별 직원 리스트 세팅
            datagridviewControl3.SetGridCheckBox("ModifyGroup");
            datagridviewControl3.SetGridViewColumn("직원ID", "Emp_ID");
            datagridviewControl3.SetGridViewColumn("직원명", "Emp_Name");
        }
    }
}
