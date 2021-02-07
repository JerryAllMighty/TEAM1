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
    public partial class frmStockBackgroundCheck : Form
    {
        List<WearingVO> list;

        public frmStockBackgroundCheck(int sNum, int mNum)
        {
            InitializeComponent();

            WearingService service = new WearingService();
            list = service.StockStateSearch(sNum, mNum);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStockBackgroundCheck_Load(object sender, EventArgs e)
        {
            if(list != null)
            {
                dgvState.SetGridViewColumn("창고번호", "Str_Num");
                dgvState.SetGridViewColumn("창고유형", "Str_Kind");
                dgvState.SetGridViewColumn("자재명", "Mat_Name");
                dgvState.SetGridViewColumn("자재유형", "Mat_Kind");
                dgvState.SetGridViewColumn("수량", "Mat_Cnt");
                dgvState.SetGridViewColumn("수정일", "FirstDate");
                dgvState.SetGridViewColumn("카테고리", "W_Category");

                dgvState.DataSource = list;
            }            
        }
    }
}
