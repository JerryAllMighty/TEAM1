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
    public partial class frmMaterialLedgerStockWarehousingState : BaseForm2
    {
        CheckBox headerCheck = new CheckBox();

        public frmMaterialLedgerStockWarehousingState()
        {
            InitializeComponent();
        }

        private void frmMaterialLedgerStockWarehousingState_Load(object sender, EventArgs e)
        {
            dgvState.SetGridCheckBox("chkBalzoo");
            dgvState.SetGridViewColumn("입고번호", "Wearing_Num");
            dgvState.SetGridViewColumn("창고번호", "Str_Num");
            dgvState.SetGridViewColumn("창고종류", "Str_Kind");
            dgvState.SetGridViewColumn("자재명", "Mat_Name");
            dgvState.SetGridViewColumn("자재수량", "Mat_Cnt");
            dgvState.SetGridViewColumn("취소수량", "Cancel_Cnt");
            dgvState.SetGridViewColumn("등록자", "FirstMan");
            dgvState.SetGridViewColumn("등록일", "FirstDate");

            Point point = dgvState.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheck.Location = new Point(point.X + 8, point.Y + 2);
            headerCheck.BackColor = Color.Transparent;
            headerCheck.Size = new Size(18, 18);
            headerCheck.Click += HeaderCheck_Click; ;
            dgvState.Controls.Add(headerCheck);

            dtpTo.MinDate = dtpFrom.Value.AddDays(-7);
        }

        private void HeaderCheck_Click(object sender, EventArgs e)
        {
            dgvState.EndEdit();

            foreach (DataGridViewRow row in dgvState.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chk"];
                chk.Value = headerCheck.Checked;
            }
        }

        private void DataLoad()
        {
            WearingService service = new WearingService();
            dgvState.DataSource = service.WarehousingState(dtpFrom.Value.Date, dtpTo.Value.Date);
        }

        /// <summary>
        /// DataGridView 내부 checkBox 사용시, check 상태 반영 안되는 경우를 막기위한 코드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvState_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvState.CurrentCell is DataGridViewCheckBoxCell)
            {
                dgvState.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            DataLoad();
            dtpTo.MinDate = dtpFrom.Value;
        }

        //좀더 수정
        private void btn4_Click(object sender, EventArgs e) //입고취소
        {
            foreach (DataGridViewRow row in dgvState.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chk"];
                if(Convert.ToBoolean(chk.Value) == true)
                {
                    if (row.Cells[6].Value != null)
                    {
                        WearingService service = new WearingService();
                        service.WarehousingCancel(Convert.ToInt32(row.Cells[1].Value), Convert.ToInt32(row.Cells[6].Value));
                    }                    
                }
            }
        }

        private void dgvState_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                bool bCheck = false;

                for (int i = 0; i < dgvState.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dgvState[0, i].Value))
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
    }
}
