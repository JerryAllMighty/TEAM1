using BedFactory;
using BedFactory.BaseForms;
using BedFactory.Pop_up;
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

namespace BadFactory
{
    public partial class frmMain : Form
    {
        TreeView tv = new TreeView();
        public EmployeeVO emp_Info;    //로그인한 회원정보

        public frmMain()
        {
            InitializeComponent();
        }

        public void FormChildTab(Form f, TabControl tc)
        {
            TabPage tp = new TabPage(f.Text + "      ");
            tp.Parent = tc;
            tp.Tag = f;

            f.FormBorderStyle = FormBorderStyle.None;
            f.WindowState = FormWindowState.Maximized;
            f.TopLevel = false;
            f.Parent = tp;
            tp.Controls.Add(f);
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pnSplitScreen.Visible == false)
            {
                pnSplitScreen.Visible = true;
                tabControl1.Dock = DockStyle.None;
                //panel4.Dock = DockStyle.Bottom;
                tabControl1.Dock = DockStyle.Fill;
                //tabControl1.Dock = DockStyle.Top;
                //tabControl1.Size = new Size(493, 281);
                if (tabControl1.TabPages.Count > 0)
                {
                    Form f = (Form)tabControl1.SelectedTab.Controls[0];
                    f.WindowState = FormWindowState.Normal;
                    f.WindowState = FormWindowState.Maximized;
                }

                pnSplitScreen.Size = new Size(this.Width - pnMenu2.Width, this.Height / 2);

                TabCustomControl1 tc = new TabCustomControl1();
                tc.Name = "newTab";
                tc.Size = new Size(493, 281);
                tc.Dock = DockStyle.Fill;
                tc.MouseDown += tabControl1_MouseDown;
                pnNewTab.Controls.Add(tc);
            }
            else
            {
                btnTabPut.Text = "▽";
                //panel4.Dock = DockStyle.None;
                pnSplitScreen.Visible = false;
                //panel3.Controls.RemoveByKey("newTab");
                //tabControl1.Dock = DockStyle.Fill;

                if (tabControl1.Controls.Count > 0)
                {
                    Form f = (Form)tabControl1.SelectedTab.Controls[0];
                    f.WindowState = FormWindowState.Normal;
                    f.WindowState = FormWindowState.Maximized;
                }
            }
        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            TabCustomControl1 tc = (TabCustomControl1)sender;

            if (tc.GetTabRect(tc.SelectedIndex).Contains(e.Location))
            {
                var tabRect = tc.GetTabRect(tc.SelectedIndex);
                var imageRect = new Rectangle(
                    (tabRect.Right - 15),
                    tabRect.Top + (tabRect.Height - 15) / 2,
                    15,
                    15);
                if (imageRect.Contains(e.Location))
                {
                    tc.TabPages.RemoveAt(tc.SelectedIndex);

                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.Controls.Count > 0)
            {
                Form f = (Form)tabControl1.SelectedTab.Controls[0];
                f.WindowState = FormWindowState.Normal;
                f.WindowState = FormWindowState.Maximized;
            }            
        }

