using BedFactory.Pop_up;
using BedFactory.Util;
using BedFactoryService;
using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BedFactory
{
    public partial class frmBOR : BedFactory.BaseForms.BaseForm2
    {
        public frmBOR()
        {
            InitializeComponent();
        }

        public List<BORVO> borList;


        private void frmBOR_Load(object sender, EventArgs e)
        {
            dgvBOR.SetGridCheckBox("선택");
            dgvBOR.SetGridViewColumn("BOR번호", "BOR_Num");
            dgvBOR.SetGridViewColumn("상세공정명", "Process_Name_D");
            dgvBOR.SetGridViewColumn("작업장명", "WP_Name");
            dgvBOR.SetGridViewColumn("자재종류", "Mat_Category");
            dgvBOR.SetGridViewColumn("자재명", "Mat_Name");
            dgvBOR.SetGridViewColumn("소요시간", "Tact_Time");
            dgvBOR.SetGridViewColumn("사용유무", "IsUse");
            dgvBOR.SetGridViewColumn("비고", "BOR_Comment");
            dgvBOR.SetGridViewColumn("최초등록자", "Firstman");
            dgvBOR.SetGridViewColumn("최초등록일", "Firstdate");
            dgvBOR.SetGridViewColumn("최종등록자", "Lastman");
            dgvBOR.SetGridViewColumn("최종등록일", "Lastdate");
            dgvBOR.SetGridViewColumn("공정번호", "Process_Num", visibility: false);
            dgvBOR.SetGridViewColumn("작업장번호", "WP_Num", visibility: false);
            dgvBOR.SetGridViewColumn("자재번호", "Mat_Num", visibility: false);


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
        }

        //조회
        private void btnSelect_Click(object sender, EventArgs e)
        {
            int prcNum = 0;
            if (cboPrc.SelectedValue != null)
                prcNum = (cboPrc.SelectedValue.ToString() == "") ? 0 : Convert.ToInt32(cboPrc.SelectedValue);

            int wpNum = 0;
            if (cboWp.SelectedValue != null)
                wpNum = (cboWp.SelectedValue.ToString() == "") ? 0 : Convert.ToInt32(cboWp.SelectedValue);

            string matNum = null;
            if (cboMat.SelectedValue != null)
                matNum = (cboMat.SelectedValue.ToString() == null) ? "" : cboMat.SelectedValue.ToString();

            BORService service = new BORService();
            List<BORVO> list = service.GetBorInfo(prcNum, wpNum, matNum);
            dgvBOR.DataSource = list;
        }

        //등록
        public override void btn3_Click(object sender, EventArgs e)
        {
            frmBORreg frm = new frmBORreg();
            frm.ShowDialog();
        }

        //수정
        public override void btn2_Click(object sender, EventArgs e)
        {
            if (dgvBOR.SelectedRows.Count < 1) return;

            var item = dgvBOR.SelectedRows[0];

            BORVO vo = new BORVO
            {
                Process_Num = Convert.ToInt32(item.Cells["Process_Num"].Value),
                WP_Num = Convert.ToInt32(item.Cells["WP_Num"].Value),
                Mat_Num = item.Cells["Mat_Num"].Value.ToString(),
                Tact_Time = Convert.ToInt32(item.Cells["Tact_Time"].Value),
                IsUse = item.Cells["IsUse"].Value.ToString(),
                BOR_Comment = item.Cells["BOR_Comment"].Value.ToString()
            };


            frmBORreg frm = new frmBORreg();
            frm.editBOR = vo;
            frm.IsEditMode = true;
            frm.ShowDialog();
        }

        /// <summary>
        /// BOR 정보를 데이터그리드 뷰에 바인딩하는 함수
        /// </summary>
        private void LoadData()
        {
            BORService service = new BORService();
            if (service.GetBORAllInfo() != null)
            {
                borList = service.GetBORAllInfo();
            }
            dgvBOR.DataSource = borList;
        }

        //삭제
        public override void btn1_Click(object sender, EventArgs e)
        {
            if (dgvBOR.SelectedRows.Count < 1)
            {
                MessageBox.Show("삭제할 BOR정보를 선택해주세요.");
                return;
            }

            if (MessageBox.Show($"{dgvBOR[1, dgvBOR.SelectedRows[0].Index].Value} 번 근무일정을 삭제하시겠습니까?"
                , "삭제확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                BORService service = new BORService();
                bool result = service.DeleteBORInfo(Convert.ToInt32(dgvBOR[1, dgvBOR.SelectedRows[0].Index].Value));

                if (result)
                {
                    MessageBox.Show(BedFactory.Properties.Settings.Default.DeleteSuccess);
                }
                else
                {
                    MessageBox.Show(BedFactory.Properties.Settings.Default.DeleteFail);
                }
            }
        }
    }
}
