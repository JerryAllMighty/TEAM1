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
using BedFactory.Pop_up;

namespace BedFactory
{
    public partial class frmWorkOrdersCreate : BedFactory.BaseForms.BaseForm2
    {

        CheckBox headerCheck = new CheckBox();
        List<ProductionPlanVO> pplist;
        public frmWorkOrdersCreate()
        {
            InitializeComponent();
        }

        private void frmWorkOrderCreate_Load(object sender, EventArgs e)
        {
            //dgvWOC.SetGridCheckBox("");
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "";
            chk.Name = "chk";
            chk.Width = 30;
            dgvWOC.Columns.Add(chk);

            dgvWOC.SetGridViewColumn("생산 계획 번호", "ProductionPlan_Num");
            dgvWOC.SetGridViewColumn("생산 계획 상세 번호", "ProductionPlan_D_Num");
            dgvWOC.SetGridViewColumn("생산 날짜", "ProductionDate");
            dgvWOC.SetGridViewColumn("생산량", "ProductionCnt");
            dgvWOC.SetGridViewColumn("작업장번호", "WP_Num");
            dgvWOC.SetGridViewColumn("제작 물품 번호", "Mat_Num");
            dgvWOC.SetGridViewColumn("제작 물품 명", "Mat_Name");


            Point point = dgvWOC.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheck.Location = new Point(point.X + 8, point.Y + 2);
            headerCheck.BackColor = Color.Transparent;
            headerCheck.Size = new Size(18, 18);
            headerCheck.Click += HeaderCheck_Click; ;
            dgvWOC.Controls.Add(headerCheck);

        }

        //전체체크/해제
        private void HeaderCheck_Click(object sender, EventArgs e) 
        {
            dgvWOC.EndEdit();

            foreach (DataGridViewRow row in dgvWOC.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chk"];
                chk.Value = headerCheck.Checked;
            }
        }



        //조회
        private void btnSelect_Click(object sender, EventArgs e)
        {
            string dtFrom = dtpFrom.Value.ToShortDateString();


            ProductionPlanService service = new ProductionPlanService();
            pplist = service.GetProductionPlanDetail(dtpFrom.Value.ToShortDateString(), txtProductionPlanNum.Text);
            dgvWOC.DataSource = pplist;
        }


      

        /// <summary>
        /// 작업 지시 등록
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2_Click_1(object sender, EventArgs e)
        {
            frmWorkOrdersCreatePOPUP frm = new frmWorkOrdersCreatePOPUP(dgvWOC.CurrentRow.DataBoundItem as ProductionPlanVO);
            frm.ShowDialog();
        }
    }
}
