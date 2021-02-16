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
    public partial class frmMenuRegister : Form
    {
        public frmMenuRegister()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            tblParent.Visible = false;
            tblChild.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tblParent.Visible = true;
            tblChild.Visible = false;
        }

        /// <summary>
        /// 취소 버튼. 폼 닫기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 메뉴 등록
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
