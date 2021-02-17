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
    public partial class frmMaterialRequest : BaseForm2
    {
        int id = 0;
        CheckBox headerCheck = new CheckBox();
        List<ShipmentVO> list;

        DateTime bFrom = DateTime.Parse("9999-12-30");
        DateTime bTo = DateTime.Parse("9999-12-30");

        public frmMaterialRequest()
        {
            InitializeComponent();
        }

        private void frmMaterialRequest_Load(object sender, EventArgs e)
        {
            btn1.Visible = btn2.Visible = btn3.Visible = btn4.Visible = btn5.Visible = false;

            dgvWorkOrder.SetGridViewColumn("계획시작일자", "ProductionDate");
            dgvWorkOrder.SetGridViewColumn("작업지시번호", "WO_Num");
            dgvWorkOrder.SetGridViewColumn("작업장명", "WP_Name");
            dgvWorkOrder.SetGridViewColumn("공정상세명", "Process_Name_D");
            dgvWorkOrder.SetGridViewColumn("자재명", "Mat_Name");
            dgvWorkOrder.SetGridViewColumn("지시수량", "WO_Order_Cnt");
            dgvWorkOrder.SetGridViewColumn("상태명", "WO_Status");

            dgvMaSub.SetGridCheckBox("chk");
            dgvMaSub.SetGridViewColumn("자재명", "Mat_Name");
            dgvMaSub.SetGridViewColumn("자재유형", "Mat_Category");
            dgvMaSub.SetGridViewColumn("창고유형", "Str_Kind");
            dgvMaSub.SetGridViewColumn("요청수량", "WO_Order_Cnt");
            dgvMaSub.SetGridViewColumn("출고량", "Ship_Cnt");
            dgvMaSub.SetGridViewColumn("작업지시번호", "WO_Num", visibility: false);
            dgvMaSub.SetGridViewColumn("자재번호", "Mat_Num", visibility: false);

            Point point = dgvMaSub.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheck.Location = new Point(point.X + 8, point.Y + 2);
            headerCheck.BackColor = Color.Transparent;
            headerCheck.Size = new Size(18, 18);
            headerCheck.Click += HeaderCheck_Click; ;
            dgvMaSub.Controls.Add(headerCheck);

            dtpTo.MinDate = dtpFrom.Value.AddDays(-7);
            dtpTo.Value = DateTime.Now.AddDays(7);

            DataLoad();
        }

        private void HeaderCheck_Click(object sender, EventArgs e)
        {
            CheckBox chkName = (CheckBox)sender;

            dgvMaSub.EndEdit();

            foreach (DataGridViewRow row in dgvMaSub.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chk"];
                chk.Value = headerCheck.Checked;
            }
        }

        private void DataLoad()
        {
            ShipmentService service = new ShipmentService();
            list = service.WorkOrdersLoad(dtpFrom.Value.Date, dtpTo.Value.Date);
            dgvWorkOrder.DataSource = list;

            List<string> temp = list.GroupBy(p => p.WP_Name).Select(p => p.Key.ToString()).ToList();
            temp.Insert(0, "전체");
            cboWP.DisplayMember = "Com_Name";
            cboWP.DataSource = temp;

            bFrom = dtpFrom.Value.Date;
            bTo = dtpTo.Value.Date;
        }

        private void dgvMaSub_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (dgvMaSub.CurrentCell is DataGridViewCheckBoxCell)
            {
                dgvMaSub.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpTo.MinDate = dtpFrom.Value;
        }

        private void dgvMaSub_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvMaSub.EndEdit();

            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                bool bCheck = false;

                for (int i = 0; i < dgvMaSub.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dgvMaSub[0, i].Value))
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (bFrom.Date != dtpFrom.Value.Date || bTo.Date != dtpTo.Value.Date)
                DataLoad();

            var item = (from temp in list
                        where (cboWP.SelectedIndex == 0 ? true : temp.WP_Name.ToString().Contains(cboWP.Text))
                              && (txtMaterial.Text.Length < 1 ? true : temp.Mat_Name.Contains(txtMaterial.Text))
                              && (txtWO_Num.Text.Length < 1 ? true : temp.WO_Num.ToString().Contains(txtWO_Num.Text))
                        select temp).ToList();

            dgvWorkOrder.DataSource = item;
        }

        private void btnAdd_Click(object sender, EventArgs e) //추가
        {
            if(dgvWorkOrder.SelectedRows.Count > 0)
            {
                dgvMaSub.DataSource = null;
                dgvMaSub.Rows.Clear();

                List<ShipmentVO> sList = new List<ShipmentVO>();

                ShipmentService service = new ShipmentService();
                sList = service.WorkOrdersByShip(Convert.ToInt32(dgvWorkOrder[1, dgvWorkOrder.SelectedRows[0].Index].Value));

                dgvMaSub.DataSource = sList;
            }
        }

        private void brnSave_Click(object sender, EventArgs e) //저장
        {
            int sCnt = 0;

            foreach (DataGridViewRow row in dgvMaSub.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chk"];
                if (Convert.ToBoolean(chk.Value) == true)
                {
                    if(Convert.ToInt32(dgvMaSub[5, row.Index].Value) > 0)
                    {
                        ShipmentVO vo = new ShipmentVO
                        {
                            WO_Num = Convert.ToInt32(dgvMaSub[6, row.Index].Value),
                            Ship_Cnt = Convert.ToInt32(dgvMaSub[5, row.Index].Value),
                            Mat_Category = dgvMaSub[2, row.Index].Value.ToString(),
                            Mat_Num = dgvMaSub[7, row.Index].Value.ToString()
                        };

                        ShipmentService service = new ShipmentService();
                        if (service.InsertShipment(vo, id))
                        {
                            sCnt++;
                        }
                    }
                    
                }
            }

            MessageBox.Show($"총 {sCnt}건의 자재를 출고했습니다.");
        }

        private void dgvMaSub_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                if (Convert.ToInt32(dgvMaSub[5, dgvMaSub.SelectedRows[0].Index].Value.ToString() + e.KeyChar) <= Convert.ToInt32(dgvMaSub[4, dgvMaSub.SelectedRows[0].Index].Value))
                {
                    dgvMaSub[5, dgvMaSub.SelectedRows[0].Index].Value = int.Parse(dgvMaSub[5, dgvMaSub.SelectedRows[0].Index].Value.ToString() + e.KeyChar);
                }
            }

            if (e.KeyChar == 8)
            {
                if (dgvMaSub[5, dgvMaSub.SelectedRows[0].Index].Value != null)
                {
                    string str = dgvMaSub[5, dgvMaSub.SelectedRows[0].Index].Value.ToString();
                    if (str.Length - 1 == 0)
                    {
                        dgvMaSub[5, dgvMaSub.SelectedRows[0].Index].Value = null;
                    }
                    else
                    {
                        dgvMaSub[5, dgvMaSub.SelectedRows[0].Index].Value = int.Parse(str.Substring(0, str.Length - 1));
                    }
                }
            }
        }

        private void brnCancel_Click(object sender, EventArgs e) //취소
        {
            dgvMaSub.DataSource = null;
            dgvMaSub.Rows.Clear();
        }
    }
}
