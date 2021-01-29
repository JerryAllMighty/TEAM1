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

        /// <summary>
        /// 사용자 그룹별 권한관리 화면에서 수정을 원하는 그룹에 대한 정보가 바인딩되면서 폼이 로드
        /// </summary>
        /// <param name="groupCode"></param>
        /// <param name="groupName"></param>
        public frmUserGroupAuthorityModify(string groupCode, string groupName)
        {
            InitializeComponent();
            lblGroupCodeBinding.Text = groupCode;
            lblGroupNameBinding.Text = groupName;

        }

        /// <summary>
        /// 전체 화면 목록과 추가할 권한 목록의 데이터 그리드 뷰 컬럼 세팅
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmUserGroupAuthorityModify_Load(object sender, EventArgs e)
        {
            //전체화면목록 세팅
            datagridviewControl1.SetGridViewColumn("화면번호", "Auth_Num");
            datagridviewControl1.SetGridViewColumn("화면명", "Auth_Name", 150);
            datagridviewControl1.AddGridButton("추가", "btnAdd", "+", new Padding(0, 0, 0, 0), 100);
            datagridviewControl1.CellClick += DatagridviewControl1_CellClick;

            //추가할 권한
            datagridviewControl2.AddGridButton("제외", "btnSubtract", "-", new Padding(0, 0, 0, 0), 100);
            datagridviewControl2.SetGridViewColumn("화면번호", "Auth_Num");
            datagridviewControl2.SetGridViewColumn("화면명", "Auth_Name");
            
            datagridviewControl2.CellClick += DatagridviewControl2_CellClick;
            //datagridviewControl2.SetGridViewColumn("화면명", "Create");
            //datagridviewControl2.SetGridViewColumn("화면명", "Read");
            //datagridviewControl2.SetGridViewColumn("화면명", "Update");
            //datagridviewControl2.SetGridViewColumn("화면명", "Delete");

            LoadData();
        }

        /// <summary>
        /// -
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DatagridviewControl2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                AddAuthorityList.Remove(  AddAuthorityList.Find(p => p.Auth_Num == Convert.ToInt32(datagridviewControl2[1, e.RowIndex].Value.ToString())));
                datagridviewControl2.DataSource = AddAuthorityList;
            }
        }


        /// <summary>
        /// +
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DatagridviewControl1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                AddAuthorityList.Add(new AuthorityVO
                {
                    Auth_Num = Convert.ToInt32(datagridviewControl1[0, e.RowIndex].Value.ToString()),
                    Auth_Name = datagridviewControl1[1, e.RowIndex].Value.ToString()
                });
                datagridviewControl2.DataSource = AddAuthorityList;
            }
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
