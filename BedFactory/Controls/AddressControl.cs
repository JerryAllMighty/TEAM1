using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BedFactory.Pop_up;

namespace BedFactory
{
    public partial class AddressControl : UserControl
    {
        public string WooPyun { get { return txtWooPyun.Text; } }
        public string RoadAddr { get { return txtRoad.Text;  } }
        public string JibunAddr { get { return txtJibun.Text;  } }
        public string DetailAddress { get { return txtDetailAddress.Text; } }

        public AddressControl()
        {
            InitializeComponent();
        }

        private void btnSearchAddr_Click(object sender, EventArgs e)        //주소 검색 팝업 띄우고, 검색 결과 바인딩해오기
        {
            frmZipSearchPopup pop = new frmZipSearchPopup();
            if (pop.ShowDialog() == DialogResult.OK)
            {
                txtWooPyun.Text = pop.WooPyun;
                txtRoad.Text = pop.Jibun1;
                txtJibun.Text = pop.Jibun2;
            }
        }

        private void txtWooPyun_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show("반드시 주소 검색을 사용하여주세요.");
            
        }

        private void txtAddress1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show("반드시 주소 검색을 사용하여주세요.");
            
        }

        private void txtAddress2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show("반드시 주소 검색을 사용하여주세요.");
            
        }
    }
}
