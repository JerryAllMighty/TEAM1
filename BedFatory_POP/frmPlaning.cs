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

namespace BedFatory_POP
{
    public partial class frmPlaning : Form
    {
        List<WorkOrderVO> list;
        int hour = 0, min = 0, sec = 0;
        int timerCount = 0;
        int hour2 = 0, min2 = 0, sec2 = 0;
        int timerCount2 = 0;

        public WorkHistoryVO workhistoryinfo
        {
            get
            {
                return new WorkHistoryVO
                {
                    WO_Num = list[cboWorkPlace.SelectedIndex].WO_Num,
                    WorkCnt = lblOkayProductCnt.Text,
                    WO_StartTime = lblWorkDuration.Text,
                    WO_FinishTime = lblWorkStopTime.Text

                };
            }
        }

        public frmPlaning()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 필요 정보를 컨트롤들에 바인딩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPlaning_Load(object sender, EventArgs e)
        {
            WorkOrderService service = new WorkOrderService();
            list = service.GetWorkOrder("GJ002");
            if (list != null)
            {
                //작업장 콤보박스에 바인딩
                list.ForEach(p => cboWorkPlace.Items.Add(p.WP_Num));
            }
        }
        /// <summary>
        /// 작업자 할당
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWA_Click(object sender, EventArgs e)
        {
            frmWorkerAllocation frm = new frmWorkerAllocation(list);
            frm.Show();
            frm.Activate();
        }

        /// <summary>
        /// 작업 시작
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWS_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            timer1.Start();
            timer1.Tick += Timer1_Tick;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timerCount++;
            if (timerCount < 60)
            {
                sec = timerCount;
            }
            else if (timerCount < 3600)
            {
                min = timerCount / 60;
                sec = timerCount % 60;
            }
            else
            {
                hour = timerCount / 3600;
                min = (timerCount % 3600) / 60;
                sec = ((timerCount % 3600) % 60);
            }
            lblWorkDuration.Text = hour.ToString("00") + ":" + min.ToString("00") + ":" + sec.ToString("00");
        }
        
        /// <summary>
        /// 작업을 중지시킨다
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();
            timer2.Tick += Timer2_Tick;
        }
        private void Timer2_Tick(object sender, EventArgs e)
        {
            timerCount2++;
            if (timerCount2 < 60)
            {
                sec2 = timerCount2;
            }
            else if (timerCount2 < 3600)
            {
                min2 = timerCount2 / 60;
                sec2 = timerCount2 % 60;
            }
            else
            {
                hour2 = timerCount2 / 3600;
                min2 = (timerCount2 % 3600) / 60;
                sec2 = ((timerCount2 % 3600) % 60);
            }
            lblWorkStopTime.Text = hour2.ToString("00") + ":" + min2.ToString("00") + ":" + sec2.ToString("00");
        }
        /// <summary>
        /// 현장 마감
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinish_Click(object sender, EventArgs e)
        {
            WorkOrderService service = new WorkOrderService();
            if (service.FinishWorkOrder(list[cboWorkPlace.SelectedIndex].WO_Num))
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.UpdateSuccess);
            }
            else
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.UpdateFail);
            }
        }
        /// <summary>
        /// 생산 실적 등록
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCnt_Click(object sender, EventArgs e)
        {
            WorkHistoryService service = new WorkHistoryService();
            //마감 시점에 양품수량, 작업 시간, 작업 중지 시간, 작업 지시번호
            if (service.UpdateWorkHistoryCnt(workhistoryinfo))
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.UpdateSuccess);
            }
            else
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.UpdateFail);
            }
        }
        /// <summary>
        /// 작업장 번호 바꿀 때 마다 해당 내용이 바인딩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboWorkPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtWO_Num.Text = list[cboWorkPlace.SelectedIndex].WO_Num;
            txtWorker.Text = list[cboWorkPlace.SelectedIndex].WO_D_Emp_Num;
            txtSubject.Text = list[cboWorkPlace.SelectedIndex].Mat_Num;
            //총 오더량
            lblTotalOrderCnt.Text = list[cboWorkPlace.SelectedIndex].WO_Order_Cnt;
            //총 작업량 (양품 수량 + 불량 수량)
            lblTotalProductCnt.Text = (Convert.ToInt32(list[cboWorkPlace.SelectedIndex].WorkCnt) + Convert.ToInt32(list[cboWorkPlace.SelectedIndex].Error_Cnt)).ToString();
            //양품 수량
            lblOkayProductCnt.Text = list[cboWorkPlace.SelectedIndex].WorkCnt;
            //불량 수량
            lblErrorCnt.Text = list[cboWorkPlace.SelectedIndex].Error_Cnt;
            //오더 잔량
            lblOrderLeftCnt.Text = (Convert.ToInt32(list[cboWorkPlace.SelectedIndex].WO_Order_Cnt) - Convert.ToInt32(list[cboWorkPlace.SelectedIndex].WorkCnt)).ToString();
        }
    }
}
