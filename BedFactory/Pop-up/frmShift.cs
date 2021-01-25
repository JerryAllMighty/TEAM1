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
    public partial class frmShift : Form
    {
        string type;
        int id = 0;

        public frmShift()
        {
            InitializeComponent();

            type = "I";
            lblMan.Text = "*등록자";
            lblDate.Text = "*등록일";

            SetShow();
        }

        public frmShift(ShiftVO vo)
        {
            InitializeComponent();

            type = "U";
            lblShift.Tag = vo.Shift_Num;
            cboShift.Text = vo.Shift_Name;
            txtWp.Text = vo.WP_Num.ToString();
            txtStartTime.Text = vo.Start_Time.ToString();
            txtEndTime.Text = vo.End_Time.ToString();
            dtpStartDate.Value = vo.Start_Date.Date;
            dtpEndDate.Value = vo.End_Date.Date;
            cboIsUse.Text = vo.IsUse;

            SetShow();
        }

        public frmShift(ShiftVO vo, string copy)
        {
            InitializeComponent();

            type = "I";
            lblMan.Text = "*등록자";
            lblDate.Text = "*등록일";

            cboShift.Text = vo.Shift_Name;
            txtWp.Text = vo.WP_Num.ToString();
            txtStartTime.Text = vo.Start_Time.ToString();
            txtEndTime.Text = vo.End_Time.ToString();
            dtpStartDate.Value = vo.Start_Date.Date;
            dtpEndDate.Value = vo.End_Date.Date;
            cboIsUse.Text = vo.IsUse;

            SetShow();
        }

        private void SetShow()
        {
            dtpEndDate.MinDate = dtpStartDate.Value;

            txtMan.Text = id.ToString();
            dtpDate.Value = DateTime.Now.Date;
            txtMan.Enabled = false;
            dtpDate.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtStartTime.Text.Length == 6 || txtEndTime.Text.Length == 6
                    || int.Parse(txtStartTime.Text.Substring(0, 2)) > 24
                    || int.Parse(txtStartTime.Text.Substring(2, 2)) > 60
                    || int.Parse(txtStartTime.Text.Substring(4, 2)) > 60)
            {
                MessageBox.Show("시간 입력이 정확하지 않습니다.");
                return;
            }

            if (txtWp.Text.Length > 0)
            {
                MessageBox.Show("필수 입력사항입니다.");
                return;
            }

            if (type == "I")
            {
                ShiftVO vo = new ShiftVO
                {
                    Shift_Name = cboShift.Text,
                    WP_Num = int.Parse(txtWp.Text),
                    Start_Time = int.Parse(txtStartTime.Text),
                    End_Time = int.Parse(txtEndTime.Text),
                    Start_Date = dtpStartDate.Value.Date,
                    End_Date = dtpEndDate.Value.Date,
                    FirstMan = int.Parse(txtMan.Text),
                    FirstDate = dtpDate.Value.Date,
                    IsUse = cboIsUse.Text
                };

                ShiftsService service = new ShiftsService();
                int cnt = service.ShiftInsert(vo);
                
                if (cnt == 0)
                {
                    MessageBox.Show(BedFactory.Properties.Settings.Default.InsertSuccess);
                }
                else if (cnt == 1)
                {
                    MessageBox.Show("근무일정이 겹쳐 사용유무가 N으로 변경되어 등록되었습니다.");
                }
                else
                {
                    MessageBox.Show(BedFactory.Properties.Settings.Default.InsertFail);
                }
            }
            else
            {
                ShiftVO vo = new ShiftVO
                {
                    Shift_Num = Convert.ToInt32(lblShift.Tag),
                    Shift_Name = cboShift.Text,
                    WP_Num = int.Parse(txtWp.Text),
                    Start_Time = int.Parse(txtStartTime.Text),
                    End_Time = int.Parse(txtEndTime.Text),
                    Start_Date = dtpStartDate.Value.Date,
                    End_Date = dtpEndDate.Value.Date,
                    LastMan = int.Parse(txtMan.Text),
                    LastDate = dtpDate.Value.Date,
                    IsUse = cboIsUse.Text
                };

                ShiftsService service = new ShiftsService();
                int cnt = service.ShiftUpdate(vo);

                if (cnt == 0)
                {
                    MessageBox.Show(BedFactory.Properties.Settings.Default.UpdateSuccess);
                }
                else if (cnt == 1)
                {
                    MessageBox.Show("근무일정이 겹쳐 사용유무가 N으로 변경되어 수정되었습니다.");
                }
                else
                {
                    MessageBox.Show(BedFactory.Properties.Settings.Default.UpdateFail);
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpStartDate.Value;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
