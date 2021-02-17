using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BedFactoryService;
using BedFactoryVO;
using BadFactory;

namespace BedFactory.Pop_up
{
    public partial class frmLogin : Form
    {
        public static List<EmployeeVO> vo = new List<EmployeeVO>();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            EmployeesService service = new EmployeesService();
            vo = service.Login(txtID.Text, txtPW.Text);

            if(vo.Count > 0)
            {
                MessageBox.Show($"{vo[0].Emp_Name}님 환영합니다.");
                frmMain frm = new frmMain();
                frm.emp_Info = vo[0];
                frm.Owner = this;
                frm.Show();
                this.Hide();
                txtID.Text = txtPW.Text = "";
            }
            else
            {
                MessageBox.Show($"ID, PW를 다시 확인하여주십시오.");
                return;
            }
        }
    }
}
