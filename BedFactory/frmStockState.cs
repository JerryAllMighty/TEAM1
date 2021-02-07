using BedFactory.BaseForms;
using BedFactory.Pop_up;
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
    public partial class frmStockState : BaseForm2
    {
        CheckBox headerCheck = new CheckBox();

        public frmStockState()
        {
            InitializeComponent();
        }

        private void frmStockState_Load(object sender, EventArgs e)
        {
            dgvStock.SetGridCheckBox("chkBalzoo");
            dgvStock.SetGridViewColumn("창고번호", "Str_Num");
            dgvStock.SetGridViewColumn("창고유형", "Str_Kind");
            dgvStock.SetGridViewColumn("자재번호", "Mat_Num", visibility:false);
            dgvStock.SetGridViewColumn("자재명", "Mat_Name");
            dgvStock.SetGridViewColumn("자재유형", "Mat_Category");
            dgvStock.SetGridViewColumn("재고량", "Mat_Cnt");

            Point point = dgvStock.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheck.Location = new Point(point.X + 8, point.Y + 2);
            headerCheck.BackColor = Color.Transparent;
            headerCheck.Size = new Size(18, 18);
            headerCheck.Click += HeaderCheck_Click; ;
            dgvStock.Controls.Add(headerCheck);

            DataLoad();
        }

        private void HeaderCheck_Click(object sender, EventArgs e)
        {
            dgvStock.EndEdit();

            foreach (DataGridViewRow row in dgvStock.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chk"];
                chk.Value = headerCheck.Checked;
            }
        }

        private void DataLoad()
        {
            WearingService service = new WearingService();
            dgvStock.DataSource = service.StockState();
        }

        /// <summary>
        /// DataGridView 내부 checkBox 사용시, check 상태 반영 안되는 경우를 막기위한 코드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvState_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvStock.CurrentCell is DataGridViewCheckBoxCell)
            {
                dgvStock.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                bool bCheck = false;

                for (int i = 0; i < dgvStock.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dgvStock[0, i].Value))
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

        private void btn4_Click(object sender, EventArgs e) //이력조회
        {
            foreach (DataGridViewRow row in dgvStock.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chk"];
                if (Convert.ToBoolean(chk.Value) == true)
                {
                    frmStockBackgroundCheck frm = new frmStockBackgroundCheck(Convert.ToInt32(dgvStock[1, row.Index]), Convert.ToInt32(dgvStock[3, row.Index]));
                    frm.Show();
                }
            }
        }
    }
}
