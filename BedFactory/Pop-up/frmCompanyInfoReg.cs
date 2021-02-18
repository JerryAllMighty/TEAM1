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
    public partial class frmCompanyInfoReg : Form
    {
        public CompanyVO editCompany { get; set; }
        public bool IsEditMode { get; set; }

        public frmCompanyInfoReg()
        {
            InitializeComponent();
        }

        private void frmCompanyInfoReg_Load(object sender, EventArgs e)
        {
            List<CommonCodeVO> ccList = frmCommonCode.CheckCommonInfo();
            CommonUtil.CommonCodeBindig(cboComCode, ccList, "업체", "");

            if(IsEditMode && editCompany != null)
            {
                cboComCode.SelectedValue = editCompany.Com_Code;
                txtComName.Text = editCompany.Com_Name;
                txtRpt.Text = editCompany.Com_Represent;
                txtInfo.Text = editCompany.Com_Info;
                txtManager.Text = editCompany.Com_Manager.ToString();
                txtPhone.Text = editCompany.Com_Phone;
                if (editCompany.IsUse == "Y")
                    rdoYes.Checked = true;
                else
                    rdoNo.Checked = true;
              //txt주소
            }
        }

        //저장 및 수정
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboComCode.SelectedValue == null || txtComName.Text.Length == 0) return;


            if (cboComCode.SelectedValue.ToString().Length < 1 || txtComName.Text.Length < 1) return;


            CompanyService service = new CompanyService();
            bool bResult = false;

            if (IsEditMode) // 등록
            {
                CompanyVO regVO = new CompanyVO()
                {
                    Com_Code = cboComCode.SelectedValue.ToString(),
                    Com_Name = txtComName.Text.Trim(),
                    Com_Represent = txtRpt.Text.Trim(),
                    Com_Phone = txtPhone.Text.Trim(),
                    //  Com_Addr = txt
                    Com_Manager = Convert.ToInt32(txtManager.Text.Trim()),
                    Com_Info = txtInfo.Text.Trim(),
                    IsUse = (rdoYes.Checked) ? "Y" : "N",
                    FirstMan = 1,     //임시로 값 대입
                    LastMan = 1    //임시로 값 대입                 
                };

                bResult = service.InsertCompnayInfo(regVO);
                if (bResult)
                {
                    MessageBox.Show(BedFactory.Properties.Settings.Default.InsertSuccess);
                    this.Close();
                }
            }

            else // 수정
            { 
                CompanyVO saveVO = new CompanyVO
                {
                    Com_Num = editCompany.Com_Num,
                    Com_Code = cboComCode.SelectedValue.ToString(),
                    Com_Name = txtComName.Text.Trim(),
                    Com_Represent = txtRpt.Text.Trim(),
                    Com_Phone = txtPhone.Text.Trim(),
                //  Com_Addr = 주소
                    Com_Manager = Convert.ToInt32(txtManager.Text.Trim()),
                    Com_Info = txtInfo.Text.Trim(),
                    IsUse = (rdoYes.Checked) ? "Y" : "N",
                    LastMan = 1       //임시로 값 대입
                };

                bResult = service.UpdateCompnayInfo(saveVO);
                if (bResult)
                {
                    MessageBox.Show(BedFactory.Properties.Settings.Default.UpdateSuccess);
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
