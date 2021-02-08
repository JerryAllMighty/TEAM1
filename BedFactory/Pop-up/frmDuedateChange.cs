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
    public partial class frmDuedateChange : Form
    {
        List<string> list;

        public frmDuedateChange(List<string> list, DateTime date)
        {
            InitializeComponent();

            this.list = list;
            dtpB.Value = date;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
