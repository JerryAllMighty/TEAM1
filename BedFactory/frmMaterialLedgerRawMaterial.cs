using BedFactory.BaseForms;
using BedFactoryService;
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
        CheckBox headerCheck = new CheckBox();

        public frmMaterialLedgerRawMaterial()
        {
            InitializeComponent();

            dgvWO.SetGridCheckBox("chkBalzoo");
            dgvWO.SetGridViewColumn("출고번호", "Ship_D_Num", visibility: false);
            dgvWO.SetGridViewColumn("작업지시서", "WO_D_Num");
            dgvWO.SetGridViewColumn("요청일", "Firstdate");
            dgvWO.SetGridViewColumn("자재명", "Mat_Name");
            dgvWO.SetGridViewColumn("자재유형", "Mat_Category");
            dgvWO.SetGridViewColumn("창고", "Str_Num");
            dgvWO.SetGridViewColumn("요청수량", "Ship_Cnt");

            Point point = dgvWO.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheck.Location = new Point(point.X + 8, point.Y + 2);
            headerCheck.BackColor = Color.Transparent;
            headerCheck.Size = new Size(18, 18);
            headerCheck.Click += HeaderCheck_Click; ;
            dgvWO.Controls.Add(headerCheck);

            dtpTo.MinDate = dtpFrom.Value.AddDays(-7);
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
            dgvWO.DataSource = service.AutoShipLoad(dtpFrom.Value.Date, dtpTo.Value.Date);
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            DataLoad();
            dtpTo.MinDate = dtpFrom.Value;
        }
    }
}
