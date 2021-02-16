using BedFactory.Util;
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
    public partial class frmWorkOrdersCreatePOPUP : Form
    {
        public frmWorkOrdersCreatePOPUP()
        {
            InitializeComponent();
        }

        private void frmWorkOrdersCreatePOPUP_Load(object sender, EventArgs e)
        {
            dgvWOmat.SetGridViewColumn("자재코드", " ");
            dgvWOmat.SetGridViewColumn("자재명", " ");
            dgvWOmat.SetGridViewColumn("주문수량", " ");

            // 자재명 콤보박스 바인딩 (DAC단으로 연결)
            MaterialsService matService = new MaterialsService();
            List<CommonCodeVO> matlist = matService.GetMaterialsCombo();
            CommonUtil.ComboBinding(cboMat, matlist, "자재");
        }


        //조회
        private void btnSelect_Click(object sender, EventArgs e)
        {
            string matNum = null;
            if (cboMat.SelectedValue != null)
                matNum = (cboMat.SelectedValue.ToString() == null) ? "" : cboMat.SelectedValue.ToString();

            MaterialsService service = new MaterialsService();
            List<MaterialsVO> matlist = service.GetMatCodeInfo(matNum);
            dgvWOmat.DataSource = matlist;
        }

        //등록
        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
