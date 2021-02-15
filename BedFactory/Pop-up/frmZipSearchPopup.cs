using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BedFactory.Pop_up
{
    public partial class frmZipSearchPopup : Form
    {
        
        public string WooPyun
        {
            get { return txtWoopyun.Text; }
        }
        public string Jibun1
        {
            get { return txtRoad.Text; }
        }
        public string Jibun2 
        { 
            get 
            { 
                return txtJibun.Text; 
            } 
        }

        public frmZipSearchPopup()
        {
            InitializeComponent();
        }

        private void btnJibun_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string url = "http://www.juso.go.kr/addrlink/addrLinkApi.do";
            string apiKey = "devU01TX0FVVEgyMDIwMTEwMzEwMDU0ODExMDM2MTA=";

            string apiUrl = $"{url}?confmKey={apiKey}&currentPage=1&countPerPage=1000&keyword={txtSearch.Text.Trim()}";

            WebClient wc = new WebClient();
            XmlReader reader = new XmlTextReader(wc.OpenRead(apiUrl));
            DataSet ds = new DataSet();
            ds.ReadXml(reader);

            if (ds.Tables.Count > 1)
                dgvMember.DataSource = ds.Tables[1];
            else
                MessageBox.Show(ds.Tables[0].Rows[0]["errorMessage"].ToString());
        }

        private void frmZipSearchPopup_Load(object sender, EventArgs e)
        {
            dgvMember.SetGridViewColumn("우편번호", "ZipNo");
            dgvMember.SetGridViewColumn("도로명주소", "RoadAddr", 400);
            dgvMember.SetGridViewColumn("지번주소", "JibunAddr", 400);
        }

        private void dgvMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvMember.CurrentRow.Selected = true;
            txtWoopyun.Text = dgvMember.CurrentRow.Cells[0].Value.ToString();
            txtRoad.Text = dgvMember.CurrentRow.Cells[1].Value.ToString();
            txtJibun.Text = dgvMember.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
