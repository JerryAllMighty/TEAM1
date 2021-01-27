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
using System.Windows.Forms;

namespace BedFactory
{
    public partial class frmUserGroupAuthority : BedFactory.BaseForms.BaseForm2
    {
        public frmUserGroupAuthority()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 데이터 그리드 뷰 세팅
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmUserGroupAuthority_Load(object sender, EventArgs e)
        {
            //조회 조건의 콤보박스 바인딩
            //CommonUtil.CommonCodeBindig(cboGroupName, frmCommonCode.CheckCommonInfo(), "그룹", "");

            //그룹 목록 세팅
            dgvGroupList.SetGridViewColumn("그룹코드", "Code_Num");
            dgvGroupList.SetGridViewColumn("그룹명", "Code_Name");
            dgvGroupList.AddGridButton("수정", "btnModify", "수정", new Padding(0, 0, 0, 0), 100);
            dgvGroupList.CellClick += DgvGroupList_CellClick;
            dgvGroupList.CellContentClick += DgvGroupList_CellContentClick;

            //허용된 권한
            dgvAllowedAuthorities.SetGridViewColumn("화면번호", "Auth_Num");
            dgvAllowedAuthorities.SetGridViewColumn("화면명", "Auth_Name", 150);

            var GroupList = (from items in frmCommonCode.CheckCommonInfo()
                             where items.Category == "그룹"
                             select items).ToList();

            dgvGroupList.DataSource = GroupList;
        }

        private void DgvGroupList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmUserGroupAuthorityModify frm = new frmUserGroupAuthorityModify(dgvGroupList[0, e.RowIndex].Value.ToString(), dgvGroupList[1, e.RowIndex].Value.ToString());
            frm.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvGroupList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        /// <summary>
        /// 그룹목록 클릭시 허용된 권한 그리드뷰에 바인딩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvGroupList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AuthorityService service = new AuthorityService();
            List<AuthorityVO> authList = service.GetAuthorityInfoByGroupName(dgvGroupList[1, e.RowIndex].Value.ToString());
            if (authList != null)
            {
                dgvAllowedAuthorities.DataSource = authList;
            }

        }
    }
}
