using BedFactory.BaseForms;
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
    public partial class frmMaterialRequest : BaseForm2
    {
        public frmMaterialRequest()
        {
            InitializeComponent();
        }

        private void frmMaterialRequest_Load(object sender, EventArgs e)
        {
            dgvWorkOrder.SetGridCheckBox("chkBalzoo");
            dgvWorkOrder.SetGridViewColumn("계획시작일자", "Str_Num");
            dgvWorkOrder.SetGridViewColumn("작업지시번호", "Str_Kind");
            dgvWorkOrder.SetGridViewColumn("자재번호", "Mat_Num", visibility: false);
            dgvWorkOrder.SetGridViewColumn("자재명", "Mat_Name");
            dgvWorkOrder.SetGridViewColumn("자재유형", "Mat_Category");
            dgvWorkOrder.SetGridViewColumn("재고량", "Mat_Cnt");
        }
    }
}
