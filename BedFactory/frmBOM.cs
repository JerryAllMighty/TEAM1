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
                          where common.Category.Equals("자재종류")
                          select common).ToList();
            CommonUtil.CommonCodeBindig(cbbKind, commonList, "자재종류", "전체");
            #endregion

            #region 자재종류 버튼 바인딩
            int y = 0;
            foreach(CommonCodeVO vo in commonList)
            {
                Button btn = new Button();
                btn.Size = new Size(220, 40);
                btn.Location = new Point(5, 3 + 41 * y);
                btn.Text = vo.Code_Name;
                btn.Tag = vo.Code_Num;
                btn.Click += Btn_Click;
                btn.FlatStyle = FlatStyle.Popup;
                btn.BackColor = Color.LightSteelBlue;
                pnlKindBtn.Controls.Add(btn);
                y++;
            }
            #endregion

            #region 자재정보 호출
            ServiceHelp serviceHelp = new ServiceHelp();
            APIMessage<List<MaterialsVO>> result = serviceHelp.GetApiCaller<List<MaterialsVO>>("api/Materials/GetAllMaterials");    //자재정보 출력(API)
            if (result != null)
            {
                result.Data.ForEach(p => list.Add(new CommonCodeVO { Code_Num = p.Mat_Num, Code_Name = p.Mat_Name, Category = p.Mat_Category }));
            }
            #endregion

            dgvList.SetGridViewColumn("자재코드", "Mat_Num", visibility: false);
            dgvList.SetGridViewColumn("자재명", "Mat_Name", textAlign : DataGridViewContentAlignment.MiddleLeft);
        }

        /// <summary>
        /// 자재종류 버튼 클릭 이벤트
        /// </summary>
        private void Btn_Click(object sender, EventArgs e)
        {
            string btnCartegory = sender.ToString().Replace("System.Windows.Forms.Button, Text:", "").Trim();
            CheckedListBox clb = new CheckedListBox();
            clb.BorderStyle = BorderStyle.None;
            clb.Size = new Size(220, 300);
            clb.Location = new Point(4, 3);

            var materialsList = (from materials in list
                                 where materials.Category.Equals(btnCartegory)
                                 select materials).ToList();
            foreach (CommonCodeVO vo in list)
            {
                clb.Items.Add(vo.Code_Name);
            }
            splitContainer1.Panel1.Controls.Add(clb);
        }

        /// <summary>
        /// 자재종류에 따른 자재명 콤보박스 바인딩
        /// </summary>
        private void cbbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommonUtil.CommonCodeBindig(cbbName, list, cbbKind.Text, "전체");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
