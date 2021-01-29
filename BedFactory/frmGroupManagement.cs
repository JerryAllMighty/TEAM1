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
    public partial class frmGroupManagement : Form
    {
        CommonCodeService service;
        string GroupCode;
        string GroupName;

        /// <summary>
        /// 공통코드 정보를 한 번에 넘기기 위한 프로퍼티
        /// </summary>
        public CommonCodeVO CommonCodeInfo
        {
            get
            {
                return new CommonCodeVO
                {
                    Code_Num = GroupCode,
                    Code_Name = GroupName,
                    Category = "그룹",
                    P_Code = ""
                };
            }
        }

        public frmGroupManagement()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 전체 그룹 목록 데이터 바인딩, 데이터 그리드 뷰 컬럼 세팅
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmGroupManagement_Load(object sender, EventArgs e)
        {
            dgvGroupList.SetGridViewColumn("그룹코드", "Code_Num");
            dgvGroupList.SetGridViewColumn("그룹명", "Code_Name");

            DgvSetting();
        }

        /// <summary>
        /// 데이터 그리드 뷰에 정보를 바인딩시켜주는 함수
        /// </summary>
        private void DgvSetting()
        {
            var GroupList = (from items in frmCommonCode.CheckCommonInfo()
                             where items.Category == "그룹"
                             select items).ToList();
            dgvGroupList.DataSource = GroupList;
        }

        /// <summary>
        /// 그룹 목록에서 더블 클릭시 그룹 수정 목록에 바인딩시키는 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvGroupList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           txtGroupCode.Text = dgvGroupList[0, e.RowIndex].Value.ToString();
           txtGroupName.Text = dgvGroupList[1, e.RowIndex].Value.ToString();
        }

        /// <summary>
        /// 입력받은 정보를 바탕으로 그룹 정보를 수정하는 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (lblGroupCode.Text.Length > 0)
            {
                service = new CommonCodeService();
                if (service.UpdateCommonCode(CommonCodeInfo, txtGroupCode.Text))
                {
                    MessageBox.Show(BedFactory.Properties.Settings.Default.UpdateSuccess);
                    UpdateCommonList();
                    DgvSetting();
                    ClearTextBox();
                }
                else
                {
                    MessageBox.Show(BedFactory.Properties.Settings.Default.UpdateFail);
                }
            }
        }

        /// <summary>
        /// 새로운 그룹을 추가하는 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            if (txtGroupCode2.TextLength < 1 || txtGroupName2.TextLength < 1)
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.ValidationCheckMsg, BedFactory.Properties.Settings.Default.ValidationCheckCaption);
                return;
            }
            service = new CommonCodeService();
            if (service.InsertCommonCode(CommonCodeInfo))
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.InsertSuccess);
                UpdateCommonList();
                DgvSetting();
                ClearTextBox();
            }
            else
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.InsertFail);
            }
        }

       

        /// <summary>
        /// 추가할 그룹 코드 값을 입력시 전역 변수에 담아준다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGroupCode2_TextChanged(object sender, EventArgs e)
        {
            GroupCode = txtGroupCode2.Text;
        }

        /// <summary>
        /// 추가할 그룹 이름 값을 입력시 전역 변수에 담아준다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGroupName2_TextChanged(object sender, EventArgs e)
        {
            GroupName = txtGroupName2.Text;
        }


        /// <summary>
        /// 텍스트 박스를 비워주는 함수
        /// </summary>
        private void ClearTextBox()
        {
            txtGroupCode.Text = txtGroupCode2.Text = txtGroupName.Text = txtGroupName2.Text = "";
        }

        /// <summary>
        /// 공통코드 정보가 변경되었을 시 전역 공통코드 리스트를 업데이트해주는 함수
        /// </summary>
        private void UpdateCommonList()
        {
            service = new CommonCodeService();
            if (service.GetCommonCodeInfo() != null)
            {
                frmCommonCode.commonList = service.GetCommonCodeInfo();
            }
        }

        /// <summary>
        /// 수정할 그룹 코드 값을 입력시 전역 변수에 담아준다
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGroupCode_TextChanged(object sender, EventArgs e)
        {
            GroupCode = txtGroupCode.Text;
        }

        /// <summary>
        /// /// 수정할 그룹 이름 값을 입력시 전역 변수에 담아준다
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGroupName_TextChanged(object sender, EventArgs e)
        {
            GroupName = txtGroupName.Text;
        }
    }
}
