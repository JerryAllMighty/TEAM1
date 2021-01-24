using BedFactory.Pop_up;
using BedFactory.Util;
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

namespace BedFactory
{
    public partial class frmShiftInfo : Form
    {
        public frmShiftInfo()
        {
            InitializeComponent();
        }

        private void frmShiftInfo_Load(object sender, EventArgs e)
        {
            dgvShift.SetGridViewColumn("NO.", "RowNum");
            dgvShift.SetGridViewColumn("Shift번호", "Shift_Num", visibility:false);
            dgvShift.SetGridViewColumn("Shift", "Shift_Name");
            dgvShift.SetGridViewColumn("작업장코드", "WP_Num");
            dgvShift.SetGridViewColumn("시작시간", "Start_Time");
            dgvShift.SetGridViewColumn("완료시간", "End_Time");
            dgvShift.SetGridViewColumn("적용시작일자", "Start_Date");
            dgvShift.SetGridViewColumn("적용완료일자", "End_Date");
            dgvShift.SetGridViewColumn("최초등록자", "FirstMan");
            dgvShift.SetGridViewColumn("최초등록일", "FirstDate");
            dgvShift.SetGridViewColumn("최종등록자", "LastMan");
            dgvShift.SetGridViewColumn("최종등록일", "LastDate");
            dgvShift.SetGridViewColumn("사용유무", "IsUse");

            DataLoad();
        }

        private void DataLoad()
        {
            ShiftsService service = new ShiftsService();
            dgvShift.DataSource = service.ShiftsSelect();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmShift frm = new frmShift();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DataLoad();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dgvShift.SelectedRows.Count < 1)
            {
                MessageBox.Show("수정할 근무일정을 선택해주세요.");
                return;
            }

            ShiftVO vo = new ShiftVO
            {
                Shift_Num = Convert.ToInt32(dgvShift[1, dgvShift.SelectedRows[0].Index].Value),
                Shift_Name = dgvShift[1, dgvShift.SelectedRows[2].Index].Value.ToString(),
                WP_Num = Convert.ToInt32(dgvShift[3, dgvShift.SelectedRows[0].Index].Value),
                Start_Time = Convert.ToInt32(dgvShift[4, dgvShift.SelectedRows[0].Index].Value),
                End_Time = Convert.ToInt32(dgvShift[5, dgvShift.SelectedRows[0].Index].Value),
                Start_Date = (DateTime)dgvShift[6, dgvShift.SelectedRows[0].Index].Value,
                End_Date = (DateTime)dgvShift[7, dgvShift.SelectedRows[0].Index].Value,
                LastMan = Convert.ToInt32(dgvShift[8, dgvShift.SelectedRows[0].Index].Value),
                LastDate = (DateTime)dgvShift[9, dgvShift.SelectedRows[0].Index].Value,
                IsUse = dgvShift[10, dgvShift.SelectedRows[0].Index].Value.ToString()
            };

            frmShift frm = new frmShift(vo);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DataLoad();
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (dgvShift.SelectedRows.Count < 1)
            {
                MessageBox.Show("복사할 근무일정을 선택해주세요.");
                return;
            }

            ShiftVO vo = new ShiftVO
            {
                Shift_Name = dgvShift[1, dgvShift.SelectedRows[0].Index].Value.ToString(),
                WP_Num = Convert.ToInt32(dgvShift[3, dgvShift.SelectedRows[0].Index].Value),
                Start_Time = Convert.ToInt32(dgvShift[4, dgvShift.SelectedRows[0].Index].Value),
                End_Time = Convert.ToInt32(dgvShift[5, dgvShift.SelectedRows[0].Index].Value),
                Start_Date = (DateTime)dgvShift[6, dgvShift.SelectedRows[0].Index].Value,
                End_Date = (DateTime)dgvShift[7, dgvShift.SelectedRows[0].Index].Value,
                LastMan = Convert.ToInt32(dgvShift[8, dgvShift.SelectedRows[0].Index].Value),
                LastDate = (DateTime)dgvShift[9, dgvShift.SelectedRows[0].Index].Value,
                IsUse = dgvShift[10, dgvShift.SelectedRows[0].Index].Value.ToString()
            };

            frmShift frm = new frmShift(vo, "복사");
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DataLoad();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvShift.SelectedRows.Count < 1)
            {
                MessageBox.Show("삭제할 근무일정을 선택해주세요.");
                return;
            }

            if(MessageBox.Show($"{dgvShift[0, dgvShift.SelectedRows[0].Index].Value} 번 근무일정을 삭제하시겠습니까?"
                , "삭제확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ShiftsService service = new ShiftsService();
                bool result = service.ShiftDelete(Convert.ToInt32(dgvShift[1, dgvShift.SelectedRows[0].Index].Value));

                if (result)
                {
                    MessageBox.Show(BedFactory.Properties.Settings.Default.DeleteSuccess);
                }
                else
                {
                    MessageBox.Show(BedFactory.Properties.Settings.Default.DeleteFail);
                }
            }
        }
    }
}
