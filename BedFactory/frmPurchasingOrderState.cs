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
    public partial class frmPurchasingOrderState : BaseForm2
    {
        CheckBox headerCheck = new CheckBox();

        public frmPurchasingOrderState()
        {
            InitializeComponent();
        }

        private void frmPurchasingOrderState_Load(object sender, EventArgs e)
        {
            dgvOrder.SetGridCheckBox("chkBalzoo");
            dgvOrder.SetGridViewColumn("발주번호", "Bz_D_Num");
            dgvOrder.SetGridViewColumn("거래처명", "Com_Name");
            dgvOrder.SetGridViewColumn("자재명", "Mat_Name");
            dgvOrder.SetGridViewColumn("발주수량", "Bz_Cnt");
            dgvOrder.SetGridViewColumn("발주상태", "Bz_D_Status");
            dgvOrder.SetGridViewColumn("예상납기일", "ExpectedDate");

            Point point = dgvOrder.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheck.Location = new Point(point.X + 8, point.Y + 2);
            headerCheck.BackColor = Color.Transparent;
            headerCheck.Size = new Size(18, 18);
            headerCheck.Click += HeaderCheck_Click; ;
            dgvOrder.Controls.Add(headerCheck);

            dtpTo.MinDate = dtpFrom.Value.AddDays(-7);
        }

        private void HeaderCheck_Click(object sender, EventArgs e)
        {
            dgvOrder.EndEdit();

            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chk"];
                chk.Value = headerCheck.Checked;
            }
        }

        private void DataLoad()
        {
            BalzooService service = new BalzooService();
            dgvOrder.DataSource = service.BalzooSelect(dtpFrom.Value, dtpTo.Value);
        }

        /// <summary>
        /// DataGridView 내부 checkBox 사용시, check 상태 반영 안되는 경우를 막기위한 코드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvOrder_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvOrder.CurrentCell is DataGridViewCheckBoxCell)
            {
                dgvOrder.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                bool bCheck = false;

                for (int i = 0; i < dgvOrder.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dgvOrder[0, i].Value))
                    {
                        bCheck = true;
                        break;
                    }
                }

                if (bCheck)
                    headerCheck.Checked = true;
                else
                    headerCheck.Checked = false;
            }
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            DataLoad();
            dtpTo.MinDate = dtpFrom.Value;
        }
    }
}
