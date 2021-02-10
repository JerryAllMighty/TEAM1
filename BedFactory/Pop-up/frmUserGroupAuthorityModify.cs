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
    public partial class frmUserGroupAuthorityModify : BedFactory.BaseForms.BaseForm2
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
            dgvEveryScreen.SetGridViewColumn("화면번호", "Auth_Num");
            dgvEveryScreen.SetGridViewColumn("화면명", "Auth_Name", 150);
            dgvEveryScreen.AddGridButton("추가", "btnAdd", "+", new Padding(0, 0, 0, 0), 100);
            dgvEveryScreen.CellClick += DatagridviewControl1_CellClick;

            //추가할 권한
            dgvAddAuthority.AddGridButton("제외", "btnSubtract", "-", new Padding(0, 0, 0, 0), 100);
            dgvAddAuthority.SetGridViewColumn("화면번호", "Auth_Num");
            dgvAddAuthority.SetGridViewColumn("화면명", "Auth_Name");
            
            dgvAddAuthority.CellClick += DatagridviewControl2_CellClick;
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
                AddAuthorityList.Remove(  AddAuthorityList.Find(p => p.Auth_Num == Convert.ToInt32(dgvAddAuthority[1, e.RowIndex].Value.ToString())));
                dgvAddAuthority.DataSource = null; //**
                dgvAddAuthority.DataSource = AddAuthorityList;
            }
        }


        /// <summary>
        /// 추가할 권한 리스트에 추가, 그리드 뷰에 바인딩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DatagridviewControl1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                AddAuthorityList.Add(new AuthorityVO
                {
                    ListNum = GetAuthorityListNum(),
                    Auth_Num = Convert.ToInt32(dgvEveryScreen[0, e.RowIndex].Value.ToString()),
                    Auth_Name = dgvEveryScreen[1, e.RowIndex].Value.ToString(),
                    FirstMan = 1,
                    LastMan = 1,
                    IsDeleted = "N"
                });
                dgvAddAuthority.DataSource = null; //**
                dgvAddAuthority.DataSource = AddAuthorityList;
            }
        }
        private int GetAuthorityListNum()
        {
            AuthorityService service = new AuthorityService();
            return service.GetAuthorityListNum(lblGroupCodeBinding.Text);
        }


        /// <summary>
        /// 전체 화면 목록을 그리드 뷰에 바인딩 시켜주는 함수
        /// </summary>
        private void LoadData()
        {
            AuthorityService service = new AuthorityService();
            List<AuthorityVO> list = service.GetAuthorityInfo();
            if (list != null)
            {
                dgvEveryScreen.DataSource = list;
            }
        }

        /// <summary>
        /// 추가할 권한을 DB에 저장
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1_Click_1(object sender, EventArgs e)
        {
            AuthorityService service = new AuthorityService();
            if (service.InsertAuthority(AddAuthorityList))
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.InsertSuccess);
            }
            else
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.InsertFail);
            }
        }
    }
}
