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
    public partial class frmErrorList : BaseForm2
    {
        List<CommonCodeVO> list = new List<CommonCodeVO>(); //자재정보리스트
        APIMessage<List<MaterialsVO>> mat_List = new APIMessage<List<MaterialsVO>>();

        public frmErrorList()
        {
            InitializeComponent();
        }

        private void frmErrorList_Load(object sender, EventArgs e)
        {
            #region 자재종류 콤보박스 바인딩
            List<CommonCodeVO> commonList = new List<CommonCodeVO>();
            CommonCodeService service1 = new CommonCodeService();

            commonList = (from common in service1.GetCommonCodeInfo()
                          where common.Category.Equals("자재구분")
                          select common).ToList();

            CommonUtil.CommonCodeBindig(cboKind, commonList, "자재구분", "전체");
            #endregion

            #region 자재명 콤보박스 바인딩
            ServiceHelp serviceHelp = new ServiceHelp();
            mat_List = serviceHelp.GetApiCaller<List<MaterialsVO>>("api/Mat/GetAllMaterials");    //자재정보 출력(API)
            if (mat_List != null)
            {
                mat_List.Data.ForEach(p => list.Add(new CommonCodeVO { Code_Num = p.Mat_Num, Code_Name = p.Mat_Name, Category = p.Mat_Category }));
            }
            CommonUtil.CommonCodeBindig(cboName, list, "", "선택");
            #endregion

            dgvCheckInfo.SetGridViewColumn("검사항목 번호", "Check_Info_Num", visibility: false);
            dgvCheckInfo.SetGridViewColumn("검사항목", "CheckName", 500);
            dgvCheckInfo.SetGridViewColumn("검사항목 종류", "CheckKind", 200);
            dgvCheckInfo.SetGridViewColumn("검사항목 내용", "Check_Detail", 1070);
            dgvCheckInfo.SetGridViewColumn("최초등록자", "Firstman", visibility: false);
            dgvCheckInfo.SetGridViewColumn("최초등록일", "Firstdate", visibility: false);
            dgvCheckInfo.SetGridViewColumn("최종등록자", "Lastman", visibility: false);
            dgvCheckInfo.SetGridViewColumn("최종등록일", "Lastdate", visibility: false);
            dgvCheckInfo.AddGridButton("수정하기", "update", "수 정", new Padding(10, 0, 10, 0), 100);
        }

        /// <summary>
        /// 자재종류에 따른 자재명 콤보박스 필터링
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            CommonUtil.CommonCodeBindig(cboName, list, mat_Category, "선택");
        }
    }
}
