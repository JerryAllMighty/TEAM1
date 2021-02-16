using BedFactory.Util;
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

namespace BedFactory.Pop_up
{
    public partial class frmShipmentOrders : Form
    {
        List<CommonCodeVO> matInfo_list = new List<CommonCodeVO>(); //자재정보리스트
        List<CommonCodeVO> wearhouse_list = new List<CommonCodeVO>(); //창고목록리스트
        APIMessage<List<MaterialsVO>> mat_List = new APIMessage<List<MaterialsVO>>();
        List<WearingVO> vo_List = new List<WearingVO>();

        public int StorgeNum { get; set; }

        public frmShipmentOrders()
        {
            InitializeComponent();
        }

        private void frmShipmentOrders_Load(object sender, EventArgs e)
        {
            #region 자재종류 콤보박스 바인딩
            List<CommonCodeVO> allCommon = new List<CommonCodeVO>();
            CommonCodeService service1 = new CommonCodeService();

            allCommon = service1.GetCommonCodeInfo();

            CommonUtil.CommonCodeBindig(cboKind, allCommon, "자재구분", "전체");
            #endregion

            #region 자재명 콤보박스 바인딩
            ServiceHelp serviceHelp = new ServiceHelp();
            mat_List = serviceHelp.GetApiCaller<List<MaterialsVO>>("api/Mat/GetAllMaterials");    //자재정보 출력(API)
            if (mat_List != null)
            {
                mat_List.Data.ForEach(p => matInfo_list.Add(new CommonCodeVO { Code_Num = p.Mat_Num, Code_Name = p.Mat_Name, Category = p.Mat_Category }));
            }
            CommonUtil.CommonCodeBindig(cboName, matInfo_list, "", "전체");
            #endregion

            #region 창고정보 콤보박스 바인딩
            WearingService service2 = new WearingService();
            service2.GetAllWearHouse().ForEach(p => wearhouse_list.Add(new CommonCodeVO { Code_Num = p.Str_Num.ToString(), Code_Name = p.Str_Kind, Category = p.Str_Kind }));
            CommonUtil.CommonCodeBindig(cboWearHouse, wearhouse_list, "", "전체");
            #endregion

            #region 그리드뷰 세팅
            dgvShipmentList.SetGridViewColumn("자재번호", "Mat_Num", visibility: false);
            dgvShipmentList.SetGridViewColumn("자재명", "Mat_Name", 120);
            dgvShipmentList.SetGridViewColumn("수량", "Mat_Cnt", 50);
            dgvShipmentList.SetGridViewColumn("창고번호", "Str_Num", visibility: false);
            dgvShipmentList.SetGridViewColumn("창고종류", "Str_Kind", 120);
            dgvShipmentList.AddGridButton("삭제", "Delete", "삭제", new Padding { Left = 3, Right = 3 }, 50);
            #endregion
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
            cboWearHouse.DataSource = null;
            CommonUtil.CommonCodeBindig(cboName, matInfo_list, mat_Category, "선택");
            CommonUtil.CommonCodeBindig(cboWearHouse, wearhouse_list, mat_Category, "선택");
        }

        /// <summary>
        /// 출하할 자재목록 및 수량 추가
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(cboName.Text == "선택" || cboWearHouse.Text == "선택")
            {
                MessageBox.Show("자재와 창고를 선택해주세요.");
                return;
            }

            //해당 자재가 이미 추가된 경우
            if (vo_List.FindAll(p => p.Mat_Num.Equals(cboName.SelectedValue.ToString())).Count > 0)
            {
                vo_List.Find(p => p.Mat_Num.Equals(cboName.SelectedValue.ToString())).Mat_Cnt += Convert.ToInt32(nmrCnt.Value);
            }
            //해당 자재가 없는 경우
            else
            {
                WearingVO vo = new WearingVO();
                vo.Mat_Num = cboName.SelectedValue.ToString();
                vo.Mat_Name = cboName.Text;
                vo.Str_Num = Convert.ToInt32(cboWearHouse.SelectedValue);
                vo.Str_Kind = cboWearHouse.Text;
                vo.Mat_Cnt = Convert.ToInt32(nmrCnt.Value);
                vo_List.Add(vo);
            }

            dgvShipmentList.DataSource = null;
            dgvShipmentList.DataSource = vo_List;
        }

        /// <summary>
        /// 항목삭제
        /// </summary>
        private void dgvShipmentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0 || e.ColumnIndex != 5) { return; }

            vo_List.RemoveAll(p => p.Mat_Num.Equals(dgvShipmentList["Mat_Num", e.RowIndex].Value.ToString()));
            dgvShipmentList.DataSource = null;
            dgvShipmentList.DataSource = vo_List;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }
    }
}
