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
    public partial class frmMaterials : Form
    {
        string type = string.Empty; //등록, 수정 여부
        UnitCostVO unit;

        public frmMaterials(int id, string category, string type, UnitCostVO vo)
        {
            InitializeComponent();

            this.Text = category;
            txtBeforeCost.Text = "0";
            txtEndDate.Text = "9999-12-31";
            txtMan.Text = id.ToString();
            txtDate.Text = DateTime.Now.ToShortDateString();

            if(vo != null)
            {
                unit = new UnitCostVO();
                unit = vo;
            }
            this.type = type;
        }

        private void frmMaterials_Load(object sender, EventArgs e)
        {
            UnitCostService service = new UnitCostService();
            List<CommonCodedVO> list = service.UnitCostCombo();
            CommonUtil.ComboBinding(cboCompany, list, "거래처", true, "선택");
            CommonUtil.ComboBinding(cboMaterial, list, "자재", true, "선택");

            if (type.Equals("수정"))
            {
                lblCostNum.Text = unit.UnitCost_Num.ToString();
                cboCompany.SelectedValue = unit.Com_Num;
                cboMaterial.SelectedValue = unit.Mat_Num;
                txtNowCost.Text = unit.Now_UnitCost.ToString();
                txtBeforeCost.Text = unit.Before_UnitCost.ToString();
                dtpStartDate.Value = unit.Start_Date;
                txtEndDate.Text = unit.End_Date.ToShortDateString();
            }
            else if (type.Equals("복사"))
            {
                cboCompany.SelectedValue = unit.Com_Num;
                cboMaterial.SelectedValue = unit.Mat_Num;
                txtNowCost.Text = unit.Now_UnitCost.ToString();
                txtBeforeCost.Text = unit.Before_UnitCost.ToString();
                dtpStartDate.Value = unit.Start_Date;
                txtEndDate.Text = unit.End_Date.ToShortDateString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboCompany.SelectedText.Equals("선택") || cboMaterial.SelectedText.Equals("선택") || txtNowCost.Text.Length < 1)
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.ValidationCheckMsg);
                return;
            }
            else
            {
                if(!type.Equals("수정"))
                {
                    UnitCostVO vo = new UnitCostVO
                    {
                        Com_Num = Convert.ToInt32(cboCompany.SelectedValue),
                        Mat_Num = cboMaterial.SelectedValue.ToString(),
                        Now_UnitCost = Convert.ToInt32(txtNowCost.Text),
                        Before_UnitCost = Convert.ToInt32(txtBeforeCost.Text),
                        Start_Date = dtpStartDate.Value.Date,
                        End_Date = Convert.ToDateTime(txtEndDate.Text),
                        FirstMan = Convert.ToInt32(txtMan.Text),
                        FirstDate = Convert.ToDateTime(txtDate.Text)
                    };

                    UnitCostService service = new UnitCostService();
                    int cnt = service.UnitCostInsert(vo);

                    if (cnt < 2)
                    {
                        MessageBox.Show(BedFactory.Properties.Settings.Default.InsertSuccess);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(BedFactory.Properties.Settings.Default.InsertFail);
                    }
                }
                else
                {
                    UnitCostVO vo = new UnitCostVO
                    {
                        UnitCost_Num = int.Parse(lblCostNum.Text),
                        Com_Num = Convert.ToInt32(cboCompany.SelectedValue),
                        Mat_Num = cboMaterial.SelectedValue.ToString(),
                        Now_UnitCost = Convert.ToInt32(txtNowCost.Text),
                        Before_UnitCost = Convert.ToInt32(txtBeforeCost.Text),
                        Start_Date = dtpStartDate.Value.Date,
                        End_Date = Convert.ToDateTime(txtEndDate.Text),
                        LastMan = Convert.ToInt32(txtMan.Text),
                        LastDate = Convert.ToDateTime(txtDate.Text)
                    };

                    UnitCostService service = new UnitCostService();
                    int cnt = service.UnitCostUpdate(vo);

                    if (cnt < 2)
                    {
                        MessageBox.Show(BedFactory.Properties.Settings.Default.UpdateSuccess);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(BedFactory.Properties.Settings.Default.UpdateFail);
                    }
                }
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
