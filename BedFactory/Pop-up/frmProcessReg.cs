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
        public ProcessVO EditProcess { get;  set; }
        public bool IsEditMode { get; set; }

        public frmProcessReg()
        {
            InitializeComponent();
        }

        private void frmProcessReg_Load(object sender, EventArgs e)
        {
            //콤보박스 바인딩
            List<CommonCodedVO> ccList = frmCommonCode.CheckCommonInfo();
            CommonUtil.CommonCodeBindig(cboCategory, ccList, "공정", "");

            if (IsEditMode && EditProcess != null)
            {
                cboCategory.SelectedValue = EditProcess.Process_Category;
                txtName.Text = EditProcess.Process_Name;
                txtCondition.Text = EditProcess.Process_Condition;
                if (EditProcess.IsDeleted == "Y")
                    rdoY.Checked = true;
                else
                    rdoN.Checked = true;
            }
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

            ProcessService service = new ProcessService();
            bool bResult = false;

            if (IsEditMode)
            {
                ProcessVO vo = new ProcessVO
                {
                    Process_Num = EditProcess.Process_Num,
                    Process_Category = cboCategory.SelectedValue.ToString(),
                    Process_Name = txtName.Text,
                    Process_Condition = txtCondition.Text,
                    IsDeleted = (rdoY.Checked) ? "Y" : "N",
                    Lastman = 9              // 임시로 값 대입
                };
                bResult = service.UpdateProcessInfo(vo);
                if (bResult)
                {
                    MessageBox.Show(BedFactory.Properties.Settings.Default.UpdateSuccess);
                    this.Close();
                }
            }
            else
            {
                ProcessVO vo = new ProcessVO
                {
                    Process_Category = cboCategory.SelectedValue.ToString(),
                    Process_Name = txtName.Text,
                    Process_Condition = txtCondition.Text,
                    IsDeleted = (rdoY.Checked) ? "Y" : "N",
                    Firstman = 9,            // 임시로 값 대입
                    Lastman = 9              // 임시로 값 대입
                };
                bResult = service.InsertProcessInfo(vo);
                if (bResult)
                {
                    MessageBox.Show(BedFactory.Properties.Settings.Default.InsertSuccess);
                    this.Close();
                }
            }
        }
    }
}
