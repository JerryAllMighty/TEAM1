﻿using BedFactory.BaseForms;
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
    public partial class frmShiftInfo : BaseForm2
    {
        List<ShiftVO> list;

        public frmShiftInfo()
        {
            InitializeComponent();
        }

        private void frmShiftInfo_Load(object sender, EventArgs e)
        {
            btn4.Visible = btn5.Visible = false;

            dgvShift.SetGridViewColumn("NO.", "RowNum", 50);
            dgvShift.SetGridViewColumn("Shift번호", "Shift_Num", visibility:false);
            dgvShift.SetGridViewColumn("Shift", "Shift_Name", 60);
            dgvShift.SetGridViewColumn("작업장번호", "WP_Num");
            dgvShift.SetGridViewColumn("작업장명", "WP_Name", 200);
            dgvShift.SetGridViewColumn("시작시간", "Start_Time");
            dgvShift.SetGridViewColumn("완료시간", "End_Time");
            dgvShift.SetGridViewColumn("적용시작일자", "Start_Date");
            dgvShift.SetGridViewColumn("적용완료일자", "End_Date");
            dgvShift.SetGridViewColumn("사용유무", "IsUse");
            dgvShift.SetGridViewColumn("투입인원", "PeopleCnt", visibility: false);
            dgvShift.SetGridViewColumn("수정자", "LastMan");
            dgvShift.SetGridViewColumn("수정일", "LastDate");

            DataLoad();
        }

        private void DataLoad()
        {
            ShiftsService service = new ShiftsService();
            list = service.ShiftsSelect();
            dgvShift.DataSource = list;

            var item = list.GroupBy(p => p.WP_Name);
            List<string> temp = item.Select(p => p.Key.ToString()).ToList();
            temp.Insert(0, "전체");
            cboWork.DisplayMember = "WP_Num";
            cboWork.DataSource = temp;
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
                Shift_Name = dgvShift[2, dgvShift.SelectedRows[0].Index].Value.ToString(),
                WP_Num = Convert.ToInt32(dgvShift[3, dgvShift.SelectedRows[0].Index].Value),
                Start_Time = dgvShift[5, dgvShift.SelectedRows[0].Index].Value.ToString(),
                End_Time = dgvShift[6, dgvShift.SelectedRows[0].Index].Value.ToString(),
                Start_Date = Convert.ToDateTime(dgvShift[7, dgvShift.SelectedRows[0].Index].Value),
                End_Date = Convert.ToDateTime(dgvShift[8, dgvShift.SelectedRows[0].Index].Value),
                LastMan = Convert.ToInt32(dgvShift[11, dgvShift.SelectedRows[0].Index].Value),
                LastDate = Convert.ToDateTime(dgvShift[12, dgvShift.SelectedRows[0].Index].Value),
                IsUse = dgvShift[9, dgvShift.SelectedRows[0].Index].Value.ToString(),
                PeopleCnt = Convert.ToInt32(dgvShift[10, dgvShift.SelectedRows[0].Index].Value)
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
                Shift_Name = dgvShift[2, dgvShift.SelectedRows[0].Index].Value.ToString(),
                WP_Num = Convert.ToInt32(dgvShift[3, dgvShift.SelectedRows[0].Index].Value),
                Start_Time = dgvShift[5, dgvShift.SelectedRows[0].Index].Value.ToString(),
                End_Time = dgvShift[6, dgvShift.SelectedRows[0].Index].Value.ToString(),
                Start_Date = Convert.ToDateTime(dgvShift[7, dgvShift.SelectedRows[0].Index].Value),
                End_Date = Convert.ToDateTime(dgvShift[8, dgvShift.SelectedRows[0].Index].Value),
                LastMan = Convert.ToInt32(dgvShift[11, dgvShift.SelectedRows[0].Index].Value),
                LastDate = Convert.ToDateTime(dgvShift[12, dgvShift.SelectedRows[0].Index].Value),
                IsUse = dgvShift[9, dgvShift.SelectedRows[0].Index].Value.ToString(),
                PeopleCnt = Convert.ToInt32(dgvShift[10, dgvShift.SelectedRows[0].Index].Value)
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
                    DataLoad();
                }
                else
                {
                    MessageBox.Show(BedFactory.Properties.Settings.Default.DeleteFail);
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e) //조회
        {
            if (cboWork.SelectedIndex == 0)
            {
                dgvShift.DataSource = list;
            }
            else
            {
                dgvShift.DataSource = list.Where(p => p.WP_Name == cboWork.Text).ToList();
            }

            dgvShift.ClearSelection();
        }
    }
}

