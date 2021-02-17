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
    public partial class frmMaterialRequirementPlanning : BedFactory.BaseForms.BaseForm2
    {
        public frmMaterialRequirementPlanning()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 필요정보 검색
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            MRPService service = new MRPService();
            List<MRPVO> list = service.GetMRPInfo(dtpDeadLine.Value.ToString("yyyy-MM-dd"), cboDemandPlan.Text, cboSubjectName.Text);
            if (list != null)
            {
                dgvMRP.DataSource = list;
            }
        }

        /// <summary>
        /// 데이터 그리드 뷰 세팅
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMaterialRequirementPlanning_Load(object sender, EventArgs e)
        {
            dgvMRP.SetGridViewColumn("자재계획번호", "MatarialUsePlan_Num");
            dgvMRP.SetGridViewColumn("수요계획번호", "Demand_Plan_Num");
            dgvMRP.SetGridViewColumn("자재번호", "Mat_Num");
            dgvMRP.SetGridViewColumn("자재명", "Mat_Name");
            dgvMRP.SetGridViewColumn("소요량", "MaterialUse_Cnt");
            dgvMRP.SetGridViewColumn("최초등록자", "Firstman");
            dgvMRP.SetGridViewColumn("최초등록일", "Firstdate");
            dgvMRP.SetGridViewColumn("최종등록자", "Lastman");
            dgvMRP.SetGridViewColumn("최종등록일", "Lastdate");
            
        }
    }
}
