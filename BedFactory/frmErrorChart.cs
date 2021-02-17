using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BedFactory.BaseForms;
using BedFactory.Util;
using BedFactoryService;
using BedFactoryVO;

namespace BedFactory
{
    public partial class frmErrorChart : BaseForm2
    {
        List<CommonCodeVO> list = new List<CommonCodeVO>(); //자재정보리스트
        APIMessage<List<MaterialsVO>> mat_List = new APIMessage<List<MaterialsVO>>();

        public frmErrorChart()
        {
            InitializeComponent();
        }

        private void frmErrorChart_Load(object sender, EventArgs e)
        {
            #region 자재종류 / 불량유형 콤보박스 바인딩
            List<CommonCodeVO> allCommon = new List<CommonCodeVO>();
            CommonCodeService service1 = new CommonCodeService();

            allCommon = service1.GetCommonCodeInfo();

            CommonUtil.CommonCodeBindig(cboKind, allCommon, "자재구분", "전체");
            CommonUtil.CommonCodeBindig(cboErrorKind, allCommon, "불량유형", "전체");
            #endregion

            #region 자재명 콤보박스 바인딩
            ServiceHelp serviceHelp = new ServiceHelp();
            mat_List = serviceHelp.GetApiCaller<List<MaterialsVO>>("api/Mat/GetAllMaterials");    //자재정보 출력(API)
            if (mat_List != null)
            {
                mat_List.Data.ForEach(p => list.Add(new CommonCodeVO { Code_Num = p.Mat_Num, Code_Name = p.Mat_Name, Category = p.Mat_Category }));
            }
            CommonUtil.CommonCodeBindig(cboName, list, "", "전체");
            #endregion

            #region 그리드뷰 세팅
            dgvErrorList.SetGridViewColumn("작업이력번호", "WH_Num", 200);
            dgvErrorList.SetGridViewColumn("작업지시번호", "WO_Num", visibility: false);
            dgvErrorList.SetGridViewColumn("작업개수", "WorkCnt", 200);
            dgvErrorList.SetGridViewColumn("불량유형", "ErrorKind", 270);
            dgvErrorList.SetGridViewColumn("불량개수", "ErrorCnt", 200);
            dgvErrorList.SetGridViewColumn("작업자", "Firstman", visibility:false);
            dgvErrorList.SetGridViewColumn("작업일자", "Firstdate", 200);
            dgvErrorList.SetGridViewColumn("불량률", "Persent", 200);
            dgvErrorList.SetGridViewColumn("자재명", "Mat_Name", 300);
            dgvErrorList.SetGridViewColumn("자재구분", "Mat_Category",300);
            #endregion

            btnSearch.PerformClick();
        }

        private void cbbKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mat_Category;
            if (cboKind.Text == "전체")
            {
                mat_Category = "";
                
            }
            else
            {
                mat_Category = cboKind.Text;
            }
            cboName.DataSource = null;
            CommonUtil.CommonCodeBindig(cboName, list, mat_Category, "전체");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string category1, category2, category3 = "";

            #region 필터링
            if (cboKind.Text == "전체")
            {
                category1 = "";
            }
            else
            {
                category1 = cboKind.Text;
            }

            if(cboName.Text == "전체")
            {
                category2 = "";
            }
            else
            {
                category2 = cboName.Text;
            }

            if(cboErrorKind.Text == "전체")
            {
                category3 = "";
            }
            else
            {
                category3 = cboErrorKind.Text;
            }
            #endregion

            ErrorService service = new ErrorService();
            List<ErrorHistoryVO> vo = new List<ErrorHistoryVO>();
            vo = service.GetErrorHistory();
            
            dgvErrorList.DataSource = null;

            if(vo == null) { return; }
            dgvErrorList.DataSource = (from list in vo
                                       where list.Mat_Category.Contains(category1) && list.Mat_Name.Contains(category2) && list.ErrorKind.Contains(category3)
                                       select list).ToList(); 
        }
    }
}
