using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BedFactory.BaseForms;
using BedFactoryService;
using BedFactoryVO;

namespace BedFactory
{
    public partial class frmShipment : BaseForm2
    {
        public frmShipment()
        {
            InitializeComponent();
        }

        private void frmShipment_Load(object sender, EventArgs e)
        {
            #region 주문상태 콤보박스 바인딩
            cboState.Items.Add("전체");
            cboState.Items.Add("상품준비중");
            cboState.Items.Add("출하완료");
            cboState.SelectedIndex = 0;
            #endregion

            #region 그리드뷰 세팅
            dgvOrders.SetGridViewColumn("주문번호", "Order_Num", visibility: false);
            dgvOrders.SetGridViewColumn("거래처번호", "Com_Num", visibility: false);
            dgvOrders.SetGridViewColumn("거래처 명", "Com_Name", 500);
            dgvOrders.SetGridViewColumn("주문일자", "Order_Date", 200);
            dgvOrders.SetGridViewColumn("주문상태", "Order_Status", 300);
            dgvOrders.AddGridButton("출하지시", "Output", "출하", new Padding(20, 0, 20, 0), 150);
            #endregion
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string status;
            if(cboState.Text == "전체")
            {
                status = "";
            }
            else
            {
                status = cboOrderState.Text;
            }

            List<OrderVO> list = new List<OrderVO>();
            OrderService service = new OrderService();
            list = service.GetOrders();

            var order_List = (from order in list
                              where order.Order_Status.Contains(status) && order.Order_Date.Date >= dtpStart.Value.Date && order.Order_Date <= dtpEnd.Value.Date
                              select order).ToList();

            dgvOrders.DataSource = null;
            dgvOrders.DataSource = order_List;
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0 || e.ColumnIndex != 5) { return; }
            if(dgvOrders["Order_Status", e.RowIndex].Value.ToString().Trim() == "출하완료")
            {
                MessageBox.Show("이미 출하가 완료된 주문입니다.");
                return;
            }

            ShipmentService service = new ShipmentService();
            if(service.Shipmentcomplete(Convert.ToInt32(dgvOrders["Order_Num", e.RowIndex].Value)))
            {
                btnSearch.PerformClick();
            }
            else
            {
                MessageBox.Show("재고량이 부족합니다.\n확인 후 다시 시도하여주십시오.");
                return;
            }
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            dtpStart.MaxDate = dtpEnd.Value.Date;
        }
    }
}
