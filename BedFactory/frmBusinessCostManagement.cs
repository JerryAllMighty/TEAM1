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
        List<UnitCostVO> list;

        public frmBusinessCostManagement()
        {
            InitializeComponent();

            this.category = "주문";
            label1.Text = "영업단가관리";
            this.Text = "영업단가관리";
        }

        public frmBusinessCostManagement(string category)
        {
            InitializeComponent();

            if (category.Equals("영업"))
            {
                this.category = "주문";
                label1.Text = "영업단가관리";
                this.Text = "영업단가관리";
            }
            else
            {
                this.category = "발주";
                label1.Text = "자재단가관리";
                this.Text = "자재단가관리";
            }
        }

        private void DataLoad()
        {
            UnitCostService service = new UnitCostService();
            list = service.UnitCostSelect(category, dtpDate.Value.Date);
            dgvCost.DataSource = list;

            List<string> temp = list.GroupBy(p => p.Com_Name).Select(p => p.Key.ToString()).ToList();
            temp.Insert(0, "전체");
            cboCompany.DisplayMember = "Com_Name";
            cboCompany.DataSource = temp;
        }

        private void frmBusinessCostManagement_Load(object sender, EventArgs e)
        {
            dgvCost.SetGridViewColumn("단가번호", "UnitCost_Num", visibility: false);
            dgvCost.SetGridViewColumn("No.", "RowNum");
            dgvCost.SetGridViewColumn("거래처번호", "Com_Num");
            dgvCost.SetGridViewColumn("거래처명", "Com_Name");
            dgvCost.SetGridViewColumn("자재번호", "Mat_Num");
            dgvCost.SetGridViewColumn("자재명", "Mat_Name");
            dgvCost.SetGridViewColumn("자재유형", "Mat_Category");
            dgvCost.SetGridViewColumn("현재단가", "Now_UnitCost");
            dgvCost.SetGridViewColumn("이전단가", "Before_UnitCost");
            dgvCost.SetGridViewColumn("시작일", "Start_Date");
            dgvCost.SetGridViewColumn("종료일", "End_Date");

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
                Com_Name = dgvCost[3, dgvCost.SelectedRows[0].Index].Value.ToString(),
                Mat_Num = dgvCost[4, dgvCost.SelectedRows[0].Index].Value.ToString(),
                Now_UnitCost = Convert.ToInt32(dgvCost[7, dgvCost.SelectedRows[0].Index].Value),
                Before_UnitCost = Convert.ToInt32(dgvCost[8, dgvCost.SelectedRows[0].Index].Value),
                Start_Date = Convert.ToDateTime(dgvCost[9, dgvCost.SelectedRows[0].Index].Value),
                End_Date = Convert.ToDateTime(dgvCost[10, dgvCost.SelectedRows[0].Index].Value),
                LastMan = id,
                LastDate = DateTime.Now.Date
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
                Com_Name = dgvCost[3, dgvCost.SelectedRows[0].Index].Value.ToString(),
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

            var item = (from temp in list
                        where (cboCompany.SelectedIndex == 0 ? true : temp.Com_Name == cboCompany.Text)
                              && (txtMaterial.Text.Length < 1 ? true : temp.Mat_Name.Contains(txtMaterial.Text))
                        select temp).ToList();

            dgvCost.DataSource = item;
        }

        private void btn3_Click_1(object sender, EventArgs e) //삭제
        {
            if(MessageBox.Show($"{dgvCost[1, dgvCost.SelectedRows[0].Index].Value} 번 단가정보를 삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                UnitCostService service = new UnitCostService();
                if(service.UnitCostDelete(Convert.ToInt32(dgvCost[0, dgvCost.SelectedRows[0].Index].Value)))
                {
                    MessageBox.Show(Properties.Settings.Default.DeleteSuccess);
                    DataLoad();
                }
                else
                {
                    MessageBox.Show(Properties.Settings.Default.DeleteFail);
                }
            }
        }
    }
}
