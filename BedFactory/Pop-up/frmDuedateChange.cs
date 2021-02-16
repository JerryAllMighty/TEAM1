using BedFactoryService;
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

            dtpB.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BalzooService service = new BalzooService();
            if(service.BalzooDateUpdate(list, dtpA.Value.Date))
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.UpdateSuccess);
                this.Close();
            }
            else
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.UpdateFail);
            }
        }
    }
}
