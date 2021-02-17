using BedFactory.BaseForms;
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
    public partial class frmStockWOState : BaseForm2
    {
        List<WearingVO> list;

        DateTime bFrom = DateTime.Parse("9999-12-30");
        DateTime bTo = DateTime.Parse("9999-12-30");

        public frmStockWOState()
        {
            InitializeComponent();
        }

        private void frmStockWOState_Load(object sender, EventArgs e)
        {
            btn1.Visible = btn2.Visible = btn3.Visible = btn4.Visible = btn5.Visible = false;

            dgvWO.SetGridViewColumn("입출고일", "FirstDate");
            dgvWO.SetGridViewColumn("구분", "Category");
            dgvWO.SetGridViewColumn("카테고리", "W_Category");
            dgvWO.SetGridViewColumn("창고유형", "Str_Kind");
            dgvWO.SetGridViewColumn("자재명", "Mat_Name");
            dgvWO.SetGridViewColumn("자재분류", "Mat_Category");
            dgvWO.SetGridViewColumn("수불량", "Mat_Cnt");

            dtpTo.MinDate = dtpFrom.Value.AddDays(-7);
            dtpFrom.Value = DateTime.Now.AddDays(-7);

            DataLoad();
        }

        private void DataLoad()
        {
            WearingService service = new WearingService();
            list = service.WOState(dtpFrom.Value.Date, dtpTo.Value.Date);
            dgvWO.DataSource = list;

            List<string> temp = list.GroupBy(p => p.Str_Kind).Select(p => p.Key.ToString()).ToList();
            temp.Insert(0, "전체");
            cboStorage.DisplayMember = "Str_Kind";
            cboStorage.DataSource = temp;

            temp = list.GroupBy(p => p.Category).Select(p => p.Key.ToString()).ToList();
            temp.Insert(0, "전체");
            cboWOcategory.DisplayMember = "Category";
            cboWOcategory.DataSource = temp;

            temp = list.GroupBy(p => p.W_Category).Select(p => p.Key.ToString()).ToList();
            temp.Insert(0, "전체");
            cboCategory.DisplayMember = "W_Category";
            cboCategory.DataSource = temp;

            temp = list.GroupBy(p => p.Mat_Category).Select(p => p.Key.ToString()).ToList();
            temp.Insert(0, "전체");
            cboMcategory.DisplayMember = "Mat_Category";
            cboMcategory.DataSource = temp;

            bFrom = dtpFrom.Value.Date;
            bTo = dtpTo.Value.Date;
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {            
            dtpTo.MinDate = dtpFrom.Value;
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            if (bFrom.Date != dtpFrom.Value.Date && bTo.Date != dtpTo.Value.Date)
                DataLoad();

            var item = (from temp in list
                        where (cboStorage.SelectedIndex == 0 ? true : temp.Str_Kind == cboStorage.Text)
                              && (cboWOcategory.SelectedIndex == 0 ? true : temp.Category == cboWOcategory.Text)
                              && (cboCategory.SelectedIndex == 0 ? true : temp.W_Category == cboCategory.Text)
                              && (cboMcategory.SelectedIndex == 0 ? true : temp.Mat_Category == cboMcategory.Text)
                              && (txtMaterial.Text.Length < 1 ? true : temp.Mat_Name.Contains(txtMaterial.Text))
                        select temp).ToList();

            dgvWO.DataSource = item;
        }
    }
}
