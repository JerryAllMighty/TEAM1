using BedFactory.BaseForms;
using BedFactory.Pop_up;
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
    public partial class frmBusinessCostManagement : BaseForm2
    {
        int id = 0;
        string category = string.Empty;

        public frmBusinessCostManagement()
        {
            InitializeComponent();
        }

        public frmBusinessCostManagement(string category)
        {
            InitializeComponent();

            if (category.Equals("영업"))
            {
                this.category = "주문업체";
                label1.Text = "영업단가관리";
                this.Text = "영업단가관리";
            }
            else
            {
                this.category = "발주업체";
                label1.Text = "자재단가관리";
                this.Text = "자재단가관리";
            }
        }

        private void DataLoad()
        {
            UnitCostService service = new UnitCostService();
            dgvCost.DataSource = service.UnitCostSelect(category, dtpDate.Value.Date);
        }

        private void frmBusinessCostManagement_Load(object sender, EventArgs e)
        {
            dgvCost.SetGridViewColumn("단가번호", "UnitCost_Num", visibility: false);
            dgvCost.SetGridViewColumn("No.", "RowNum");
            dgvCost.SetGridViewColumn("거래처번호", "Com_Num");
            dgvCost.SetGridViewColumn("거래처명", "Com_Name");
            dgvCost.SetGridViewColumn("자재번호", "Mat_Num");
            dgvCost.SetGridViewColumn("자재명", "Mat_Name");
            dgvCost.SetGridViewColumn("현재단가", "Now_UnitCost");
            dgvCost.SetGridViewColumn("이전단가", "Before_UnitCost");
            dgvCost.SetGridViewColumn("시작일", "Start_Date");
            dgvCost.SetGridViewColumn("종료일", "End_Date");
            dgvCost.SetGridViewColumn("최초등록자", "FirstMan");
            dgvCost.SetGridViewColumn("최초등록일", "FirstDate");
            dgvCost.SetGridViewColumn("최종등록자", "LastMan");
            dgvCost.SetGridViewColumn("최종등록일", "LastDate");

            DataLoad();
        }

        private void btn2_Click(object sender, EventArgs e) //등록
        {
            frmMaterials frm = new frmMaterials(id, this.Text, "등록", null);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DataLoad();
            }
        }

        private void button7_Click(object sender, EventArgs e) //수정
        {
            UnitCostVO vo = new UnitCostVO
            {
                UnitCost_Num = Convert.ToInt32(dgvCost[0, dgvCost.SelectedRows[0].Index].Value),
                Com_Num = Convert.ToInt32(dgvCost[2, dgvCost.SelectedRows[0].Index].Value),
                Mat_Num = dgvCost[4, dgvCost.SelectedRows[0].Index].Value.ToString(),
                Now_UnitCost = Convert.ToInt32(dgvCost[6, dgvCost.SelectedRows[0].Index].Value),
                Before_UnitCost = Convert.ToInt32(dgvCost[7, dgvCost.SelectedRows[0].Index].Value),
                Start_Date = Convert.ToDateTime(dgvCost[8, dgvCost.SelectedRows[0].Index].Value),
                End_Date = Convert.ToDateTime(dgvCost[9, dgvCost.SelectedRows[0].Index].Value)
            };

            frmMaterials frm = new frmMaterials(id, this.Text, "수정", vo);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DataLoad();
            }
        }

        private void btn1_Click(object sender, EventArgs e) //복사
        {
            UnitCostVO vo = new UnitCostVO
            {
                Com_Num = Convert.ToInt32(dgvCost[2, dgvCost.SelectedRows[0].Index].Value),
                Mat_Num = dgvCost[4, dgvCost.SelectedRows[0].Index].Value.ToString(),
                Now_UnitCost = Convert.ToInt32(dgvCost[6, dgvCost.SelectedRows[0].Index].Value),
                Before_UnitCost = Convert.ToInt32(dgvCost[7, dgvCost.SelectedRows[0].Index].Value),
                Start_Date = Convert.ToDateTime(dgvCost[8, dgvCost.SelectedRows[0].Index].Value),
                End_Date = Convert.ToDateTime(dgvCost[9, dgvCost.SelectedRows[0].Index].Value)
            };

            frmMaterials frm = new frmMaterials(id, this.Text, "복사", vo);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DataLoad();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataLoad();
        }
    }
}
