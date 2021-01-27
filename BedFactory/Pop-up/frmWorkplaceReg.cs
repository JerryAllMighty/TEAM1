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
    public partial class frmWorkplaceReg : Form
    {
        public frmWorkplaceReg()
        {
            InitializeComponent();
        }

        //등록버튼
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPrcName.Text.Length < 1 || txtWpName.Text.Length < 1)
                return;

            WorkplaceVO vo = new WorkplaceVO
            {

                WP_Name = txtWpName.Text,
                WP_Note = txtWpName.Text,
                WP_Other = txtOthers.Text,
                IsDeleted = (rdoY.Checked) ? "Y" : "N",
                Firstman = 9,      // 임시로 값 대입
                Lastman = 9        // 임시로 값 대입
            };

            WorkplaceService service = new WorkplaceService();
            bool bResult = service.InsertWorkplaceInfo(vo);
            if (bResult)
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.InsertSuccess);
                this.Close();
            }
        }
    }
}
