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

namespace BedFactory.Pop_up
{ 
    public partial class frmPurchasing : Form
    {
        int id = 0;
        List<BalzooVO> list;

        public frmPurchasing(List<BalzooVO> list)
        {
            InitializeComponent();

            this.list = list;
        }

        private void frmPurchasing_Load(object sender, EventArgs e)
        {
            dgvCompany.SetGridViewColumn("거래처코드", "Com_Code");
            dgvCompany.SetGridViewColumn("거래처명", "Com_Name");
            dgvCompany.SetGridViewColumn("거래처번호", "Com_Num", visibility:false);

            dgvBalzoo.SetGridViewColumn("자재번호", "Mat_Num", visibility: false);
            dgvBalzoo.SetGridViewColumn("자재명", "Mat_Name");
            dgvBalzoo.SetGridViewColumn("납기일", "Firstdate");
            dgvBalzoo.SetGridViewColumn("현재고", "Mat_Cnt");
            dgvBalzoo.SetGridViewColumn("발주제안", "MaterialUse_Cnt");
            dgvBalzoo.SetGridViewColumn("발주량", "Bz_Cnt");

            BalzooService service = new BalzooService();
            dgvCompany.DataSource = service.BalzooCompany();

            list.ForEach(p => p.FirstDate = DateTime.Now.Date);
            dgvBalzoo.DataSource = list;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBalzoo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                if (dgvBalzoo[5, dgvBalzoo.SelectedRows[0].Index].Value == null)
                    dgvBalzoo[5, dgvBalzoo.SelectedRows[0].Index].Value = 0;
                
                dgvBalzoo[5, dgvBalzoo.SelectedRows[0].Index].Value = int.Parse(dgvBalzoo[5, dgvBalzoo.SelectedRows[0].Index].Value.ToString() + e.KeyChar);
            }

            if (e.KeyChar == 8)
            {
                if (dgvBalzoo[5, dgvBalzoo.SelectedRows[0].Index].Value != null)
                {
                    string str = dgvBalzoo[5, dgvBalzoo.SelectedRows[0].Index].Value.ToString();
                    if (str.Length - 1 == 0)
                    {
                        dgvBalzoo[5, dgvBalzoo.SelectedRows[0].Index].Value = null;
                    }
                    else
                    {
                        dgvBalzoo[5, dgvBalzoo.SelectedRows[0].Index].Value = int.Parse(str.Substring(0, str.Length - 1));
                    }
                }
            }
        }

        private void btnBalzoo_Click(object sender, EventArgs e)
        {
            List<BalzooVO> list = new List<BalzooVO>();

            foreach(DataGridViewRow row in dgvBalzoo.Rows)
            {
                if(dgvBalzoo[5, row.Index].Value != null || Convert.ToInt32(dgvBalzoo[5, row.Index].Value) != 0)
                {
                    BalzooVO vo = new BalzooVO
                    {
                        Mat_Num = dgvBalzoo[0, row.Index].Value.ToString(),
                        Bz_Cnt = Convert.ToInt32(dgvBalzoo[5, row.Index].Value)
                    };

                    list.Add(vo);
                }
            }

            BalzooService service = new BalzooService();
            if (service.BalzooInsert(list, Convert.ToInt32(dgvCompany[2, dgvCompany.SelectedRows[0].Index].Value), id))
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.InsertSuccess);
                this.Close();
            }
            else
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.InsertFail);
            }
        }
    }
}
