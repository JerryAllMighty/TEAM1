using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BedFactory.BaseForms;
using BedFactory.Util;
using BedFactoryService;
using BedFactoryVO;
using BedFactory.Pop_up;

namespace BedFactory
{
    public partial class frmErrorList : BaseForm2
    {
        List<CommonCodeVO> list = new List<CommonCodeVO>(); //자재정보리스트
        List<CheckInfoVO> check_List = new List<CheckInfoVO>();

        public frmErrorList()
        {
            InitializeComponent();
        }

        private void frmErrorList_Load(object sender, EventArgs e)
        {
            #region 검사종류 콤보박스 바인딩
            List<CommonCodeVO> commonList = new List<CommonCodeVO>();
            CommonCodeService service1 = new CommonCodeService();

            commonList = service1.GetCommonCodeInfo();
            CommonUtil.CommonCodeBindig(cboKind, commonList, "검사항목", "전체");
            #endregion

            #region 검사명 콤보박스 바인딩
            btnSearch.PerformClick();
            if (check_List != null)
            {
                check_List.ForEach(p => list.Add(new CommonCodeVO { Code_Num = p.Check_Info_Num.ToString(), Code_Name = p.CheckName, Category = p.CheckKind }));
            }
            CommonUtil.CommonCodeBindig(cboName, list, cboKind.Text, "전체");
            #endregion
            
            #region 그리드뷰 세팅
            dgvCheckInfo.SetGridViewColumn("항목번호", "Check_Info_Num", visibility: false);
            dgvCheckInfo.SetGridViewColumn("검사항목", "CheckName", 500);
            dgvCheckInfo.SetGridViewColumn("검사항목 종류", "CheckKind", 200);
            dgvCheckInfo.SetGridViewColumn("검사항목 내용", "Check_Detail", 970);
            dgvCheckInfo.SetGridViewColumn("최초등록자", "Firstman", visibility: false);
            dgvCheckInfo.SetGridViewColumn("최초등록일", "Firstdate", visibility: false);
            dgvCheckInfo.SetGridViewColumn("최종등록자", "Lastman", visibility: false);
            dgvCheckInfo.SetGridViewColumn("최종등록일", "Lastdate", visibility: false);
            dgvCheckInfo.AddGridButton("수정하기", "update", "수 정", new Padding(10, 0, 10, 0), 100);
            dgvCheckInfo.AddGridButton("삭제하기", "delete", "삭 제", new Padding(10, 0, 10, 0), 100);
            #endregion
        }

        /// <summary>
        /// 자재종류에 따른 자재명 콤보박스 필터링
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category;
            if (cboKind.Text == "전체")
            {
                category = "";
            }
            else
            {
                category = cboKind.Text;
            }

            cboName.DataSource = null;
            CommonUtil.CommonCodeBindig(cboName, list, category, "전체");
        }

        /// <summary>
        /// 조회버튼
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            CheckService service = new CheckService();
            check_List = service.GetCheckInfo();
            if (check_List == null) { return; }

            string kind, name;

            if(cboKind.Text == "전체")
            {
                kind = "";
            }
            else
            {
                kind = cboKind.Text;
            }

            if(cboName.Text == "전체")
            {
                name = "";
            }
            else
            {
                name = cboName.Text;
            }

            check_List = (from list in check_List
                           where list.CheckKind.Contains(kind) && list.CheckName.Contains(name)
                           select list).ToList();

            dgvCheckInfo.DataSource = null;
            dgvCheckInfo.DataSource = check_List;
        }

        /// <summary>
        /// 그리드뷰 버튼 클릭
        /// </summary>
        private void dgvCheckInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 8 || e.RowIndex < 0) { return; }
            //수정버튼
            else if(e.ColumnIndex == 8)
            {
                frmCheckInfo frm = new frmCheckInfo();
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.Info = new CheckInfoVO
                {
                    Check_Info_Num = Convert.ToInt32(dgvCheckInfo["Check_Info_Num", e.RowIndex].Value),
                    CheckName = dgvCheckInfo["CheckName", e.RowIndex].Value.ToString(),
                    CheckKind = dgvCheckInfo["CheckKind", e.RowIndex].Value.ToString(),
                    Check_Detail = dgvCheckInfo["Check_Detail", e.RowIndex].Value.ToString(),
                    Lastman = 1
                };
                frm.formCheck = false;  //수정
                frm.ShowDialog();
            }
            //삭제버튼
            else if(e.ColumnIndex == 9)
            {
                if(MessageBox.Show("삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo) == DialogResult.No) { return; }

                CheckService service = new CheckService();
                if(service.DeleteCheckInfo(Convert.ToInt32(dgvCheckInfo["Check_Info_Num", e.RowIndex].Value)))
                {
                    MessageBox.Show("성공적으로 삭제되었습니다.", "결과");
                }
                else
                {
                    MessageBox.Show("삭제에 실패하였습니다.", "결과");
                }

                check_List.RemoveAll(p => p.Check_Info_Num.Equals(Convert.ToInt32(dgvCheckInfo["Check_Info_Num", e.RowIndex].Value)));
                dgvCheckInfo.DataSource = null;
                dgvCheckInfo.DataSource = check_List;
            }
        }

        /// <summary>
        /// 등록버튼
        /// </summary>
        private void btn2_Click_1(object sender, EventArgs e)
        {
            frmCheckInfo frm = new frmCheckInfo();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.formCheck = true;   //등록
            frm.ShowDialog();
        }
    }
}
