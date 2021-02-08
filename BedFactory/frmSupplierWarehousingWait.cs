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
    public partial class frmSupplierWarehousingWait : BaseForm2
    {
        CheckBox headerCheck = new CheckBox();
        CheckBox headerCheckz = new CheckBox();

        List<BalzooVO> list;
        List<BalzooVO> copy = new List<BalzooVO>();

        public frmSupplierWarehousingWait()
        {
            InitializeComponent();
        }

        private void frmSupplierWarehousingWait_Load(object sender, EventArgs e)
        {
            dgvCheck.SetGridCheckBox("chkBalzoo");
            dgvCheck.SetGridViewColumn("발주번호", "Bz_D_Num");
            dgvCheck.SetGridViewColumn("거래처명", "Com_Name");
            dgvCheck.SetGridViewColumn("자재명", "Mat_Name");
            dgvCheck.SetGridViewColumn("발주수량", "Bz_Cnt");
            dgvCheck.SetGridViewColumn("발주상태", "Bz_D_Status");
            dgvCheck.SetGridViewColumn("예상납기일", "ExpectedDate");

            Point point = dgvCheck.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheck.Location = new Point(point.X + 8, point.Y + 2);
            headerCheck.BackColor = Color.Transparent;
            headerCheck.Size = new Size(18, 18);
            headerCheck.Click += HeaderCheck_Click; ;
            dgvCheck.Controls.Add(headerCheck);

            dgvWait.SetGridCheckBox("chkBalzoo");
            dgvWait.SetGridViewColumn("발주번호", "Bz_D_Num");
            dgvWait.SetGridViewColumn("거래처명", "Com_Name");
            dgvWait.SetGridViewColumn("자재명", "Mat_Name");
            dgvWait.SetGridViewColumn("발주수량", "Bz_Cnt");
            dgvWait.SetGridViewColumn("발주상태", "Bz_D_Status");
            dgvWait.SetGridViewColumn("예상납기일", "ExpectedDate");

            Point pointz = dgvWait.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheckz.Location = new Point(pointz.X + 8, pointz.Y + 2);
            headerCheckz.BackColor = Color.Transparent;
            headerCheckz.Size = new Size(18, 18);
            headerCheckz.Click += HeaderCheck_Click; ;
            dgvWait.Controls.Add(headerCheckz);

            dtpTo.MinDate = dtpFrom.Value.AddDays(-7);
            dtpTo.Value = DateTime.Now.AddDays(7);
        }

        private void HeaderCheck_Click(object sender, EventArgs e)
        {
            CheckBox chkName = (CheckBox)sender;
            if(chkName == headerCheck)
            {
                dgvCheck.EndEdit();

                foreach (DataGridViewRow row in dgvCheck.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chkBalzoo"];
                    chk.Value = headerCheck.Checked;
                }
            }
            else
            {
                dgvWait.EndEdit();

                foreach (DataGridViewRow row in dgvWait.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chkBalzoo"];
                    chk.Value = headerCheckz.Checked;
                }
            }
            
        }

        private void DataLoad()
        {
            BalzooService service = new BalzooService();
            list = service.WarehousingWait(dtpFrom.Value.Date, dtpTo.Value.Date);
            dgvCheck.DataSource = list;
        }

        /// <summary>
        /// DataGridView 내부 checkBox 사용시, check 상태 반영 안되는 경우를 막기위한 코드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if(dgv == dgvCheck)
            {
                if (dgvCheck.CurrentCell is DataGridViewCheckBoxCell)
                {
                    dgvCheck.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
            else
            {
                if (dgvWait.CurrentCell is DataGridViewCheckBoxCell)
                {
                    dgvWait.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            DataLoad();
            dtpTo.MinDate = dtpFrom.Value;
        }

        private void btn3_Click(object sender, EventArgs e) //선택
        {
            foreach (DataGridViewRow row in dgvCheck.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chkBalzoo"];
                if(Convert.ToBoolean(chk.Value) == true)
                {
                    if(dgvWait.Rows.Count < 1)
                        copy.Add(list.Where(p => p.Bz_D_Num == dgvCheck[1, row.Index].Value.ToString()).ToList()[0]);

                    foreach (DataGridViewRow search in dgvWait.Rows)
                    {
                        if (dgvWait[1, search.Index].Value != dgvCheck[1, row.Index].Value)
                        {
                            copy.Add(list.Where(p => p.Bz_D_Num == dgvCheck[1, row.Index].Value.ToString()).ToList()[0]);
                        }
                    }

                    chk.Value = false;
                }
            }

            dgvWait.DataSource = null;
            dgvWait.Rows.Clear();
            dgvWait.DataSource = copy;
            headerCheck.Checked = false;
        }

        private void btn2_Click(object sender, EventArgs e) //취소
        {
            foreach (DataGridViewRow row in dgvWait.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chkBalzoo"];
                if (Convert.ToBoolean(chk.Value) == true)
                {
                    copy.RemoveAt(row.Index);
                }
            }

            dgvWait.DataSource = null;
            dgvWait.Rows.Clear();
            dgvWait.DataSource = copy;
            headerCheckz.Checked = false;
        }

        private void btn5_Click(object sender, EventArgs e) //입고대기처리
        {
            foreach (DataGridViewRow row in dgvWait.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chkBalzoo"];
                if (Convert.ToBoolean(chk.Value) == true)
                {
                    BalzooService service = new BalzooService();
                    service.StateIsWait(dgvWait[1, row.Index].Value.ToString());
                    copy.RemoveAt(row.Index);
                }
            }

            dgvWait.DataSource = null;
            dgvWait.Rows.Clear();
            dgvWait.DataSource = copy;
            headerCheckz.Checked = false;
            DataLoad();
        }

        private void dgvCheck_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                bool bCheck = false;

                for (int i = 0; i < dgvCheck.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dgvCheck[0, i].Value))
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

        private void dgvWait_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                bool bCheck = false;

                for (int i = 0; i < dgvWait.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dgvWait[0, i].Value))
                    {
                        bCheck = true;
                        break;
                    }
                }

                if (bCheck)
                    headerCheckz.Checked = true;
                else
                    headerCheckz.Checked = false;
            }
        }
    }
}
