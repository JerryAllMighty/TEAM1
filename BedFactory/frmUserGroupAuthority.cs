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
        List<AuthorityVO> authList;

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
            //그룹 목록 세팅
            dgvGroupList.SetGridViewColumn("그룹코드", "Code_Num");
            dgvGroupList.SetGridViewColumn("그룹명", "Code_Name");
            dgvGroupList.AddGridButton("수정", "btnModify", "수정", new Padding(0, 0, 0, 0), 100);
            dgvGroupList.CellClick += DgvGroupList_CellClick;

            //허용된 권한
            dgvAllowedAuthorities.SetGridViewColumn("권한번호", "Auth_Num");
            dgvAllowedAuthorities.SetGridViewColumn("메뉴명", "Auth_Name", 150);

            var GroupList = (from items in frmCommonCode.CheckCommonInfo()
                             where items.Category == "그룹"
                             select items).ToList();

            dgvGroupList.DataSource = GroupList;
        }

        /// <summary>
        /// 해당 그룹 권한 수정 폼 열기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvGroupList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                frmUserGroupAuthorityModify frm = new frmUserGroupAuthorityModify(dgvGroupList[0, e.RowIndex].Value.ToString(), dgvGroupList[1, e.RowIndex].Value.ToString(), authList);
                frm.ShowDialog();
            }
        }

        /// <summary>
        /// 그룹목록 클릭시 허용된 권한 그리드뷰에 바인딩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvGroupList_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            AuthorityService service = new AuthorityService();
            authList = service.GetAuthorityInfoByGroupName(dgvGroupList[1, e.RowIndex].Value.ToString());
            if (authList != null)
            {
                dgvAllowedAuthorities.DataSource = authList;
            }
        }
    }
}
