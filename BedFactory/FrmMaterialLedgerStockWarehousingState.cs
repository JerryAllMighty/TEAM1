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
    public partial class frmMaterialLedgerStockWarehousingState : BaseForm2
    {
        CheckBox headerCheck = new CheckBox();
        List<WearingVO> list;

        DateTime bFrom = DateTime.Parse("9999-12-30");
        DateTime bTo = DateTime.Parse("9999-12-30");

        public frmMaterialLedgerStockWarehousingState()
        {
            InitializeComponent();
        }

        private void frmMaterialLedgerStockWarehousingState_Load(object sender, EventArgs e)
        {
            dgvState.SetGridCheckBox("chk");
            dgvState.SetGridViewColumn("입고번호", "Wearing_Num");
            dgvState.SetGridViewColumn("납품업체", "Com_Name");
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
            dtpFrom.Value = DateTime.Now.AddDays(-7);

            DataLoad();
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
            list = service.WarehousingState(dtpFrom.Value.Date, dtpTo.Value.Date);
            dgvState.DataSource = list;

            List<string> temp = list.GroupBy(p => p.Com_Name).Select(p => p.Key.ToString()).ToList();
            temp.Insert(0, "전체");
            cboCom.DisplayMember = "Com_Name";
            cboCom.DataSource = temp;
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
            dtpTo.MinDate = dtpFrom.Value;
        }

        //좀더 수정
        private void btn4_Click(object sender, EventArgs e) //입고취소
        {
            bool bChange = false;

            if(MessageBox.Show("선택된 입고항목들을 취소하겠습니까?", "취소확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvState.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chk"];
                    if (Convert.ToBoolean(chk.Value) == true)
                    {
                        if (row.Cells[6].Value != null && Convert.ToInt32(row.Cells[6].Value) > 0)
                        {
                            WearingService service = new WearingService();
                            service.WarehousingCancel(Convert.ToInt32(row.Cells[1].Value), Convert.ToInt32(row.Cells[6].Value));

                            bChange = true;
                        }
                    }
                }

                if (bChange)
                    DataLoad();
            }            
        }

        private void dgvState_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvState.EndEdit();

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

        private void dgvState_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                if (dgvState[6, dgvState.SelectedRows[0].Index].Value == null)
                    dgvState[6, dgvState.SelectedRows[0].Index].Value = 0;
                
                if(Convert.ToInt32(dgvState[6, dgvState.SelectedRows[0].Index].Value.ToString() + e.KeyChar) <= Convert.ToInt32(dgvState[5, dgvState.SelectedRows[0].Index].Value))
                {
                    dgvState[6, dgvState.SelectedRows[0].Index].Value = int.Parse(dgvState[6, dgvState.SelectedRows[0].Index].Value.ToString() + e.KeyChar);
                }                
            }

            if(e.KeyChar == 8)
            {
                if (dgvState[6, dgvState.SelectedRows[0].Index].Value != null)
                {
                    string str = dgvState[6, dgvState.SelectedRows[0].Index].Value.ToString();
                    if(str.Length - 1 == 0)
                    {
                        dgvState[6, dgvState.SelectedRows[0].Index].Value = null;
                    }
                    else
                    {
                        dgvState[6, dgvState.SelectedRows[0].Index].Value = int.Parse(str.Substring(0, str.Length - 1));
                    }                    
                }
            }
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            if (bFrom.Date != dtpFrom.Value.Date && bTo.Date != dtpTo.Value.Date)
                DataLoad();

            var item = (from temp in list
                        where (cboCom.SelectedIndex == 0 ? true : temp.Com_Name == cboCom.Text)
                              && (txtMaterial.Text.Length < 1 ? true : temp.Mat_Name.Contains(txtMaterial.Text))
                              && (txtWearing.Text.Length < 1 ? true : temp.Wearing_Num.ToString().Contains(txtMaterial.Text))
                        select temp).ToList();

            dgvState.DataSource = item;
        }
    }
}
