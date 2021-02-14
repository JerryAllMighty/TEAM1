
namespace BadFactory
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnMenu1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pnMenu2 = new System.Windows.Forms.Panel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnMenuPut = new System.Windows.Forms.Button();
            this.pnSplitScreen = new System.Windows.Forms.Panel();
            this.pnNewTab = new System.Windows.Forms.Panel();
            this.btnTabPut = new System.Windows.Forms.Button();
            this.tabControl1 = new BadFactory.TabCustomControl1();
            this.pnMenu1.SuspendLayout();
            this.pnMenu2.SuspendLayout();
            this.pnSplitScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu1
            // 
            this.pnMenu1.Controls.Add(this.button3);
            this.pnMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenu1.Location = new System.Drawing.Point(0, 0);
            this.pnMenu1.Name = "pnMenu1";
            this.pnMenu1.Size = new System.Drawing.Size(1384, 100);
            this.pnMenu1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(200, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 57);
            this.button3.TabIndex = 5;
            this.button3.Text = "화면분활";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnMenu2
            // 
            this.pnMenu2.Controls.Add(this.pnMenu);
            this.pnMenu2.Controls.Add(this.btnMenuPut);
            this.pnMenu2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu2.Location = new System.Drawing.Point(0, 100);
            this.pnMenu2.Name = "pnMenu2";
            this.pnMenu2.Size = new System.Drawing.Size(200, 761);
            this.pnMenu2.TabIndex = 6;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.White;
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(181, 761);
            this.pnMenu.TabIndex = 1;
            // 
            // btnMenuPut
            // 
            this.btnMenuPut.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMenuPut.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMenuPut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenuPut.Location = new System.Drawing.Point(181, 0);
            this.btnMenuPut.Name = "btnMenuPut";
            this.btnMenuPut.Size = new System.Drawing.Size(19, 761);
            this.btnMenuPut.TabIndex = 0;
            this.btnMenuPut.Text = "◁";
            this.btnMenuPut.UseVisualStyleBackColor = false;
            this.btnMenuPut.Click += new System.EventHandler(this.btnPut_Click);
            // 
            // pnSplitScreen
            // 
            this.pnSplitScreen.Controls.Add(this.pnNewTab);
            this.pnSplitScreen.Controls.Add(this.btnTabPut);
            this.pnSplitScreen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnSplitScreen.Location = new System.Drawing.Point(200, 462);
            this.pnSplitScreen.Name = "pnSplitScreen";
            this.pnSplitScreen.Size = new System.Drawing.Size(1184, 399);
            this.pnSplitScreen.TabIndex = 9;
            this.pnSplitScreen.Visible = false;
            // 
            // pnNewTab
            // 
            this.pnNewTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnNewTab.Location = new System.Drawing.Point(0, 18);
            this.pnNewTab.Name = "pnNewTab";
            this.pnNewTab.Size = new System.Drawing.Size(1184, 381);
            this.pnNewTab.TabIndex = 2;
            // 
            // btnTabPut
            // 
            this.btnTabPut.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTabPut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTabPut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTabPut.Location = new System.Drawing.Point(0, 0);
            this.btnTabPut.Name = "btnTabPut";
            this.btnTabPut.Size = new System.Drawing.Size(1184, 19);
            this.btnTabPut.TabIndex = 1;
            this.btnTabPut.Text = "▽";
            this.btnTabPut.UseVisualStyleBackColor = false;
            this.btnTabPut.Click += new System.EventHandler(this.btnTabPut_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Location = new System.Drawing.Point(200, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1184, 362);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDown);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnSplitScreen);
            this.Controls.Add(this.pnMenu2);
            this.Controls.Add(this.pnMenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.pnMenu1.ResumeLayout(false);
            this.pnMenu2.ResumeLayout(false);
            this.pnSplitScreen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnMenu1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnMenu2;
        private System.Windows.Forms.Button btnMenuPut;
        private TabCustomControl1 tabControl1;
        private System.Windows.Forms.Panel pnSplitScreen;
        private System.Windows.Forms.Panel pnNewTab;
        private System.Windows.Forms.Button btnTabPut;
        private System.Windows.Forms.Panel pnMenu;
    }
}