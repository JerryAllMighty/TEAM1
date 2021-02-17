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
    public partial class frmMaterialLedgerStockWarehousing : BaseForm2
    {
        CheckBox headerCheck = new CheckBox();
        CheckBox headerCheckz = new CheckBox();

        List<WearingVO> list;
        List<WearingVO> copy = new List<WearingVO>();

        DateTime bFrom = DateTime.Parse("9999-12-30");
        DateTime bTo = DateTime.Parse("9999-12-30");

        public frmMaterialLedgerStockWarehousing()
        {
            InitializeComponent();
        }

        private void frmMaterialLedgerStockWarehousing_Load(object sender, EventArgs e)
        {
            btn1.Visible = btn5.Visible = false;

            dgvWait.SetGridCheckBox("chk");
            dgvWait.SetGridViewColumn("거래처명", "Com_Name");
            dgvWait.SetGridViewColumn("자재명", "Mat_Name");
            dgvWait.SetGridViewColumn("자재유형", "Mat_Category");
            dgvWait.SetGridViewColumn("검사내용", "Error_Detail");
            dgvWait.SetGridViewColumn("불량", "Error_Cnt");
            dgvWait.SetGridViewColumn("입고량", "Mat_Cnt");
            dgvWait.SetGridViewColumn("예상납기일", "ExpectedDate");
            dgvWait.SetGridViewColumn("입고상태", "W_Category");
            dgvWait.SetGridViewColumn("입고번호", "Wearing_Num", visibility:false);

            Point point = dgvWait.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheck.Location = new Point(point.X + 8, point.Y + 2);
            headerCheck.BackColor = Color.Transparent;
            headerCheck.Size = new Size(18, 18);
            headerCheck.Click += HeaderCheck_Click; ;
            dgvWait.Controls.Add(headerCheck);

            dgvWearing.SetGridCheckBox("chk");
            dgvWearing.SetGridViewColumn("자재명", "Mat_Name");
            dgvWearing.SetGridViewColumn("자재유형", "Mat_Category");
            dgvWearing.SetGridViewColumn("창고번호", "Str_Num");
            dgvWearing.SetGridViewColumn("창고유형", "Str_Kind");
            dgvWearing.SetGridViewColumn("입고량", "Mat_Cnt");
            dgvWearing.SetGridViewColumn("입고번호", "Wearing_Num", visibility: false);

            Point pointz = dgvWearing.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheckz.Location = new Point(pointz.X + 8, pointz.Y + 2);
            headerCheckz.BackColor = Color.Transparent;
            headerCheckz.Size = new Size(18, 18);
            headerCheckz.Click += HeaderCheck_Click; ;
            dgvWearing.Controls.Add(headerCheckz);

            dtpTo.MinDate = dtpFrom.Value.AddDays(-7);
            dtpTo.Value = DateTime.Now.AddDays(7);

            DataLoad();
        }

        private void HeaderCheck_Click(object sender, EventArgs e)
        {
            CheckBox chkName = (CheckBox)sender;
            if (chkName == headerCheck)
            {
                dgvWait.EndEdit();

                foreach (DataGridViewRow row in dgvWait.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chk"];
                    chk.Value = headerCheck.Checked;
                }
            }
            else
            {
                dgvWearing.EndEdit();

                foreach (DataGridViewRow row in dgvWearing.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chk"];
                    chk.Value = headerCheckz.Checked;
                }
            }

        }

        private void DataLoad()
        {
            WearingService service = new WearingService();
            list = service.WarehousingStart(dtpFrom.Value.Date, dtpTo.Value.Date);
            dgvWait.DataSource = list;

            List<string> temp = list.GroupBy(p => p.Com_Name).Select(p => p.Key.ToString()).ToList();
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
        private void CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv == dgvWearing)
            {
                if (dgvWearing.CurrentCell is DataGridViewCheckBoxCell)
                {
                    dgvWearing.CommitEdit(DataGridViewDataErrorContexts.Commit);
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

        private void btn3_Click_1(object sender, EventArgs e) //선택
        {

            foreach (DataGridViewRow row in dgvWait.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chk"];
                if (Convert.ToBoolean(chk.Value) == true)
                {
                    if (dgvWait[4, row.Index].Value.ToString() != "미검사")
                    {
                        if (dgvWearing.Rows.Count < 1)
                            copy.Add(list.Where(p => p.Wearing_Num == Convert.ToInt32(dgvWait[9, row.Index].Value)).ToList()[0]);

                        foreach (DataGridViewRow search in dgvWearing.Rows)
                        {
                            if (dgvWait[9, row.Index].Value != dgvWearing[6, search.Index].Value)
                            {
                                copy.Add(list.Where(p => p.Wearing_Num == Convert.ToInt32(dgvWait[9, row.Index].Value)).ToList()[0]);
                            }
                        }

                        chk.Value = false;
                    }
                }
            }

            //copy.ForEach(p => p.Mat_Cnt = 0);
            dgvWearing.DataSource = null;
            dgvWearing.Rows.Clear();
            dgvWearing.DataSource = copy;
            headerCheck.Checked = false;
        }

        private void btn2_Click_1(object sender, EventArgs e) //취소
        {
            foreach (DataGridViewRow row in dgvWearing.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chk"];
                if (Convert.ToBoolean(chk.Value) == true)
                {
                    copy.RemoveAt(row.Index);
                }
            }

            dgvWearing.DataSource = null;
            dgvWearing.Rows.Clear();
            dgvWearing.DataSource = copy;
            headerCheckz.Checked = false;
        }

        private void btn4_Click_1(object sender, EventArgs e) //입고처리
        {
            foreach (DataGridViewRow row in dgvWearing.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chk"];
                if (Convert.ToBoolean(chk.Value) == true)
                {
                    WearingService service = new WearingService();
                    service.BuyWarehousing(Convert.ToInt32(dgvWearing[6, row.Index].Value.ToString()), Convert.ToInt32(dgvWearing[5, row.Index].Value.ToString()));
                    copy.RemoveAt(row.Index);
                }
            }

            dgvWearing.DataSource = null;
            dgvWearing.Rows.Clear();
            dgvWearing.DataSource = copy;
            headerCheckz.Checked = false;
            DataLoad();
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
                    headerCheck.Checked = true;
                else
                    headerCheck.Checked = false;
            }
        }

        private void dgvWearing_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvWearing.EndEdit();

            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                bool bCheck = false;

                for (int i = 0; i < dgvWearing.Rows.Count; i++)
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

        private void btnSelect_Click(object sender, EventArgs e) //조회
        {
            if (bFrom.Date != dtpFrom.Value.Date || bTo.Date != dtpTo.Value.Date)
                DataLoad();

            var item = (from temp in list
                        where (cboCompany.SelectedIndex == 0 ? true : temp.Com_Name == cboCompany.Text)
                              && (txtMaterial.Text.Length < 1 ? true : temp.Mat_Name.Contains(txtMaterial.Text))
                        select temp).ToList();

            dgvWait.DataSource = item;
        }
    }
}
