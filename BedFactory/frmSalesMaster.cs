using BedFactoryService;
using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BedFactory
{
    public partial class frmSalesMaster : BedFactory.BaseForms.BaseForm2
    {
        public frmSalesMaster()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 컨트롤 포커스 받을시 콤보 박스 바인딩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboStatus_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 컨트롤 포커스 받을시 콤보 박스 바인딩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboCompany_Enter(object sender, EventArgs e)
        {
            CompanyService service = new CompanyService();
            List<CompanyVO> companyList= service.GetEveryCompanyName();
            if (companyList != null)
            {
                cboCompany.Items.Add("선택");
                companyList.ForEach(p => cboCompany.Items.Add(p.Com_Name));
            }
        }

        /// <summary>
        /// 컨트롤 포커스 받을시 콤보 박스 바인딩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboDestination_Enter(object sender, EventArgs e)
        {

        }
    }
}
