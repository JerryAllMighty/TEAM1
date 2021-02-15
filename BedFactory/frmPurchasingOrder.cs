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
    public partial class frmPurchasingOrder : BaseForm2
    {
        List<BalzooVO> list;
        DateTime bFrom;
        DateTime bTo;

        public frmPurchasingOrder()
        {
            InitializeComponent();
        }

        private void frmPurchasingOrder_Load(object sender, EventArgs e)
        {
            bFrom = DateTime.Now.AddYears(3333);
            bTo = DateTime.Now.AddYears(3333);

            dtpTo.Value = DateTime.Now.Date.AddDays(14);
            dtpTo.MinDate = dtpFrom.Value.Date;

            BalzooService service = new BalzooService();
            List<string> temp = service.SearchPlanNum().Select(p => p.Demand_Plan_Num.ToString()).ToList();
            temp.Insert(0, "선택");
            cboPlan.DisplayMember = "Demand_Plan_Num";
            cboPlan.DataSource = temp;
        }

        private void GridColumnDateSet()
        {
            if (bFrom.ToShortDateString() != dtpFrom.Value.ToShortDateString() || bTo.ToShortDateString() != dtpTo.Value.ToShortDateString())
            {
                dgvBalzoo.Columns.Clear();

                dgvBalzoo.SetGridViewColumn("자재명", "Mat_Num");
                dgvBalzoo.SetGridViewColumn("카테고리", "Category");

                List<DateTime> DayList = GetFromToDays(dtpFrom.Value.Date, dtpTo.Value.Date);
                DayList.ForEach(p =>
                {
                    dgvBalzoo.SetGridViewColumn($"{p.ToShortDateString()}", $"{p.ToShortDateString()}");
                });

                BalzooService service = new BalzooService();
                list = service.BalzooAndM_Use(int.Parse(cboPlan.Text));
            }

            dgvBalzoo.Rows.Clear();

            list.ForEach(p =>
            {
                bool isChange = false;

                if (!isChange)
                {
                    object[] ob1 = new object[dgvBalzoo.ColumnCount];
                    ob1[0] = p.Mat_Name;
                    ob1[1] = "소요량";
                    for (int i = 2; i < ob1.Length; i++)
                    {
                        if (p.FirstDate != null && dgvBalzoo.Columns[i].Name == p.FirstDate.ToShortDateString())
                        {
                            ob1[i] = p.MaterialUse_Cnt;
                        }
                        else
                        {
                            ob1[i] = 0;
                        }
                    }
                    dgvBalzoo.Rows.Add(ob1);

                    object[] ob2 = new object[dgvBalzoo.ColumnCount];
                    ob2[0] = "";
                    ob2[1] = "balance";
                    for (int i = 2; i < ob2.Length; i++)
                    {
                        p.Mat_Cnt = p.Mat_Cnt - Convert.ToInt32(ob1[i]);
                        ob2[i] = p.Mat_Cnt;
                    }
                    dgvBalzoo.Rows.Add(ob2);

                    object[] ob3 = new object[dgvBalzoo.ColumnCount];
                    ob3[0] = "";
                    ob3[1] = "발주제안";
                    for (int i = 2; i < ob3.Length; i++)
                    {
                        if (Convert.ToInt32(ob1[i]) != 0 && i>3)
                        {
                            ob3[i-2] = ob1[i];
                        }
                        else
                        {
                            ob3[i] = 0;
                        }
                    }
                    dgvBalzoo.Rows.Add(ob3);
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(cboPlan.Text != "선택")
            {
                dtpTo.MinDate = dtpFrom.Value.Date;
                GridColumnDateSet();
                dgvBalzoo.ClearSelection();
            }            
        }

        private void btn3_Click_1(object sender, EventArgs e) //발주
        {
            frmPurchasing frm = new frmPurchasing(list);
            frm.Show();
        }
    }
}
