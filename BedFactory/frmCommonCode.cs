using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BedFactory.Util;
using BedFactoryService;
using BedFactoryVO;

namespace BedFactory
{
    public partial class frmCommonCode : Form
    {
        CommonCodeService service;

        //처음에 폼이 로드될 때 공통코드 정보를 가져온 후 commonList에 저장. DB에 여러 번 들리지 않기 위함.
        public static List<CommonCodedVO> commonList;

        public CommonCodedVO CommonCodeInfo
        {
            get
            {
                return new CommonCodedVO
                {
                    Code_Num = txtCode_Num.Text,
                    Code_Name = txtCode_Name.Text,
                    Category = txtCode_Category.Text,
                    P_Code = txtCode_P_Code.Text
                };
            }
        }

        public frmCommonCode()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 폼 처음 로드시, 데이터 그리드 뷰 세팅, 바인딩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCommonCode_Load(object sender, EventArgs e)
        {
            dgvCommonCode.SetGridViewColumn("Code_Num", "Code_Num");
            dgvCommonCode.SetGridViewColumn("Code_Name", "Code_Name");
            dgvCommonCode.SetGridViewColumn("Category", "Category");
            dgvCommonCode.SetGridViewColumn("P_Code", "P_Code");

            LoadData();
        }
        /// <summary>
        /// 공통코드 정보를 데이터그리드 뷰에 바인딩하는 함수
        /// </summary>
        private void LoadData()
        {
            if (commonList == null)
            {
                service = new CommonCodeService();
                if (service.GetCommonCodeInfo() != null)
                {
                    //처음 한 번만 DB를 갔다오기 위해서 처음 정보를 가져온 후 리스트에 저장
                    commonList = service.GetCommonCodeInfo();
                }
            }
            dgvCommonCode.DataSource = commonList;
        }

        /// <summary>
        /// 텍스트 박스를 비워주는 함수
        /// </summary>
        private void ClearTextBox()
        {
            txtCode_Num.Text = txtCode_Name.Text = txtCode_Category.Text = txtCode_P_Code.Text = "";
        }

        /// <summary>
        /// 유효성 체크
        /// </summary>
        private bool ValidationCheck()
        {
            if (txtCode_Num.TextLength < 1 || txtCode_Name.TextLength < 1 || txtCode_Category.TextLength < 1)
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.ValidationCheckMsg, BedFactory.Properties.Settings.Default.ValidationCheckCaption);
                return false;
            }
            return true;
        }

        /// <summary>
        /// 공통코드 등록
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!ValidationCheck())
                return;
            service = new CommonCodeService();
            if (service.InsertCommonCode(CommonCodeInfo))
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.InsertSuccess);
                LoadData();
                ClearTextBox();
            }
            else
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.InsertFail);
            }
        }

        /// <summary>
        /// 공통코드 수정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidationCheck())
                return;
            service = new CommonCodeService();
            if (service.UpdateCommonCode(CommonCodeInfo, dgvCommonCode.CurrentRow.Cells[0].Value.ToString()))
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.UpdateSuccess);
                LoadData();
                ClearTextBox();
            }
            else
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.UpdateFail);
            }
        }

        /// <summary>
        /// 공통코드 삭제
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!ValidationCheck())
                return;
            service = new CommonCodeService();
            if (service.DeleteCommonCode(CommonCodeInfo))
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.DeleteSuccess);
                LoadData();
                ClearTextBox();
            }
            else
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.DeleteFail);
            }
        }

        /// <summary>
        /// 텍스트박스에 클릭한 내용 바인딩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCommonCode_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCode_Num.Text = dgvCommonCode[0, e.RowIndex].Value.ToString();
            txtCode_Name.Text = dgvCommonCode[1, e.RowIndex].Value.ToString();
            txtCode_Category.Text = dgvCommonCode[2, e.RowIndex].Value.ToString();
            txtCode_P_Code.Text = dgvCommonCode[3, e.RowIndex].Value.ToString();

        }
    }
}
