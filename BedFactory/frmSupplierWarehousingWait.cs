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
        int id = 1;

        CheckBox headerCheck = new CheckBox();
        CheckBox headerCheckz = new CheckBox();

        List<BalzooVO> list;
        List<BalzooVO> copy = new List<BalzooVO>();

        DateTime bFrom = DateTime.Parse("9999-12-30");
        DateTime bTo = DateTime.Parse("9999-12-30");

        public frmSupplierWarehousingWait()
        {
            InitializeComponent();
        }

        private void frmSupplierWarehousingWait_Load(object sender, EventArgs e)
        {
            btn1.Visible = false;
            btn4.Visible = false;

            dgvCheck.SetGridCheckBox("chkBalzoo");
            dgvCheck.SetGridViewColumn("발주번호", "Bz_D_Num");
            dgvCheck.SetGridViewColumn("거래처명", "Com_Name", 150);
            dgvCheck.SetGridViewColumn("자재명", "Mat_Name", 150);
            dgvCheck.SetGridViewColumn("발주수량", "Bz_Cnt");
            dgvCheck.SetGridViewColumn("입고수량", "Mat_Cnt");
            dgvCheck.SetGridViewColumn("잔량", "R_Quantity");
            dgvCheck.SetGridViewColumn("예상납기일", "ExpectedDate");

            Point point = dgvCheck.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheck.Location = new Point(point.X + 8, point.Y + 2);
            headerCheck.BackColor = Color.Transparent;
            headerCheck.Size = new Size(18, 18);
            headerCheck.Click += HeaderCheck_Click; ;
            dgvCheck.Controls.Add(headerCheck);

            dgvWait.SetGridCheckBox("chkBalzoo");
            dgvWait.SetGridViewColumn("발주번호", "Bz_D_Num");
            dgvWait.SetGridViewColumn("거래처명", "Com_Name", 150);
            dgvWait.SetGridViewColumn("자재명", "Mat_Name", 150);
            dgvWait.SetGridViewColumn("발주수량", "Bz_Cnt");
            dgvWait.SetGridViewColumn("입고수량", "Mat_Cnt");
            dgvWait.SetGridViewColumn("잔량", "R_Quantity");
            dgvWait.SetGridViewColumn("예상납기일", "ExpectedDate");

            Point pointz = dgvWait.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheckz.Location = new Point(pointz.X + 8, pointz.Y + 2);
            headerCheckz.BackColor = Color.Transparent;
            headerCheckz.Size = new Size(18, 18);
            headerCheckz.Click += HeaderCheck_Click; ;
            dgvWait.Controls.Add(headerCheckz);

            dtpTo.MinDate = dtpFrom.Value.AddDays(-7);
            dtpTo.Value = DateTime.Now.AddDays(7);

            DataLoad();
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

            List<string> temp = list.GroupBy(p => p.Com_Name).Select(p => p.Key.ToString()).ToList();
            temp.Insert(0, "전체");
            cboCom.DisplayMember = "Com_Name";
            cboCom.DataSource = temp;

            temp = list.GroupBy(p => p.Bz_D_Num).Select(p => p.Key.ToString()).ToList();
            temp.Insert(0, "전체");
            cboBnum.DisplayMember = "Bz_D_Num";
            cboBnum.DataSource = temp;

            bFrom = dtpFrom.Value.Date;
            bTo = dtpTo.Value.Date;
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

            copy.ForEach(p => p.Mat_Cnt = 0);
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
                    if (Convert.ToInt32(dgvWait[5, row.Index].Value) != 0)
                    {
                        WearingVO vo = new WearingVO
                        {
                            Bz_D_Num = dgvWait[1, row.Index].Value.ToString(),
                            FirstMan = id,
                            Mat_Cnt = Convert.ToInt32(dgvWait[5, dgvWait.SelectedRows[0].Index].Value)
                        };

                        BalzooService service = new BalzooService();
                        service.StateIsWait(vo);
                        copy.RemoveAt(row.Index);
                    }
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
            dgvCheck.EndEdit();

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
            dgvWait.EndEdit();

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

        private void btnSerch_Click(object sender, EventArgs e)
        {
            if (bFrom.Date != dtpFrom.Value.Date || bTo.Date != dtpTo.Value.Date)
                DataLoad();

            var item = (from temp in list
                        where (cboCom.SelectedIndex == 0 ? true : temp.Com_Name == cboCom.Text)
                              && (cboBnum.SelectedIndex == 0 ? true : temp.Bz_D_Num == cboBnum.Text)
                              && (txtMate.Text.Length < 1 ? true : temp.Mat_Name.Contains(txtMate.Text))
                        select temp).ToList();

            dgvCheck.DataSource = item;
        }

        private void dgvWait_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                if (Convert.ToInt32(dgvWait[5, dgvWait.SelectedRows[0].Index].Value.ToString() + e.KeyChar) <= Convert.ToInt32(dgvWait[6, dgvWait.SelectedRows[0].Index].Value))
                {
                    dgvWait[5, dgvWait.SelectedRows[0].Index].Value = int.Parse(dgvWait[5, dgvWait.SelectedRows[0].Index].Value.ToString() + e.KeyChar);
                }
            }

            if (e.KeyChar == 8)
            {
                if (dgvWait[5, dgvWait.SelectedRows[0].Index].Value != null)
                {
                    string str = dgvWait[5, dgvWait.SelectedRows[0].Index].Value.ToString();
                    if (str.Length - 1 == 0)
                    {
                        dgvWait[5, dgvWait.SelectedRows[0].Index].Value = null;
                    }
                    else
                    {
                        dgvWait[5, dgvWait.SelectedRows[0].Index].Value = int.Parse(str.Substring(0, str.Length - 1));
                    }
                }
            }
        }
    }
}
