using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BedFactory
{
    public partial class frmWorkOrderCreate : BedFactory.BaseForms.BaseForm2
    {
        public frmWorkOrderCreate()
        {
            InitializeComponent();
        }

        private void frmWorkOrderCreate_Load(object sender, EventArgs e)
        {
            dgvWOS.SetGridCheckBox("선택");
        }
    }
}
