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
        List<BOMVO> bom_List = new List<BOMVO>();
        List<int> bom_Num = new List<int>();
        BOMVO Add_mat, Del_mat;
        int rowIndext = -1;

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
            dgvMat.SetGridViewColumn("자재이름", "Mat_Name", 400);
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
            dgvBOM.SetGridViewColumn("사용자재번호", "Use_Mat_Num", visibility: false);
            dgvBOM.SetGridViewColumn("자재이름", "Mat_Name", 300);
            dgvBOM.SetGridViewColumn("자재구분", "Mat_Category", 200);
            dgvBOM.SetGridViewColumn("사용개수", "Cnt", 100);
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

            if (mat_List != null)
            {
                list = (from mat in mat_List.Data
                        where mat.Mat_Category.Contains(btnCartegory)
                        select mat).ToList();
            }

            dgvMat.DataSource = null;
            dgvMat.DataSource = list;
        }

        /// <summary>
        /// 자재종류에 따른 자재명 콤보박스 필터링
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mat_Category;
            if(cboKind.Text == "전체")
            {
                mat_Category = "";
                label4.Visible = rdbGo.Visible = rdbBack.Visible = false;
            }
            else if(cboKind.Text == "반제품")
            {
                mat_Category = cboKind.Text;
                label4.Visible = rdbGo.Visible = rdbBack.Visible = rdbGo.Checked = true;    //반제품일 경우 라디오박스 활성화
            }
            else
            {
                mat_Category = cboKind.Text;
                label4.Visible = rdbGo.Visible = rdbBack.Visible = false;
            }
            cboName.DataSource = null;
            CommonUtil.CommonCodeBindig(cboName, list, mat_Category, "선택");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bom_List.Clear();

            //BOM바인딩
            BOMService service = new BOMService();
            List<BOMVO> bom_All = new List<BOMVO>();
            bom_All = service.GetBOM(cboName.SelectedValue.ToString());

            if(!label4.Visible || bom_All.Count < 1)
            {
                bom_List = bom_All;
            }
            else if (rdbGo.Checked) //반제품 역전개
            {
                bom_List = (from bom in bom_All
                            where bom.Mat_Category.Equals("완제품")
                            select bom).ToList();
            }
            else if (!rdbGo.Checked)    //반제품 정전개
            {
                bom_List = (from bom in bom_All
                            where bom.Mat_Category != "완제품"
                            select bom).ToList();
            }

            dgvBOM.DataSource = null;
            dgvBOM.DataSource = bom_List;
        }

        /// <summary>
        /// BOM추가
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool bflag = true;

            if(rowIndext < 0)
            {
                MessageBox.Show("추가할 자재를 선택해주세요.");
                return;
            }

            //현재 있는 자재에서 수량 추가
            foreach(DataGridViewRow row in dgvBOM.Rows)
            {
                if (row.Cells["Use_Mat_Num"].Value.ToString() == Add_mat.Use_Mat_Num)
                {
                    row.Cells["Cnt"].Value = Convert.ToInt32(row.Cells["Cnt"].Value) + Convert.ToInt32(nmrCnt.Value);
                    bflag = false;
                    return;
                }
            }

            //새로운 BOM생성
            if(dgvBOM.RowCount < 1 || bflag)
            {
                Add_mat.Cnt = Convert.ToInt32(nmrCnt.Value);
                bom_List.Add(Add_mat);
                dgvBOM.DataSource = null;
                dgvBOM.DataSource = bom_List;
            }
        }

        /// <summary>
        /// 추가할 자재목록 선택
        /// </summary>
        private void dgvMat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0) { return; }
            rowIndext = e.RowIndex;

            Add_mat = new BOMVO
            {
                BOM_Num = -1,
                Mat_Num = cboName.SelectedValue.ToString(),
                Use_Mat_Num = dgvMat["Mat_Num", e.RowIndex].Value.ToString(),
                Mat_Name = dgvMat["Mat_Name", e.RowIndex].Value.ToString(),
                Mat_Category = dgvMat["Mat_Category", e.RowIndex].Value.ToString(),
                Firstman = 1,
                Lastman = 1
            };
        }

        /// <summary>
        /// 삭제할 BOM목록 선택
        /// </summary>
        private void dgvBOM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            rowIndext = e.RowIndex;

            Del_mat = new BOMVO
            {
                Mat_Num = dgvBOM["Mat_Num", e.RowIndex].Value.ToString(),
                Use_Mat_Num = dgvBOM["Use_Mat_Num", e.RowIndex].Value.ToString(),
                Mat_Name = dgvBOM["Mat_Name", e.RowIndex].Value.ToString(),
                Mat_Category = dgvBOM["Mat_Category", e.RowIndex].Value.ToString(),
            };
        }

        /// <summary>
        /// BOM등록 및 수정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2_Click_1(object sender, EventArgs e)
        {
            BOMService service = new BOMService();

            //BOM등록 및 수정
            foreach (DataGridViewRow row in dgvBOM.Rows)
            {
                BOMVO vo = new BOMVO
                {
                    BOM_Num = Convert.ToInt32(row.Cells["BOM_Num"].Value),
                    Mat_Num = cboName.SelectedValue.ToString(),
                    Use_Mat_Num = row.Cells["Use_Mat_Num"].Value.ToString(),
                    Cnt = Convert.ToInt32(row.Cells["Cnt"].Value)
                };

                //신규 BOM등록
                if (vo.BOM_Num == -1)
                {
                    vo.Firstman = 1;
                    vo.Lastman = 1;

                    service.InsertBOM(vo);
                }
                //BOM수정
                else
                {
                    vo.Lastman = 1;

                    service.UpdateBOM(vo);
                }
            }

            //BOM삭제
            foreach(int bomNum in bom_Num)
            {
                service.DeleteBOM(bomNum);
            }
            bom_Num.Clear();
        }

        /// <summary>
        /// BOM삭제
        /// </summary>
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (rowIndext < 0)
            {
                MessageBox.Show("삭제할 자재를 선택해주세요.");
                return;
            }

            //현재 있는 자재에서 수량 감소
            foreach (DataGridViewRow row in dgvBOM.Rows)
            {
                if (row.Cells["Use_Mat_Num"].Value.ToString() == Del_mat.Use_Mat_Num)
                {
                    row.Cells["Cnt"].Value = Convert.ToInt32(row.Cells["Cnt"].Value) - Convert.ToInt32(nmrCnt.Value);

                    //개수가 0이하일 경우 해당 항목 삭제
                    if(Convert.ToInt32(row.Cells["Cnt"].Value) < 1)
                    {
                        //등록되어 있는 BOM
                        if (Convert.ToInt32(row.Cells["BOM_Num"].Value) > 0)
                        {
                            bom_Num.Add(Convert.ToInt32(row.Cells["BOM_Num"].Value));
                        }
                        bom_List.RemoveAll(p => p.Use_Mat_Num.Equals(Del_mat.Use_Mat_Num));
                        dgvBOM.DataSource = null;
                        dgvBOM.DataSource = bom_List;
                    }
                    return;
                }
            }
        }
    }
}
