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
    public partial class frmProductionPlan : Form
    {
        public frmProductionPlan()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 그리드 뷰 셋팅
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmProductionPlan_Load(object sender, EventArgs e)
        {
            dgvproductionPlan.SetGridViewColumn("생산 계획 상세 번호", "");
            dgvproductionPlan.SetGridViewColumn("생산 수량", "");
            dgvproductionPlan.SetGridViewColumn("작업장명", "");
            dgvproductionPlan.SetGridViewColumn("생산 날짜", "");

        }
    }
}
