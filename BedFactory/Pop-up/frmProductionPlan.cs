using BedFactoryService;
using BedFactoryVO;
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
            dgvproductionPlan.SetGridViewColumn("작업장명", "WP_Name");
            dgvproductionPlan.SetGridViewColumn("생산 수량", "ProductionCnt");
            dgvproductionPlan.SetGridViewColumn("생산 날짜", "ProductionDate");

        }

        /// <summary>
        /// 영업마스터 번호로 정보 가져오는 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            SalesMasterService service = new SalesMasterService();
            service.GetSalesMasterBySalesMasterNum(txtSalesMaster_Num.Text);
        }
    }
}