        private void btnPut_Click(object sender, EventArgs e)
        {
            if (btnMenuPut.Text.Equals("◁"))
            {
                btnMenuPut.Text = "▷";
                pnMenu2.Size = new Size(18, 561);
            }
            else
            {
                btnMenuPut.Text = "◁";
                pnMenu2.Size = new Size(200, 561);
            }

            if (tabControl1.Controls.Count > 0)
            {
                Form f = (Form)tabControl1.SelectedTab.Controls[0];
                f.WindowState = FormWindowState.Normal;
                f.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnTabPut_Click(object sender, EventArgs e)
        {
            if (btnTabPut.Text.Equals("▽"))
            {
                btnTabPut.Text = "△";
                pnSplitScreen.Size = new Size(984, 18);
            }
            else
            {
                btnTabPut.Text = "▽";
                pnSplitScreen.Size = new Size(this.Width - pnMenu2.Width, this.Height / 2);
            }

            if (tabControl1.Controls.Count > 0)
            {
                Form f = (Form)tabControl1.SelectedTab.Controls[0];
                f.WindowState = FormWindowState.Normal;
                f.WindowState = FormWindowState.Maximized;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            #region 회원정보 바인딩
            if (emp_Info != null)
            {
                //lblEmpName.Text = emp_Info.Emp_Name;
                //lblEmpID.Text = emp_Info.Emp_ID;
                //lblEmpCategory.Text = emp_Info.Emp_Category;
                //lblEmpDepartment.Text = emp_Info.Emp_Department;
                //lblEmpEmail.Text = emp_Info.Emp_Email;
            }
            #endregion

            AuthorityService service = new AuthorityService();
            List<CommonCodeVO> list = frmCommonCode.CheckCommonInfo();
            //List<CommonCodeVO> pList = list.Where(p => p.Category == "메뉴").ToList();
            List<AuthorityVO> pList = service.GetEmployeeAuthName(emp_Info.Emp_Num);
            
            tv.Size = new Size(200, 300);
            tv.BorderStyle = BorderStyle.None;
            tv.Dock = DockStyle.Fill;
            tv.Font = new Font("맑은 고딕", 9.75F);
            tv.Indent = 5;
            tv.NodeMouseDoubleClick += tvMenu_NodeMouseDoubleClick;
            panel1.Controls.Add(tv);
            tv.Visible = false;

            int k = 1;
            pList.OrderBy(l => l.Auth_Num).ToList().ForEach(p =>
            {
                List<CommonCodeVO> cList = list.Where(i => i.P_Code == p.Auth_Name).ToList();
                Button btn = new Button();
                btn.Text = p.Auth_Name;
                btn.Tag = k;
                btn.Size = new Size(200, 30);
                btn.FlatStyle = FlatStyle.Popup;
                btn.Dock = DockStyle.Top;
                btn.BackColor = Color.LightSteelBlue;
                btn.Click += Btn_Click;
                panel1.Controls.Add(btn);
                k++;
            });
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            foreach (Control ctrl in panel1.Controls)
            {
                if(tv.Visible)
                {
                    tv.Visible = false;
                    continue;
                }

                ctrl.Dock = DockStyle.Top;
            }


            if(btn.BackColor != Color.Lavender)
            {
                for (int i = panel1.Controls.Count - 1; i >= 0; i--) //int i = pnMenu.Controls.Count - 1; i >= 0; i--
                {
                    if(panel1.Controls[i] as Button != null)
                    {
                        if (Convert.ToInt32(panel1.Controls[i].Tag) < Convert.ToInt32(btn.Tag))
                        {
                            panel1.Controls[i].Dock = DockStyle.Bottom;
                        }

                        panel1.Controls[i].BackColor = Color.LightSteelBlue;
                    }
                }

                tv.Nodes.Clear();
                List<CommonCodeVO> list = frmCommonCode.CheckCommonInfo();
                List<CommonCodeVO> pList = list.Where(p => (p.Category == "메뉴" && p.Code_Name == btn.Text)).ToList();
                List<CommonCodeVO> cList = list.Where(i => i.P_Code == pList[0].Code_Num).ToList();
                cList.ForEach(k =>
                {
                    TreeNode node = new TreeNode(k.Code_Name);
                    list.ForEach(j =>
                    {
                        if (k.Code_Name == j.Category)
                            node.Nodes.Add(j.Code_Name);
                    });

                    tv.Nodes.Add(node);
                });

                tv.Visible = true;
                btn.BackColor = Color.Lavender;
                return;
            }
            btn.BackColor = Color.LightSteelBlue;
        }

        private void tvMenu_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            bool bCheck = false;

            if (tabControl1.TabPages.Count < 1)
            {
                Form frm = GetAssemblyForm(e.Node.Text);
                if (frm != null)
                {
                    FormChildTab(frm, tabControl1);
                }
            }

            TabControl tc = new TabControl();
            if (!pnSplitScreen.Visible)
            {
                tc = tabControl1;
            }
            else
            {
                if (btnTabPut.Text.Equals("△"))
                {
                    tc = tabControl1;
                }
                else
                {
                    tc = (TabControl)pnNewTab.Controls["newTab"];
                }
            }

            foreach (TabPage tab in tc.TabPages)
            {
                if (tab.Text.Contains(e.Node.Text))
                {
                    bCheck = true;
                }
            }

            if (!bCheck)
            {
                Form frm = GetAssemblyForm(e.Node.Text);
                if (frm != null)
                {
                    FormChildTab(frm, tc);
                }
            }
        }

        public static Form GetAssemblyForm(string strFormText)
        {
            Form f = null;
            foreach (Type t in System.Reflection.Assembly.GetExecutingAssembly().GetTypes())
            {
                if (t.Name.Contains("frm"))
                {
                    try
                    {
                        object o = Activator.CreateInstance(t);
                        f = o as Form;
                        if (f.Text == strFormText)
                            return f;
                    }
                    catch
                    {

                    }
                }                
            }
            return null;
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            if (tabControl1.Controls.Count > 0)
            {
                Form f = (Form)tabControl1.SelectedTab.Controls[0];
                f.WindowState = FormWindowState.Normal;
                f.WindowState = FormWindowState.Maximized;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
