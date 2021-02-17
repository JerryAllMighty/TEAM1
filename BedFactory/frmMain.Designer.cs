
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
            this.pnMenu2 = new System.Windows.Forms.Panel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnMenuPut = new System.Windows.Forms.Button();
            this.pnSplitScreen = new System.Windows.Forms.Panel();
            this.pnNewTab = new System.Windows.Forms.Panel();
            this.btnTabPut = new System.Windows.Forms.Button();
            this.tabControl1 = new BadFactory.TabCustomControl1();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnMenu2.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.pnSplitScreen.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenu2
            // 
            this.pnMenu2.Controls.Add(this.pnMenu);
            this.pnMenu2.Controls.Add(this.btnMenuPut);
            this.pnMenu2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu2.Location = new System.Drawing.Point(0, 0);
            this.pnMenu2.Name = "pnMenu2";
            this.pnMenu2.Size = new System.Drawing.Size(229, 933);
            this.pnMenu2.TabIndex = 6;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.White;
            this.pnMenu.Controls.Add(this.panel1);
            this.pnMenu.Controls.Add(this.tableLayoutPanel1);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(207, 933);
            this.pnMenu.TabIndex = 1;
            // 
            // btnMenuPut
            // 
            this.btnMenuPut.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMenuPut.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMenuPut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenuPut.Location = new System.Drawing.Point(207, 0);
            this.btnMenuPut.Name = "btnMenuPut";
            this.btnMenuPut.Size = new System.Drawing.Size(22, 933);
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
            this.pnSplitScreen.Location = new System.Drawing.Point(229, 501);
            this.pnSplitScreen.Name = "pnSplitScreen";
            this.pnSplitScreen.Size = new System.Drawing.Size(1353, 432);
            this.pnSplitScreen.TabIndex = 9;
            this.pnSplitScreen.Visible = false;
            // 
            // pnNewTab
            // 
            this.pnNewTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnNewTab.Location = new System.Drawing.Point(0, 20);
            this.pnNewTab.Name = "pnNewTab";
            this.pnNewTab.Size = new System.Drawing.Size(1353, 413);
            this.pnNewTab.TabIndex = 2;
            // 
            // btnTabPut
            // 
            this.btnTabPut.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTabPut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTabPut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTabPut.Location = new System.Drawing.Point(0, 0);
            this.btnTabPut.Name = "btnTabPut";
            this.btnTabPut.Size = new System.Drawing.Size(1353, 21);
            this.btnTabPut.TabIndex = 1;
            this.btnTabPut.Text = "▽";
            this.btnTabPut.UseVisualStyleBackColor = false;
            this.btnTabPut.Click += new System.EventHandler(this.btnTabPut_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Location = new System.Drawing.Point(229, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1353, 501);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(207, 76);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BedFactory.Properties.Resources.free_icon_hotel_bed_1274839;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::BedFactory.Properties.Resources.pngwing_com__1_;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(106, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 70);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 857);
            this.panel1.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 933);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnSplitScreen);
            this.Controls.Add(this.pnMenu2);
            this.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.pnMenu2.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.pnSplitScreen.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnMenu2;
        private System.Windows.Forms.Button btnMenuPut;
        private TabCustomControl1 tabControl1;
        private System.Windows.Forms.Panel pnSplitScreen;
        private System.Windows.Forms.Panel pnNewTab;
        private System.Windows.Forms.Button btnTabPut;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}