using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BedFactory
{
    public partial class frmUserGroupAuthorityModify : Form
    {
        public frmUserGroupAuthorityModify()
        {
            InitializeComponent();
        }

        private void frmUserGroupAuthorityModify_Load(object sender, EventArgs e)
        {
            //전체화면목록 세팅
            datagridviewControl1.SetGridViewColumn("화면코드", "Code_Num");
            datagridviewControl1.SetGridViewColumn("화면명", "Code_Name");
            datagridviewControl1.AddGridButton("수정", "btnModify", "수정", new Padding(0, 0, 0, 0), 100);

            //추가할 권한
            datagridviewControl2.SetGridCheckBox("체크박스");
            datagridviewControl2.SetGridViewColumn("화면명", "Code_Name");

            LoadData();
        }

        private void LoadData()
        {
            throw new NotImplementedException();
        }
    }
}
