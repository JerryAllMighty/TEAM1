using BedFactory.BaseForms;
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
            dgvWO.SetGridViewColumn("창고번호", "Str_Num");
            dgvWO.SetGridViewColumn("창고유형", "Str_Kind");
            dgvWO.SetGridViewColumn("자재번호", "Mat_Num", visibility: false);
            dgvWO.SetGridViewColumn("자재명", "Mat_Name");
            dgvWO.SetGridViewColumn("자재유형", "Mat_Category");
            dgvWO.SetGridViewColumn("재고량", "Mat_Cnt");

            Point point = dgvWO.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheck.Location = new Point(point.X + 8, point.Y + 2);
            headerCheck.BackColor = Color.Transparent;
            headerCheck.Size = new Size(18, 18);
            headerCheck.Click += HeaderCheck_Click; ;
            dgvWO.Controls.Add(headerCheck);
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
            
        }
    }
}
