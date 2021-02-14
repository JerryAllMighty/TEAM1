using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BedFatory_POP
{
    public partial class frmPopMain : Form
    {
        public frmPopMain()
        {
            InitializeComponent();
        }

        private void frmPopMain_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 착조 폼 연결
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDrilling_Click_1(object sender, EventArgs e)
        {
            lblChildName.Text = "착조";
            frmDrilling frm = new frmDrilling();
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pnlChild.Controls.Clear();
            frm.TopLevel = false;
            pnlChild.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.Activate();
        }

        /// <summary>
        /// 제재 폼 연결
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlaning_Click_1(object sender, EventArgs e)
        {
            lblChildName.Text = "제재";
            frmPlaning frm = new frmPlaning();
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pnlChild.Controls.Clear();
            frm.TopLevel = false;
            pnlChild.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.Activate();
        }

        /// <summary>
        /// 평삭 폼 연결
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSawing_Click_1(object sender, EventArgs e)
        {
            lblChildName.Text = "평삭";
            frmSawing frm = new frmSawing();
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pnlChild.Controls.Clear();
            frm.TopLevel = false;
            pnlChild.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.Activate();
        }

        /// <summary>
        /// 포장 폼 연결
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPacking_Click_1(object sender, EventArgs e)
        {
            lblChildName.Text = "포장";
            frmPacking frm = new frmPacking();
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pnlChild.Controls.Clear();
            frm.TopLevel = false;
            pnlChild.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.Activate();
        }
        /// <summary>
        /// 화면 닫기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 초기 화면으로 돌아감
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlChild.Controls.Clear();
            lblChildName.Text = "";
        }

        /// <summary>
        /// 최소화 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// 로그인 폼을 연다
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPopMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            frm.Activate();
        }
    }
}
