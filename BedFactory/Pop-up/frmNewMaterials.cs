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

namespace BedFactory.Pop_up
{
    public partial class frmNewMaterials : Form
    {
        int materialID, checkID; //자재ID, 검사ID
        List<CommonCodedVO> p_List = new List<CommonCodedVO>();
        List<MaterialsVO> m_List = new List<MaterialsVO>();

        private void frmNewMaterials_Load(object sender, EventArgs e)
        {
            #region 트리노드 바인딩(카테고리)
            CommonCodeService service = new CommonCodeService();
            p_List = (from common in service.GetCommonCodeInfo()
                      where common.Category == "자재종류"
                      select common).ToList();

            foreach(CommonCodedVO item in p_List)
            {
                trvMaterials.Nodes.Add(item.Code_Name);
            }
            #endregion

            #region 자식노드 바인딩(자재정보)
            ServiceHelp serviceHelp = new ServiceHelp();
            APIMessage<List<MaterialsVO>> result = serviceHelp.GetApiCaller<List<MaterialsVO>>("api/materials/all");    //자재정보 출력(API)

            //자재정보가 있을경우
            if (result.Data != null)
            {
                m_List = result.Data;

                List<CommonCodedVO> list = new List<CommonCodedVO>();   //공통코드 변수선언
                //공통코드 리스트 형태로 재구성
                m_List.ForEach(p => list.Add(new CommonCodedVO { Code_Num = p.Mat_Num, Code_Name = p.Mat_Name, Category = p.Mat_Category }));

                //자식노드 바인딩
                foreach (CommonCodedVO vo in p_List)    //부모노드 
                {
                    CommonUtil.AddTreeNode(trvMaterials.Nodes[vo.Code_Num], list, vo.Code_Name, false);
                }
            }
            #endregion
        }

        public frmNewMaterials()
        {
            InitializeComponent();
        }

        private void trvMaterials_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            trvMaterials.SelectedNode = e.Node;
            List<string> arrStr = new List<string>();

            p_List.ForEach(p => arrStr.Add(p.Code_Name));
            if(arrStr.Contains(e.Node.Name)) { return; }

            List<MaterialsVO> list = (from item in m_List
                                      where item.Mat_Name.Equals(e.Node.Name)
                                      select item).ToList();

            lctProductName.text.Text = list[0].Mat_Name;
            ontSizeX.Text = list[0].Mat_Size.Split('/')[0].Trim();
            ontSizeY.Text = list[0].Mat_Size.Split('/')[1].Trim();
            ontSizeZ.Text = list[0].Mat_Size.Split('/')[2].Trim();
            lctBOM.cbo.Text = list[0].BOM_Num.ToString();
            lctCategory.cbo.Text = list[0].Mat_Category;
            lctKind.cbo.Text = list[0].Mat_Kind;
        }
    }
}
