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
    public partial class frmUserGroupManagement : BedFactory.BaseForms.BaseForm2
    {
        List<EmployeeVO> list;
        public frmUserGroupManagement()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 폼이 로드될 때, 데이터그리드뷰들 컬럼 세팅
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmUserGroupManagement_Load(object sender, EventArgs e)
        {
            //사용자 목록 세팅
            dgvUserList.SetGridViewColumn("직원ID", "Emp_Num");
            dgvUserList.SetGridViewColumn("직원명", "Emp_Name");
            dgvUserList.SetGridViewColumn("직원구분", "Emp_Category");

            //사용자 그룹 목록 세팅
            dgvUserGroupList.SetGridViewColumn("그룹코드", "ListNum");
            dgvUserGroupList.SetGridViewColumn("그룹명", "Emp_Department");

            //그룹별 직원 리스트 세팅
            dgvGroupEmpList.SetGridViewColumn("직원ID", "Emp_Num");
            dgvGroupEmpList.SetGridViewColumn("직원명", "Emp_Name");
            dgvGroupEmpList.SetGridViewColumn("직원구분", "Emp_Category");
        }


        /// <summary>
        /// 저장 버튼 클릭시 변경 내용 저장
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1_Click_1(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 조회 버튼 클릭 시 검색 이름에 해당하는 사용자를 그리드 뷰에 바인딩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            EmployeesService service = new EmployeesService();
            list = service.GetEmployeeListByEmpName(txtEmpName.Text);
            if (list != null)
            {
                dgvUserList.DataSource = list;
            }
        }

        /// <summary>
        /// 사용자 목록 더블 클릭시 사용자 그룹 목록으로 바인딩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUserList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvUserGroupList.DataSource = list;
        }

        /// <summary>
        /// 사용자 그룹 클릭시 해당 그룹의 구성원 바인딩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUserGroupList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EmployeesService service = new EmployeesService();
            List<EmployeeVO> list = service.GetMembersofGroup(dgvUserGroupList[1, e.RowIndex].Value.ToString());
            if (list != null)
            {
                dgvGroupEmpList.DataSource = list;
            }
        }
    }
}
