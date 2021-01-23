using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BedFactory.Util;
using BedFactoryService;

namespace BedFactory
{
    public partial class frmCommonCode : Form
    {
        public frmCommonCode()
        {
            InitializeComponent();
        }

        private void frmCommonCode_Load(object sender, EventArgs e)
        {
            dgvCommonCode.SetGridViewColumn("Code_No", "Code_No");
            dgvCommonCode.SetGridViewColumn("Code_Name", "Code_Name");
            dgvCommonCode.SetGridViewColumn("Category", "Category");
            dgvCommonCode.SetGridViewColumn("P_Code", "P_Code");

            CommonCodeService service = new CommonCodeService();
             dgvCommonCode.DataSource = service.GetCommonCodeInfo();
        }
    }
}
