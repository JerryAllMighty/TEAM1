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
        }

        private void cboDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStartTime.Text = dic[cboDate.SelectedItem.ToString()][0].ToString();
            txtEndTime.Text = dic[cboDate.SelectedItem.ToString()][1].ToString();
            nudPeopleCnt.Value = dic[cboDate.SelectedItem.ToString()][2];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtStartTime.Text.Length != 6 || txtEndTime.Text.Length != 6
                    || int.Parse(txtStartTime.Text.Substring(0, 2)) > 24
                    || int.Parse(txtStartTime.Text.Substring(2, 2)) > 60
                    || int.Parse(txtStartTime.Text.Substring(4, 2)) > 60)
            {
                MessageBox.Show("시간 입력이 정확하지 않습니다.");
                return;
            }

            ShiftVO vo = new ShiftVO
            {
                Shift_Num = int.Parse(lblShift.Text),
                Start_Time = txtStartTime.Text,
                End_Time = txtEndTime.Text,
                Change_Date = Convert.ToDateTime(cboDate.SelectedItem).Date,
                PeopleCnt = (int)nudPeopleCnt.Value
            };

            ShiftsService service = new ShiftsService();
            int cnt = service.ShiftInsert(vo);

            if (cnt < 2)
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.InsertSuccess);
            }
            else
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.InsertFail);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
