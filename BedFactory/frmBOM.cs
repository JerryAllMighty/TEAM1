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
using BedFactoryVO;
using BedFactoryService;
using BedFactory.Util;

namespace BedFactory
{
    public partial class frmBOM : BaseForm2
    {
        List<CommonCodeVO> list = new List<CommonCodeVO>(); //자재정보리스트
        APIMessage<List<MaterialsVO>> mat_List = new APIMessage<List<MaterialsVO>>();

        public frmBOM()
        {
            InitializeComponent();
        }
        
        private void frmBOM_Load(object sender, EventArgs e)
        {
            #region 자재종류 콤보박스 바인딩
            List<CommonCodeVO> commonList = new List<CommonCodeVO>();
            CommonCodeService service1 = new CommonCodeService();

            commonList = (from common in service1.GetCommonCodeInfo()
                          where common.Category.Equals("자재구분")
                          select common).ToList();
            CommonUtil.CommonCodeBindig(cboKind, commonList, "자재구분", "전체");
            #endregion

            #region 자재종류 버튼 바인딩
            int y = 0;
            foreach(CommonCodeVO vo in commonList)
            {
                if(vo.Code_Name == "완제품"){ continue; }    //완제품 버튼생성x
                Button btn = new Button();
                btn.Size = new Size(220, 40);
                btn.Location = new Point(5, 45 + 41 * y);
                btn.Text = vo.Code_Name;
                btn.Tag = vo.Code_Num;
                btn.Click += Btn_Click;
                btn.FlatStyle = FlatStyle.Popup;
                btn.BackColor = Color.LightSteelBlue;
                splitContainer1.Panel1.Controls.Add(btn);
                y++;
            }
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

            #region 자재종류 그리드뷰 설정
            dgvMat.SetGridViewColumn("자재번호", "Mat_Num", visibility: false);
            dgvMat.SetGridViewColumn("자재이름", "Mat_Name", 500);
            dgvMat.SetGridViewColumn("자재구분", "Mat_Category", 200);
            dgvMat.SetGridViewColumn("자재종류", "Mat_Kind", visibility: false);
            dgvMat.SetGridViewColumn("사이즈", "Mat_Size", visibility: false);
            dgvMat.SetGridViewColumn("최초등록자", "FirstMan", visibility: false);
            dgvMat.SetGridViewColumn("최초등록일", "FirstDate", visibility: false);
            dgvMat.SetGridViewColumn("최종등록자", "LastMan", visibility: false);
            dgvMat.SetGridViewColumn("최종등록일", "LastDate", visibility: false);

            dgvMat.DataSource = mat_List;   //초기 모든 자재목록 바인딩
            btnAll.PerformClick();
            #endregion

            #region BOM 그리드뷰 설정
            dgvBOM.SetGridViewColumn("BOM번호", "BOM_Num", visibility: false);
            dgvBOM.SetGridViewColumn("자재번호", "Mat_Num", visibility: false);
            dgvBOM.SetGridViewColumn("자재이름", "Mat_Name", 500);
            dgvBOM.SetGridViewColumn("자재구분", "Mat_Category", 200);
            dgvMat.SetGridViewColumn("최초등록자", "FirstMan", visibility: false);
            dgvMat.SetGridViewColumn("최초등록일", "FirstDate", visibility: false);
            dgvMat.SetGridViewColumn("최종등록자", "LastMan", visibility: false);
            dgvMat.SetGridViewColumn("최종등록일", "LastDate", visibility: false);
            #endregion
        }

        /// <summary>
        /// 자재종류 버튼 클릭 이벤트
        /// </summary>
        private void Btn_Click(object sender, EventArgs e)
        {
            string btnCartegory = sender.ToString().Replace("System.Windows.Forms.Button, Text:", "").Trim();
            List<MaterialsVO> list = new List<MaterialsVO>();
            if(btnCartegory == "전체")
            {
                btnCartegory = "";
            }

            list = (from mat in mat_List.Data
                    where mat.Mat_Category.Contains(btnCartegory)
                    select mat).ToList();

            dgvMat.DataSource = null;
            dgvMat.DataSource = list;
        }

        //자재 콤보박스 바인딩
        private void cbbKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mat_Category;
            if(cboKind.Text == "전체")
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //BOM바인딩
            List<BOMVO> bom_List = new List<BOMVO>();
            BOMService service = new BOMService();
            bom_List = service.GetBOM(cboName.SelectedItem.ToString());

            dgvBOM.DataSource = null;
            dgvBOM.DataSource = bom_List;
        }
    }
}
