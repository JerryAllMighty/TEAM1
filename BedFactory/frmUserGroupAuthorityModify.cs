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
    public partial class frmUserGroupAuthorityModify : Form
    {
        List<AuthorityVO> AddAuthorityList = new List<AuthorityVO>();
        public frmUserGroupAuthorityModify(string groupCode, string groupName)
        {
            InitializeComponent();
            lblGroupCodeBinding.Text = groupCode;
            lblGroupNameBinding.Text = groupName;

        }

        private void frmUserGroupAuthorityModify_Load(object sender, EventArgs e)
        {
            //전체화면목록 세팅
            datagridviewControl1.SetGridViewColumn("화면번호", "Auth_Num");
            datagridviewControl1.SetGridViewColumn("화면명", "Auth_Name", 150);
            datagridviewControl1.AddGridButton("수정", "btnModify", "+", new Padding(0, 0, 0, 0), 100);
            datagridviewControl1.CellClick += DatagridviewControl1_CellClick;

            //추가할 권한
            datagridviewControl2.SetGridCheckBox("체크박스");
            datagridviewControl2.SetGridViewColumn("화면명", "Auth_Name");
            //datagridviewControl2.SetGridViewColumn("화면명", "Create");
            //datagridviewControl2.SetGridViewColumn("화면명", "Read");
            //datagridviewControl2.SetGridViewColumn("화면명", "Update");
            //datagridviewControl2.SetGridViewColumn("화면명", "Delete");

            LoadData();
        }

        private void DatagridviewControl1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AddAuthorityList.Add(new AuthorityVO
            { 
            Auth_Num = Convert.ToInt32(datagridviewControl1[0, e.RowIndex].Value.ToString()),
            Auth_Name = datagridviewControl1[1, e.RowIndex].Value.ToString()
            });
            datagridviewControl2.DataSource = AddAuthorityList;
        }

        private void LoadData()
        {
            //DB 한 번만 갔다올 수 있게 체크해봐
            AuthorityService service = new AuthorityService();
            List<AuthorityVO> list = service.GetAuthorityInfo();
            if (list != null)
            {
                datagridviewControl1.DataSource = list;
            }
        }
    }
}
