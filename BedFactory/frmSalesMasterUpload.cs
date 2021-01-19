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
    public partial class frmSalesMasterUpload : Form
    {
        public frmSalesMasterUpload()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSalesMasterRegister frm = new frmSalesMasterRegister();
            frm.Show();
            frm.Activate();
        }
    }
}
