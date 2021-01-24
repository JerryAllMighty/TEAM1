using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BedFactoryService;
using BedFactoryVO;

namespace BedFactory.Pop_up
{
    public partial class frmCheckInfo : Form
    {
        public CheckInfoVO Info { get; set; }
        public bool formCheck = true;   //등록 : true, 수정 : false

        public frmCheckInfo()
        {
            InitializeComponent();
        }

        private void frmCheckInfo_Load(object sender, EventArgs e)
        {
            #region 콤보박스 바인딩
            //CommonCodeService service = new CommonCodeService();

            //var list = (from item in service.GetCommonCodeInfo()
            //            where item.Category == "검사항목").ToList();

            //lctCheckKind.cbo.DataSource = list;
            #endregion

            if (formCheck)
            {
                btnOk.Text = "등 록";
            }
            else
            {
                btnOk.Text = "수 정";
                lctCheckKind.cbo.Text = Info.CheckKind;
                lctCheckDetail.text.Text = Info.Check_Detail;
            }
        }

        /// <summary>
        /// 취소버튼
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            CheckService service = new CheckService();
            CheckInfoVO vo = new CheckInfoVO();

            if(btnOk.Text.Replace(" ", "") == "등록")
            {
                if(service.InsertCheckInfo(vo))
                {
                    MessageBox.Show("검사항목 등록을 성공하였습니다.");
                }
                else
                {
                    MessageBox.Show("검사항목 등록을 실패하였습니다.");
                }
            }
            else if(btnOk.Text.Replace(" ", "") == "수정")
            {
                if(service.UpdateCheckInfo(vo))
                {
                    MessageBox.Show("검사항목 수정을 성공하였습니다.");
                }
                else
                {
                    MessageBox.Show("검사항목 수정을 실패하였습니다.");
                }
            }
        }
    }
}
