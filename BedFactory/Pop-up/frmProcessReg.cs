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
            //등록 수정 폼의 공정종류 콤보박스 바인딩
            List<CommonCodeVO> ccList = frmCommonCode.CheckCommonInfo();
            CommonUtil.CommonCodeBindig(cboCategory_Code, ccList, "공정", "");

            if (IsEditMode && EditProcess != null) // ?
            {
                cboCategory_Code.SelectedValue = EditProcess.Process_Code;
                txtName.Text = EditProcess.Process_Name_D;
                txtCondition.Text = EditProcess.Process_Condition;
                if (EditProcess.IsDeleted == "N")
                    rdoY.Checked = true;
                else
                    rdoN.Checked = true;
            }
        }

        // 저장버튼
        private void button1_Click(object sender, EventArgs e)
        {
            if (cboCategory_Code.SelectedValue.ToString().Length < 1 )
            {
                return;
            }

            if(txtName.Text.Trim().Length < 1)
            {
                return;
            }

            ProcessService service = new ProcessService();
            bool bResult = false;

            if (IsEditMode)  // 수정
            {
                ProcessVO vo = new ProcessVO
                {
                    Process_Num = EditProcess.Process_Num, // VO타입에서 값을 줌 ( DAC단의 등록에서 파라미터 전달받음)
                    Process_Code = cboCategory_Code.SelectedValue.ToString(),
                    Process_Name_D = txtName.Text,
                    Process_Condition = txtCondition.Text,
                    IsDeleted = (rdoY.Checked) ? "Y" : "N",
                    Lastman = 9        // 임시로 값 대입    
                };

                bResult = service.UpdateProcessInfo(vo);
                if (bResult)
                {
                    MessageBox.Show(BedFactory.Properties.Settings.Default.UpdateSuccess);
                    this.Close();
                }
            }

            else // 등록
            {
                ProcessVO vo = new ProcessVO
                {
                    Process_Code = cboCategory_Code.SelectedValue.ToString(),
                    Process_Name_D = txtName.Text,
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
