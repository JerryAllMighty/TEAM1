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
            //그룹 목록 세팅
            datagridviewControl1.SetGridViewColumn("그룹코드", "Code_Num");
            datagridviewControl1.SetGridViewColumn("그룹명", "Code_Name");
            datagridviewControl1.AddGridButton("수정", "btnModify", "수정", new Padding(0,0,0,0), 100);

            //허용된 권한
            datagridviewControl2.SetGridViewColumn("화면코드", "Code_Num");
            datagridviewControl2.SetGridViewColumn("화면명", "Code_Name");

            LoadData();
        }

        private void LoadData()
        {
            CommonCodeService service = new CommonCodeService();
            List<CommonCodedVO>  list = service.GetCommonCodeInfo();
            if (list != null)
            {
                 var GroupList = (from groupitem in list
                                     where groupitem.Category == "그룹"
                                     select groupitem).ToList();
                datagridviewControl1.DataSource = GroupList;

                var AuthorityList = (from authitems in list
                                     where authitems.Category == "화면"
                                     select authitems).ToList();
                datagridviewControl2.DataSource = AuthorityList;
            }
        }
    }
}
