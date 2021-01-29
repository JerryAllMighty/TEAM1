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
using BedFactory.Controls;

namespace BedFactory.Pop_up
{
    public partial class frmNewMaterials : Form
    {
        string materialID; //자재ID
        int cnt;    //새로 추가된 검사항목 입력란 개수
        MaterialsVO materialsVO;    //자재정보
        List<CommonCodeVO> codeList = new List<CommonCodeVO>();   //제품 당 검사항목
        List<CommonCodeVO> allList = new List<CommonCodeVO>();    //전체공통코드
        List<MaterialsVO> m_List = new List<MaterialsVO>(); //자재정보

        public frmNewMaterials()
        {
            InitializeComponent();
        }

        private void frmNewMaterials_Load(object sender, EventArgs e)
        {
            search.PerformClick();  //트리노드 바인딩
        }

        /// <summary>
        /// 자식노드 바인딩(자재정보)
        /// </summary>
        private void TreeNodeBinding()
        {
            #region 트리노드 바인딩(카테고리)
            List<CommonCodeVO> p_List = new List<CommonCodeVO>();
            CommonCodeService service1 = new CommonCodeService();
            allList = service1.GetCommonCodeInfo();
            p_List = (from common in allList
                      where common.Category == "자재종류"
                      select common).ToList();

            CommonUtil.CommonCodeBindig(lctCategory.cbo, p_List, "", "선택");   //자재종류 콤보박스 바인딩

            foreach (CommonCodeVO item in p_List)
            {
                trvMaterials.Nodes.Add(item.Code_Num, item.Code_Name);
            }
            #endregion

            ServiceHelp serviceHelp = new ServiceHelp();
            APIMessage<List<MaterialsVO>> result = serviceHelp.GetApiCaller<List<MaterialsVO>>("api/materials/all");    //자재정보 출력(API)

            //자재정보가 있을경우
            if (result != null)
            {
                m_List = result.Data;

                List<CommonCodeVO> list = new List<CommonCodeVO>();   //공통코드 변수선언
                //공통코드 리스트 형태로 재구성
                m_List.ForEach(p => list.Add(new CommonCodeVO { Code_Num = p.Mat_Num, Code_Name = p.Mat_Name, Category = p.Mat_Category }));

                //자식노드 바인딩
                foreach (CommonCodeVO vo in p_List)    //부모노드 
                {
                    CommonUtil.AddTreeNode(trvMaterials.Nodes[vo.Code_Num], list, vo.Code_Name, false);
                }
            }
        }

        /// <summary>
        /// 자재정보 등록
        /// </summary>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(lctProductName.text.Text.Trim().Length < 1)
            {
                MessageBox.Show("품명을 입력하시오.");
                return;
            }

            MaterilasData();

            MaterialsService service1 = new MaterialsService();
            CheckService service2 = new CheckService();
            string id;  //새로 저장되는 자재ID
            bool bFlag = false;

            #region 자재 별 검사항목 등록
            try
            {
                id = service1.NewMaterials(materialsVO);

                foreach (MaterialsCheckList item in panel1.Controls)
                {
                    service2.InsertCheck(id, int.Parse(item.cboText.cbo.Name), 1);
                    bFlag = true;
                }
            }
            catch
            {
                bFlag = false;
            }
            #endregion

            if (bFlag)
            {
                MessageBox.Show("성공적으로 저장하였습니다.");
                search.PerformClick();
            }
            else
            {
                MessageBox.Show("저장에 실패하였습니다.");
            }
        }

        /// <summary>
        /// 자재정보 데이터
        /// </summary>
        private void MaterilasData()
        {
            string[] m_size = new string[3];
            m_size[0] = ontSizeX.Text;
            m_size[1] = ontSizeY.Text;
            m_size[2] = ontSizeZ.Text;

            materialsVO = new MaterialsVO();
            materialsVO.Mat_Num = materialID;
            materialsVO.Mat_Name = lctProductName.text.Text;
            materialsVO.Mat_Kind = string.IsNullOrEmpty(lctKind.cbo.Text) ? "" : lctKind.cbo.Text;
            materialsVO.Mat_Category = string.IsNullOrEmpty(lctCategory.cbo.Text) ? "" : lctCategory.cbo.Text;
            materialsVO.Mat_Size = string.IsNullOrEmpty(string.Join(" / ", m_size)) ? "" : string.Join(" / ", m_size);
            materialsVO.FirstMan = 1;
            materialsVO.LastMan = 1;
        }

        /// <summary>
        /// 자재정보 수정
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MaterilasData();

