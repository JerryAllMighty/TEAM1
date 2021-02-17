using BedFactory.BaseForms;
using BedFactory.Pop_up;
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
    public partial class frmShiftMangement : BaseForm2
    {
        List<ShiftVO> list;
        DateTime bFrom;
        DateTime bTo;

        public frmShiftMangement()
        {
            InitializeComponent();
        }

        private void frmShiftMangement_Load(object sender, EventArgs e)
        {
            btn5.Visible = false;

            bFrom = DateTime.Now.AddYears(3333);
            bTo = DateTime.Now.AddYears(3333);

            dtpFrom.Value = DateTime.Now.Date.AddDays(-7);
            dtpTo.MinDate = dtpFrom.Value.Date;

            GridColumnDateSet();
        }

        private void GridColumnDateSet()
        {
            if (bFrom.ToShortDateString() != dtpFrom.Value.ToShortDateString() || bTo.ToShortDateString() != dtpTo.Value.ToShortDateString())
            {
                dgvShift.Columns.Clear();

                dgvShift.SetGridViewColumn("Shift번호", "Shift_Num", visibility: false);
                dgvShift.SetGridViewColumn("작업장명", "WP_Name", 200);
                dgvShift.SetGridViewColumn("Shift", "Shift_Name");

                List<DateTime> DayList = GetFromToDays(dtpFrom.Value.Date, dtpTo.Value.Date);
                DayList.ForEach(p =>
                {
                    dgvShift.SetGridViewColumn($"{p.ToShortDateString()}", $"{p.ToShortDateString()}");
                });

                ShiftsService service = new ShiftsService();
                list = service.ShiftChangeSelect();

                var item = list.GroupBy(p => p.WP_Name);
                List<string> temp = item.Select(p => p.Key.ToString()).ToList();
                temp.Insert(0, "전체");
                cboWork.DisplayMember = "WP_Name";
                cboWork.DataSource = temp;
            }

            List<ShiftVO> shiftsList = new List<ShiftVO>();
            if (cboWork.SelectedIndex == 0)
            {
                shiftsList = list;
            }
            else
            {
                shiftsList = list.Where(p => p.WP_Name == cboWork.Text).ToList();
            }

            dgvShift.Rows.Clear();

            shiftsList.ForEach(p =>
            {
                bool isChange = false;

                foreach(DataGridViewRow row in dgvShift.Rows)
                {
                    if (dgvShift[0, row.Index].Value != null && p.Shift_Num.ToString() == dgvShift[0, row.Index].Value.ToString())
                    {
                        for (int i = 3; i < dgvShift.Columns.Count - 1; i++)
                        {
                            if (dgvShift.Columns[i].Name == p.Change_Date.ToShortDateString())
                            {
                                dgvShift[i ,row.Index].Value = p.Start_Time;
                                dgvShift[i, row.Index + 1].Value = p.End_Time;
                                dgvShift[i, row.Index + 2].Value = p.PeopleCnt;

                                isChange = true;
                            }
                        }
                    }
                }

                if (!isChange)
                {
                    object[] ob1 = new object[dgvShift.ColumnCount];
                    ob1[0] = p.Shift_Num;
                    ob1[1] = p.WP_Name;
                    ob1[2] = p.Shift_Name;
                    for (int i = 3; i < ob1.Length; i++)
                    {
                        if (p.Change_Date != null && dgvShift.Columns[i].Name == p.Change_Date.ToShortDateString())
                        {
                            ob1[i] = p.Start_Time;
                        }
                        else
                        {
                            if(Convert.ToDateTime(dgvShift.Columns[i].Name).Date >= p.Start_Date.Date && Convert.ToDateTime(dgvShift.Columns[i].Name).Date <= p.End_Date.Date)
                            {
                                ob1[i] = p.Before_Start_Time; //기본 시작시간
                            }
                            else
                            {
                                ob1[i] = "해당없음";
                            }
                        }
                    }
                    dgvShift.Rows.Add(ob1);

                    object[] ob2 = new object[dgvShift.ColumnCount];
                    ob2[0] = "";
                    ob2[1] = "";
                    ob2[2] = "";
                    for (int i = 3; i < ob2.Length; i++)
                    {
                        if (p.Change_Date != null && dgvShift.Columns[i].Name == p.Change_Date.ToShortDateString())
                        {
                            ob2[i] = p.End_Time;
                        }
                        else
                        {
                            if (Convert.ToDateTime(dgvShift.Columns[i].Name).Date >= p.Start_Date.Date && Convert.ToDateTime(dgvShift.Columns[i].Name).Date <= p.End_Date.Date)
                            {
                                ob2[i] = p.After_End_Time; //기본 완료시간
                            }
                            else
                            {
                                ob2[i] = "해당없음";
                            }                            
                        }
                    }
                    dgvShift.Rows.Add(ob2);

                    object[] ob3 = new object[dgvShift.ColumnCount];
                    ob3[0] = "";
                    ob3[1] = "";
                    ob3[2] = "";
                    for (int i = 3; i < ob3.Length; i++)
                    {
                        if (p.Change_Date != null && dgvShift.Columns[i].Name == p.Change_Date.ToShortDateString())
                        {
                            ob3[i] = p.PeopleCnt;
                        }
                        else
                        {
                            if (Convert.ToDateTime(dgvShift.Columns[i].Name).Date >= p.Start_Date.Date && Convert.ToDateTime(dgvShift.Columns[i].Name).Date <= p.End_Date.Date)
                            {
                                ob3[i] = p.Before_PeopleCnt; //기본 인원
                            }
                            else
                            {
                                ob3[i] = "해당없음";
                            }                            
                        }
                    }
                    dgvShift.Rows.Add(ob3);
                }
                
            });

            bFrom = dtpFrom.Value.Date;
            bTo = dtpTo.Value.Date;
        }

        private List<DateTime> GetFromToDays(DateTime FromDate, DateTime ToDate)
        {
            List<DateTime> DayList = new List<DateTime>();

            DateTime dtFrom = FromDate.Date;
            DateTime dtTo = ToDate.Date;

            while (dtFrom <= dtTo)
            {
                DayList.Add(dtFrom.Date);
                dtFrom = dtFrom.Date.AddDays(1);
            }

            return DayList;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (dgvShift.SelectedRows.Count < 1)
                return;

            int i = dgvShift.SelectedRows[0].Index;
            while (dgvShift[0, i].Value.ToString().Trim().Equals(""))
            {
                i--;

                if (dgvShift[1, i].Value.ToString().Trim().Equals(""))
                {
                    i--;
                }
            }

            Dictionary<string, List<int>> changeDic = new Dictionary<string, List<int>>();
            for(int k = 3; k < dgvShift.Columns.Count - 1; k++)
            {
                if(!dgvShift[k, i].Value.ToString().Equals("해당없음"))
                {
                    List<int> list = new List<int>();
                    list.Add(Convert.ToInt32(dgvShift[k, i].Value));
                    list.Add(Convert.ToInt32(dgvShift[k, i + 1].Value));
                    list.Add(Convert.ToInt32(dgvShift[k, i + 2].Value));

                    changeDic.Add(dgvShift.Columns[k].Name, list);
                }                
            }

            if (changeDic.Count > 0)
            {
                frmShiftChange frm = new frmShiftChange(dgvShift[0, i].Value.ToString(), changeDic);
                if(frm.ShowDialog() == DialogResult.Yes)
                {
                    bFrom = DateTime.Now.AddYears(3333);
                    bTo = DateTime.Now.AddYears(3333);

                    GridColumnDateSet();
                }                
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtpTo.MinDate = dtpFrom.Value.Date;
            GridColumnDateSet();
            dgvShift.ClearSelection();
        }
    }
}
