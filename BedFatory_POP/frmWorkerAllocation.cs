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

namespace BedFatory_POP
{
    public partial class frmWorkerAllocation : Form
    {
        List<EmployeeVO> EmpList;
        List<WorkOrderVO> ListOver;
        List<EmployeeVO> list;
        /// <summary>
        /// 작업지시에 대한 정보를 넘겨받는다
        /// </summary>
        public frmWorkerAllocation(List<WorkOrderVO> list)
        {
            InitializeComponent();
            ListOver = list;
        }

        /// <summary>
        /// 작업지시에 대한 정보를 넘겨받아서 관련 정보를 바인딩하면서 폼이 로드된다
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmWorkerAllocation_Load(object sender, EventArgs e)
        {
            //데이터 그리드뷰 컬럼 셋팅
            dgvWorkerAvailable.SetGridViewColumn("직원 번호","Emp_Num");
            dgvWorkerAvailable.SetGridViewColumn("직원 이름", "Emp_Name", 150);

            dgvWorker.SetGridViewColumn("직원 번호", "Emp_Num");
            dgvWorker.SetGridViewColumn("직원 이름", "Emp_Name", 150);
            //작업장 콤보박스 데이터 바인딩
            ListOver.ForEach(p => cboWorkPlace.Items.Add(p.WP_Num));
        }

        /// <summary>
        /// 작업장을 선택할 시 할당 가능 작업자 바인딩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboWorkPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeesService service = new EmployeesService();
            list = service.GetEmployeeListByWPNum(cboWorkPlace.Text);
            //선택한 작업장에 따른 할당 가능 작업자 바인딩
            dgvWorkerAvailable.DataSource = list;
        }

        /// <summary>
        /// 최소화 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// 폼 닫기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 작업자를 할당 리스트로 옮김
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAllocateWorker_Click(object sender, EventArgs e)
        {
            EmpList = new List<EmployeeVO>();
            EmpList.Add(dgvWorkerAvailable.CurrentRow.DataBoundItem as EmployeeVO);
            dgvWorker.DataSource = EmpList;
        }

        /// <summary>
        /// 작업자 해제
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeallocateWorker_Click(object sender, EventArgs e)
        {
            EmpList.Remove(dgvWorker.CurrentRow.DataBoundItem as EmployeeVO);
        }

        /// <summary>
        /// 할당하려는 작업자를 DB에 저장
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (EmpList != null)
            {
                WorkOrderService service = new WorkOrderService();
                if (service.UpdateWorkOrder(ListOver, EmpList))
                {
                    MessageBox.Show(BedFactory.Properties.Settings.Default.UpdateSuccess);
                }
                else
                {
                    MessageBox.Show(BedFactory.Properties.Settings.Default.UpdateFail);
                }
            }
        }
    }
}
