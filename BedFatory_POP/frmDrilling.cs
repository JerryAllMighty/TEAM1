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
    public partial class frmDrilling : Form
    {
        List<WorkOrderVO> list;

        public frmDrilling()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 현재 폼의 데이터를 다시 바인딩해준다
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWO_Click(object sender, EventArgs e)
        {
        }


        /// <summary>
        /// 작업자 할당
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWA_Click(object sender, EventArgs e)
        {
            frmWorkerAllocation frm = new frmWorkerAllocation();
            frm.Show();
            frm.Activate();
        }

        /// <summary>
        /// 필요 정보를 컨트롤들에 바인딩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDrilling_Load(object sender, EventArgs e)
        {
            WorkOrderService service = new WorkOrderService();
            list = service.GetWorkOrder("GJ001");
            if (list != null)
            {
                //작업장 콤보박스에 바인딩
                list.ForEach(p => cboWorkPlace.Items.Add(p.WP_Num));
            }
        }

        /// <summary>
        /// 작업장 번호 바꿀 때 마다 해당 내용이 바인딩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboWorkPlace_SelectedIndexChanged_1(object sender, EventArgs e)
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
