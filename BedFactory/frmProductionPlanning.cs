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
    public partial class frmProductionPlanning : BedFactory.BaseForms.BaseForm2
    {
        public ProductionPlanVO productionplaninfo {
            get {
                return new ProductionPlanVO
                {
                    Demand_Plan_Num = cboDemandPlanNum.Text,
                    WP_Num = cboWorkPlace.Text
                };
            }
        
        }
        public frmProductionPlanning()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 데이터 그리드 뷰 세팅
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmProductionPlanning_Load(object sender, EventArgs e)
        {
            dgvProductionPlan.SetGridViewColumn("수요 계획 번호", "Demand_Plan_Num");
            dgvProductionPlan.SetGridViewColumn("생산 계획 번호", "ProductionPlan_Num");
            dgvProductionPlan.SetGridViewColumn("생산 계획 상세 번호", "ProductionPlan_D_Num");
            dgvProductionPlan.SetGridViewColumn("생산 날짜", "ProductionDate");
            dgvProductionPlan.SetGridViewColumn("생산량", "ProductionCnt");
            dgvProductionPlan.SetGridViewColumn("작업장번호", "WP_Num");
            dgvProductionPlan.SetGridViewColumn("제작 물품 번호", "Mat_Num");
        }


        /// <summary>
        /// 원하는 내용을 그리드 뷰에 바인딩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            ProductionPlanService service = new ProductionPlanService();
            List<ProductionPlanVO> list = service.GetProductionPlanInfo(productionplaninfo, dtpUploadDate.Value.ToString("yyyy-MM-dd"));
            if (list != null)
            {
                dgvProductionPlan.DataSource = list;
            }

        }
    }
}
