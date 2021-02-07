using BedFactory.Util;
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
    public partial class frmMenuManagement : Form
    {
        public frmMenuManagement()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 폼 로드 시 데이터그리드뷰 셋팅
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMenuManagement_Load(object sender, EventArgs e)
        {
            dgvMenuBigCategory.SetGridViewColumn("메뉴 코드", "Code_Num");
            dgvMenuBigCategory.SetGridViewColumn("메뉴 이름", "Code_Name");

            var MenuBigList = (from items in frmCommonCode.CheckCommonInfo()
                            where items.Category == "메뉴"
                            select items).ToList();
            dgvMenuBigCategory.DataSource = MenuBigList;

            dgvMenu.SetGridViewColumn("메뉴 코드", "Code_Num");
            dgvMenu.SetGridViewColumn("메뉴 이름", "Code_Name");
            dgvMenu.SetGridViewColumn("카테고리", "Category");
            dgvMenu.SetGridViewColumn("P_Code", "P_Code");

            //부모 노드 추가
            MenuBigList.ForEach(p => trvMenu.Nodes.Add(p.Code_Name));

            //각 부모 노드 당 자식 노드 추가
            for(int i =0; i < MenuBigList.Count; i++)
            {
                var MenuList = (from items in frmCommonCode.CheckCommonInfo()
                                where MenuBigList[i].Code_Num == items.P_Code
                                select items).ToList();


                MenuList.ForEach(p => trvMenu.Nodes[i].Nodes.Add(p.Code_Name));

            }
        }

        

        /// <summary>
        /// 메뉴 추가 팝업을 띄우는 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddMenu_PopUp_Click(object sender, EventArgs e)
        {
            frmMenuRegister frm = new frmMenuRegister();
            frm.ShowDialog();
        }

        /// <summary>
        /// 메뉴 대분류 더블 클릭시 소분류에 해당 정보 바인딩하는 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMenuBigCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var MenuList = (from items in frmCommonCode.CheckCommonInfo()
                            where items.P_Code == dgvMenuBigCategory[0, e.RowIndex].Value.ToString()
                            select items).ToList();

            dgvMenu.DataSource = MenuList;
        }
    }
}
