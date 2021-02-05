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
    public partial class frmWorkplaceReg : Form
    {
        public WorkplaceVO editWorkSpace { get; set; }
        public bool IsEditMode { get; set; }

        public frmWorkplaceReg()
        {
            InitializeComponent();
        }
        
        private void frmWorkplaceReg_Load(object sender, EventArgs e)
        {
            // 공정상세명 콤보박스 바인딩 (DAC단으로 연결)
            ProcessService service = new ProcessService();
            List<CommonCodeVO> list = service.GetProcessCombo();
            CommonUtil.ComboBinding(cboNameD, list, "공정");

            if (IsEditMode && editWorkSpace != null)
            {
                cboNameD.SelectedValue = editWorkSpace.Process_Num.ToString();
                txtWpName.Text = editWorkSpace.WP_Name;
                txtNote.Text = editWorkSpace.WP_Note;
                txtOthers.Text = editWorkSpace.WP_Other;
                if (editWorkSpace.IsDeleted == "Y")
                    rdoY.Checked = true;
                else
                    rdoN.Checked = true;
            }
        }

        //저장버튼
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboNameD.SelectedValue.ToString().Length < 1)
            {
                return;
            }

            if (txtWpName.Text.Length < 1)
            {
                return;
            }


            WorkplaceService service = new WorkplaceService();
            bool bResult = false;

            if (IsEditMode)  // 수정
            {
                WorkplaceVO vo = new WorkplaceVO
                {
                    WP_Num = editWorkSpace.WP_Num, // VO타입에서 값을 줌 ( DAC단의 등록에서 파라미터 전달받음)
                    Process_Num = Convert.ToInt32(cboNameD.SelectedValue),
                    WP_Name = txtWpName.Text,
                    WP_Note = txtNote.Text,
                    WP_Other = txtOthers.Text,
                    IsDeleted = (rdoY.Checked) ? "Y" : "N",
                    Lastman = 9      // 임시로 값 대입
                };

                bResult = service.UpdateWorkplaceInfo(vo);
                if (bResult)
                {
                    MessageBox.Show(BedFactory.Properties.Settings.Default.UpdateSuccess);
                    this.Close();
                }
            }
            else // 저장
            { 
                WorkplaceVO vo = new WorkplaceVO
                {
                    Process_Num = Convert.ToInt32(cboNameD.SelectedValue),
                    WP_Name = txtWpName.Text,
                    WP_Note = txtNote.Text,
                    WP_Other = txtOthers.Text,
                    IsDeleted = (rdoY.Checked) ? "Y" : "N",
                    Firstman = 9,      // 임시로 값 대입
                    Lastman = 9        // 임시로 값 대입
                };

                bResult = service.InsertWorkplaceInfo(vo);
                if (bResult)
                {
                    MessageBox.Show(BedFactory.Properties.Settings.Default.InsertSuccess);
                    this.Close();
                }
            }
        }

    }
}
