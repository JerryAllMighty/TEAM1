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
    public partial class frmMaterialLedgerRawMaterial : BaseForm2
    {
        List<ShipmentVO> list;
        CheckBox headerCheck = new CheckBox();

        DateTime bFrom = DateTime.Parse("9999-12-30");
        DateTime bTo = DateTime.Parse("9999-12-30");

        public frmMaterialLedgerRawMaterial()
        {
            InitializeComponent();

            btn1.Visible = btn2.Visible = btn4.Visible = btn5.Visible = false;

            dgvWO.SetGridCheckBox("chk");
            dgvWO.SetGridViewColumn("출고번호", "Ship_D_Num", visibility: false);
            dgvWO.SetGridViewColumn("작업지시서", "WO_Num");
            dgvWO.SetGridViewColumn("요청일", "Firstdate");
            dgvWO.SetGridViewColumn("자재명", "Mat_Name", 150);
            dgvWO.SetGridViewColumn("자재유형", "Mat_Category");
            dgvWO.SetGridViewColumn("창고유형", "Str_Kind");
            dgvWO.SetGridViewColumn("요청수량", "Ship_Cnt");

            Point point = dgvWO.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheck.Location = new Point(point.X + 8, point.Y + 2);
            headerCheck.BackColor = Color.Transparent;
            headerCheck.Size = new Size(18, 18);
            headerCheck.Click += HeaderCheck_Click; ;
            dgvWO.Controls.Add(headerCheck);

            dtpTo.MinDate = dtpFrom.Value.AddDays(-7);

            DataLoad();
        }

        private void HeaderCheck_Click(object sender, EventArgs e)
        {
            dgvWO.EndEdit();

            foreach (DataGridViewRow row in dgvWO.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chk"];
                chk.Value = headerCheck.Checked;
            }
        }

        private void DataLoad()
        {
            ShipmentService service = new ShipmentService();
            list = service.AutoShipLoad(dtpFrom.Value.Date, dtpTo.Value.Date);
            dgvWO.DataSource = list;

            List<string> temp = list.GroupBy(p => p.WO_Num).Select(p => p.Key.ToString()).ToList();
            temp.Insert(0, "전체");
            cboWO.DisplayMember = "WO_Num";
            cboWO.DataSource = temp;

            List<string> item = list.GroupBy(p => p.Mat_Category).Select(p => p.Key.ToString()).ToList();
            item.Insert(0, "전체");
            cboM_Category.DisplayMember = "Mat_Category";
            cboM_Category.DataSource = temp;
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpTo.MinDate = dtpFrom.Value;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (bFrom.Date != dtpFrom.Value.Date || bTo.Date != dtpTo.Value.Date)
                DataLoad();

            var item = (from temp in list
                        where (cboWO.SelectedIndex == 0 ? true : temp.WO_Num.ToString() == cboWO.Text)
                              && (cboM_Category.SelectedIndex == 0 ? true : temp.Mat_Category == cboM_Category.Text)
                        select temp).ToList();

            dgvWO.DataSource = item;
        }

        private void btn3_Click_1(object sender, EventArgs e) //출고
        {
            bool isChange = false;

            foreach (DataGridViewRow row in dgvWO.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chk"];
                if (Convert.ToBoolean(chk.Value) == true)
                {
                    ShipmentService service = new ShipmentService();
                    service.ShipmentFinish(dgvWO[1, row.Index].Value.ToString());

                    isChange = true;
                }
            }

            if (isChange)
                DataLoad();

            headerCheck.Checked = false;
        }

        private void dgvWO_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgvWO.CurrentCell is DataGridViewCheckBoxCell)
            {
                dgvWO.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}
