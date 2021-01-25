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
    public partial class frmShiftChange : Form
    {
        Dictionary<string, List<int>> dic = new Dictionary<string, List<int>>();

        public frmShiftChange(string id, Dictionary<string, List<int>> dic)
        {
            InitializeComponent();

            this.dic = dic;

            lblShift.Text = id;

            cboDate.Items.AddRange(dic.Keys.ToArray());
            cboDate.SelectedIndex = 0;

            txtStartTime.Text = dic[cboDate.SelectedText][0].ToString();
            txtEndTime.Text = dic[cboDate.SelectedText][0].ToString();
            nudPeopleCnt.Value = dic[cboDate.SelectedText][0];
        }

        private void cboDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStartTime.Text = dic[cboDate.SelectedText][0].ToString();
            txtEndTime.Text = dic[cboDate.SelectedText][0].ToString();
            nudPeopleCnt.Value = dic[cboDate.SelectedText][0];
        }
    }
}
