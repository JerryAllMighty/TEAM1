using BedFactory.BaseForms;
using BedFactory.Pop_up;
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
    public partial class frmPurchasingOrderState : BaseForm2
    {
        CheckBox headerCheck = new CheckBox();
        List<BalzooVO> list;

        DateTime bFrom = DateTime.Parse("9999-12-30");
        DateTime bTo = DateTime.Parse("9999-12-30");

        public frmPurchasingOrderState()
        {
            InitializeComponent();
        }

        private void frmPurchasingOrderState_Load(object sender, EventArgs e)
        {
            btn1.Visible = btn2.Visible = btn4.Visible = false;

            dgvOrder.SetGridCheckBox("chk");
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
            dtpTo.Value = DateTime.Now.AddDays(7);

            cboState.SelectedItem = "전체";
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
            list = service.BalzooSelect(dtpFrom.Value.Date, dtpTo.Value.Date);
            dgvOrder.DataSource = list;

            var item = list.GroupBy(p => p.Com_Name);
            List<string> temp = item.Select(p => p.Key.ToString()).ToList();
            temp.Insert(0, "전체");
            cboCompany.DisplayMember = "Com_Name";
            cboCompany.DataSource = temp;

            bFrom = dtpFrom.Value.Date;
            bTo = dtpTo.Value.Date;
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
            dtpTo.MinDate = dtpFrom.Value;
        }

        private void btn5_Click_1(object sender, EventArgs e) //납기일자변경
        {
            List<string> list = new List<string>();
            DateTime date = DateTime.Parse("9999-12-30");

            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chk"];
                if (Convert.ToBoolean(chk.Value) == true)
                {
                    if (dgvOrder[5, row.Index].Value.ToString() == "N")
                    {
                        list.Add(dgvOrder[1, row.Index].Value.ToString());
                        if (date.ToShortDateString() == "9999-12-30")
                            date = Convert.ToDateTime(dgvOrder[6, row.Index].Value);
                    }
                }
            }

            if(list.Count > 0) 
            {
                frmDuedateChange frm = new frmDuedateChange(list, date);
                frm.Show();
                headerCheck.Checked = false;
                DataLoad();
            }
        }

        private void btn3_Click_1(object sender, EventArgs e) //발주취소
        {
            bool bChange = false;

            if (MessageBox.Show("선택된 발주항목들을 취소하겠습니까?", "취소확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                List<string> list = new List<string>();

                foreach (DataGridViewRow row in dgvOrder.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chk"];
                    if (Convert.ToBoolean(chk.Value) == true)
                    {
                        if (dgvOrder[5, row.Index].Value.ToString() == "N")
                        {
                            list.Add(dgvOrder[1, row.Index].Value.ToString());
                            bChange = true;
                        }
                    }
                }

                if (bChange)
                {
                    BalzooService service = new BalzooService();
                    if (service.BalzooCancel(list))
                    {
                        headerCheck.Checked = false;
                        MessageBox.Show(Properties.Settings.Default.DeleteSuccess); 
                        DataLoad();
                    }
                    else
                    {
                        MessageBox.Show(Properties.Settings.Default.DeleteFail);
                    }
                }
                    
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (bFrom.Date != dtpFrom.Value.Date && bTo.Date != dtpTo.Value.Date)
                DataLoad();

            if(list != null)
            {
                var item = (from temp in list
                            where (cboCompany.SelectedIndex == 0 ? true : temp.Com_Name == cboCompany.Text)
                                  && (cboState.SelectedItem.ToString() == "전체" ? true : (cboState.SelectedItem.ToString() == "처리중") ? temp.Bz_D_Status == "N" : temp.Bz_D_Status == "Y")
                                  && (txtMaterial.Text.Length < 1 ? true : temp.Mat_Name.Contains(txtMaterial.Text))
                                  && (txtOrderNum.Text.Length < 1 ? true : temp.Bz_D_Num.ToString().Contains(txtOrderNum.Text))
                            select temp).ToList();

                dgvOrder.DataSource = item;
            }            
        }
    }
}
