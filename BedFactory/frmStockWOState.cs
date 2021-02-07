using BedFactory.BaseForms;
using BedFactoryService;
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
    public partial class frmStockWOState : BaseForm2
    {
        public frmStockWOState()
        {
            InitializeComponent();
        }

        private void frmStockWOState_Load(object sender, EventArgs e)
        {
            dgvWO.SetGridViewColumn("입출고일", "FirstDate");
            dgvWO.SetGridViewColumn("구분", "Category");
            dgvWO.SetGridViewColumn("카테고리", "W_Category");
            dgvWO.SetGridViewColumn("창고번호", "Str_Num");
            dgvWO.SetGridViewColumn("창고유형", "Str_Kind");
            dgvWO.SetGridViewColumn("자재명", "Mat_Name");
            dgvWO.SetGridViewColumn("자재분류", "Mat_Category");
            dgvWO.SetGridViewColumn("수불량", "Mat_Cnt");

            dtpTo.MinDate = dtpFrom.Value.AddDays(-7);
        }

        private void DataLoad()
        {
            WearingService service = new WearingService();
            dgvWO.DataSource = service.WOState(dtpFrom.Value.Date, dtpTo.Value.Date);
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            DataLoad();
            dtpTo.MinDate = dtpFrom.Value;
        }
    }
}
