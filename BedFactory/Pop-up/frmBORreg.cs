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
    public partial class frmBORreg : Form
    {
        public BORVO editBOR { get; set; }
        public bool IsEditMode { get; set; }

        public frmBORreg()
        {
            InitializeComponent();
        }

        private void frmBORreg_Load(object sender, EventArgs e)
        {

            // 공정상세명 콤보박스 바인딩 (DAC단으로 연결)
            ProcessService prcService = new ProcessService();
            List<CommonCodeVO> prclist = prcService.GetProcessCombo();
            CommonUtil.ComboBinding(cboPrc, prclist, "공정");

            // 작업장명 콤보박스 바인딩 (DAC단으로 연결)
            WorkplaceService wpService = new WorkplaceService();
            List<CommonCodeVO> wplist = wpService.GetWorkplaceCombo();
            CommonUtil.ComboBinding(cboWp, wplist, "작업장");

            // 자재명 콤보박스 바인딩 (DAC단으로 연결)
            MaterialsService matService = new MaterialsService();
            List<CommonCodeVO> matlist = matService.GetMaterialsCombo();
            CommonUtil.ComboBinding(cboMat, matlist, "자재");

            if (IsEditMode && editBOR != null)
            {
                cboPrc.SelectedValue = editBOR.Process_Num.ToString();
                cboWp.SelectedValue = editBOR.WP_Num.ToString();
                cboMat.SelectedValue = editBOR.Mat_Num.ToString();
                txtTt.Text = editBOR.Tact_Time.ToString();
                txtComent.Text = editBOR.BOR_Comment;
                if (editBOR.IsUse == "Y")
                    rdoYes.Checked = true;
                else
                    rdoNo.Checked = true;
            }


        }

        //저장버튼
        private void button1_Click(object sender, EventArgs e)
        {
            if (cboPrc.SelectedValue == null || cboWp.SelectedValue == null || cboMat.SelectedValue == null)
            {
                return ;
            }

            if (cboPrc.SelectedValue.ToString().Length < 1 || cboWp.SelectedValue.ToString().Length < 1 || cboMat.SelectedValue.ToString().Length < 1)
            {
                return;
            }

            BORService service = new BORService();
            bool bResult = false;

            if (IsEditMode)  // 수정
            {
                BORVO vo = new BORVO
                {
                    BOR_Num = editBOR.BOR_Num,
                    Process_Num = Convert.ToInt32(cboPrc.SelectedValue),
                    WP_Num = Convert.ToInt32(cboWp.SelectedValue),
                    Mat_Num = cboMat.SelectedValue.ToString(),
                    Tact_Time = Convert.ToInt32(txtTt.Text),
                    BOR_Comment = txtComent.Text,
                    IsUse = (rdoYes.Checked) ? "Y" : "N",
                    Lastman = 9
                };

                bResult = service.UpdateBORInfo(vo);
                if (bResult)
                {
                    MessageBox.Show(BedFactory.Properties.Settings.Default.UpdateSuccess);
                    this.Close();
                }
            }
            else // 등록
            {
                BORVO vo = new BORVO
                {
                    Process_Num = Convert.ToInt32(cboPrc.SelectedValue),
                    WP_Num = Convert.ToInt32(cboWp.SelectedValue),
                    Mat_Num = cboMat.SelectedValue.ToString(),
                    Tact_Time = Convert.ToInt32(txtTt.Text),
                    BOR_Comment = txtComent.Text,
                    IsUse = (rdoYes.Checked) ? "Y" : "N",
                    Firstman = 9,
                    Lastman = 9
                };

                bResult = service.InsertBORInfo(vo);
                if (bResult)
                {
                    MessageBox.Show(BedFactory.Properties.Settings.Default.InsertSuccess);
                    this.Close();
                }
            }
        }
    }
}
