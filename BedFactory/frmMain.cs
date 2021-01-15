using BedFactory;
using BedFactory.BaseForm;
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
        private static int i = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl1.Dock == DockStyle.Fill)
            {
                BaseForm1 frm = new BaseForm1();
                FormChildTab(frm, tabControl1);
            }
            else
            {
                TabControl tc = (TabControl)panel3.Controls["newTab"];
                BaseForm1 frm = new BaseForm1();
                FormChildTab(frm, tc);
            }
        }

        public void FormChildTab(Form f, TabControl tc)
        {
            TabPage tp = new TabPage(f.Text + i + "      ");
            i++;
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
            if (tabControl1.Dock == DockStyle.Fill)
            {
                tabControl1.Dock = DockStyle.Top;
                tabControl1.Size = new Size(493, 281);
                if (tabControl1.TabPages.Count > 0)
                {
                    Form f = (Form)tabControl1.SelectedTab.Controls[0];
                    f.WindowState = FormWindowState.Normal;
                    f.WindowState = FormWindowState.Maximized;
                }

                TabCustomControl1 tc = new TabCustomControl1();
                tc.Name = "newTab";
                tc.Size = new Size(493, 281);
                tc.Dock = DockStyle.Bottom;
                tc.MouseDown += tabControl1_MouseDown;
                panel3.Controls.Add(tc);
            }
            else
            {
                panel3.Controls.RemoveByKey("newTab");
                tabControl1.Dock = DockStyle.Fill;

                if(tabControl1.Controls.Count > 0)
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
    }
}