            MaterialsService service1 = new MaterialsService();
            CheckService service2 = new CheckService();
            bool bFlag = false;
            
            if (service1.UpdateMaterilas(materialsVO) && service2.DeleteCheck(materialID))
            {
                try
                {
                    foreach (MaterialsCheckList item in panel1.Controls)
                    {
                        service2.InsertCheck(materialID, int.Parse(item.cboText.cbo.Name), 1);
                        bFlag = true;
                    }
                }
                catch
                {
                    bFlag = false;
                }

                if (bFlag)
                {
                    MessageBox.Show("성공적으로 수정하였습니다.");
                    search.PerformClick();
                }
                else
                {
                    MessageBox.Show("수정에 실패하였습니다.");
                }
            }
            else
            {
                MessageBox.Show("수정에 실패하였습니다.");
            }
        }

        /// <summary>
        /// 트리노드 변경적용
        /// </summary>
        private void search_Click(object sender, EventArgs e)
        {
            TreeNodeBinding();

            //매트릭스 크기(싱글, 퀸, 킹, ...)정보 콤보박스 바인딩
            CommonUtil.CommonCodeBindig(lctKind.cbo, allList, "매트릭스크기", "선택");

            //검사항목 콤보박스 바인딩
            List<CheckInfoVO> ci_list = new List<CheckInfoVO>();
            CheckService service2 = new CheckService();
            ci_list = service2.GetCheckInfo();
            ci_list.ForEach(p => codeList.Add(new CommonCodeVO { Code_Num = p.Check_Info_Num.ToString(), Code_Name = p.CheckName, Category = p.CheckKind }));


        }

        /// <summary>
        /// 자재정보 삭제
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("정말로 삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo) == 
                DialogResult.No)
            {
                return;
            }

            MaterialsService service1 = new MaterialsService();
            CheckService service2 = new CheckService();
            if(service1.DeleteMaterilas(materialID) && service2.DeleteCheck(materialID))
            {
                MessageBox.Show("성공적으로 삭제하였습니다.");
                search.PerformClick();
            }
            else
            {
                MessageBox.Show("삭제에 실패하였습니다.");
            }
        }

        /// <summary>
        /// 검사항목 입력란 추가
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            cnt = panel1.Controls.Count;    //현재 검사항목 입력란 개수

            MaterialsCheckList view = new MaterialsCheckList();
            view.Location = new Point(3, 4 + 40 * cnt);
            view.Size = new Size(490, 40);
            panel1.Controls.Add(view);
            CommonUtil.CommonCodeBindig(view.cboText.cbo, codeList, "", "선택");
        }

        /// <summary>
        /// 자재정보 바인딩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trvMaterials_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            trvMaterials.SelectedNode = e.Node;
            materialID = e.Node.Name;

            #region 자재정보 바인딩
            List<MaterialsVO> list = (from item in m_List
                                      where item.Mat_Num.Equals(e.Node.Name)
                                      select item).ToList();

            if(list.Count <= 0) { return; } //정보가 없을 경우 리턴

            lctProductName.text.Text = list[0].Mat_Name;
            ontSizeX.Text = list[0].Mat_Size.Split('/')[0].Trim();
            ontSizeY.Text = list[0].Mat_Size.Split('/')[1].Trim();
            ontSizeZ.Text = list[0].Mat_Size.Split('/')[2].Trim();
            lctCategory.cbo.Text = list[0].Mat_Category;
            lctKind.cbo.Text = list[0].Mat_Kind;
            #endregion

            #region 검사항목 바인딩
            CheckService service = new CheckService();
            List<CheckVO> c_list = service.GetCheck(e.Node.Name);
            List<CheckInfoVO> ci_list = service.GetCheckInfo();
            List<CommonCodeVO> codeList = new List<CommonCodeVO>();

            panel1.Controls.Clear();
            ci_list.ForEach(p => codeList.Add(new CommonCodeVO { Code_Num = p.Check_Info_Num.ToString(), Code_Name = p.CheckKind }));

            foreach(CheckVO item in c_list)
            {
                cnt = panel1.Controls.Count;
                MaterialsCheckList view = new MaterialsCheckList();
                view.Location = new Point(3, 4 + 40 * cnt);
                view.Size = new Size(490, 40);
                panel1.Controls.Add(view);
                CommonUtil.CommonCodeBindig(view.cboText.cbo, codeList, "", "");
                view.cboText.cbo.Text = item.CheckKind;
            }
            #endregion
        }
    }
}
