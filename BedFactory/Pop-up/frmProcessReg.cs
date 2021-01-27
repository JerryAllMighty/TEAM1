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

namespace BedFactory
{
    public partial class frmProcessReg : Form
    {
        public frmProcessReg()
        {
            InitializeComponent();
        }

        private void frmProcessReg_Load(object sender, EventArgs e)
        {
            //콤보박스 바인딩
            List<CommonCodedVO> ccList = frmCommonCode.CheckCommonInfo();
            CommonUtil.CommonCodeBindig(cboCategory, ccList, "공정", "");
        }

        // 저장버튼
        private void button1_Click(object sender, EventArgs e)
        {
            if (cboCategory.SelectedValue.ToString().Length < 1)
            {
                return;
            }
            if (txtName.Text.Trim().Length < 1)
            {
                return;
            }

            ProcessVO vo = new ProcessVO
            {
                Process_Category = cboCategory.SelectedValue.ToString(),
                Process_Name = txtName.Text,
                Process_Condition = txtCondition.Text,
                IsDeleted = (rdoY.Checked) ? "Y" : "N",
                Firstman = 9,            // 임시로 값 대입
                Lastman = 9              // 임시로 값 대입
            };

            ProcessService service = new ProcessService();
            bool bResult = service.InsertProcessInfo(vo);
            if (bResult)
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.InsertSuccess);
                this.Close();
            }
        }
    }
}
