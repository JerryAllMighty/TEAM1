
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEmpEmail = new System.Windows.Forms.Label();
            this.lblEmpDepartment = new System.Windows.Forms.Label();
            this.lblEmpCategory = new System.Windows.Forms.Label();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnMenu2 = new System.Windows.Forms.Panel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnMenuPut = new System.Windows.Forms.Button();
            this.pnSplitScreen = new System.Windows.Forms.Panel();
            this.pnNewTab = new System.Windows.Forms.Panel();
            this.btnTabPut = new System.Windows.Forms.Button();
            this.tabControl1 = new BadFactory.TabCustomControl1();
            this.pnMenu1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnMenu2.SuspendLayout();
            this.pnSplitScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu1
            // 
            this.pnMenu1.BackColor = System.Drawing.Color.White;
            this.pnMenu1.Controls.Add(this.groupBox1);
            this.pnMenu1.Controls.Add(this.panel1);
            this.pnMenu1.Controls.Add(this.pictureBox1);
            this.pnMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenu1.Location = new System.Drawing.Point(0, 0);
            this.pnMenu1.Name = "pnMenu1";
            this.pnMenu1.Size = new System.Drawing.Size(1582, 108);
            this.pnMenu1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEmpEmail);
            this.groupBox1.Controls.Add(this.lblEmpDepartment);
            this.groupBox1.Controls.Add(this.lblEmpCategory);
            this.groupBox1.Controls.Add(this.lblEmpID);
            this.groupBox1.Controls.Add(this.lblEmpName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(673, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 82);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "직원정보";
            // 
            // lblEmpEmail
            // 
            this.lblEmpEmail.AutoSize = true;
            this.lblEmpEmail.Location = new System.Drawing.Point(326, 53);
            this.lblEmpEmail.Name = "lblEmpEmail";
            this.lblEmpEmail.Size = new System.Drawing.Size(97, 13);
            this.lblEmpEmail.TabIndex = 9;
            this.lblEmpEmail.Text = "Emp_Category";
            // 
            // lblEmpDepartment
            // 
            this.lblEmpDepartment.AutoSize = true;
            this.lblEmpDepartment.Location = new System.Drawing.Point(326, 26);
            this.lblEmpDepartment.Name = "lblEmpDepartment";
            this.lblEmpDepartment.Size = new System.Drawing.Size(112, 13);
            this.lblEmpDepartment.TabIndex = 8;
            this.lblEmpDepartment.Text = "Emp_Department";
            // 
            // lblEmpCategory
            // 
            this.lblEmpCategory.AutoSize = true;
            this.lblEmpCategory.Location = new System.Drawing.Point(624, 26);
            this.lblEmpCategory.Name = "lblEmpCategory";
            this.lblEmpCategory.Size = new System.Drawing.Size(97, 13);
            this.lblEmpCategory.TabIndex = 7;
            this.lblEmpCategory.Text = "Emp_Category";
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Location = new System.Drawing.Point(73, 53);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(53, 13);
            this.lblEmpID.TabIndex = 6;
            this.lblEmpID.Text = "Emp_ID";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(73, 26);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(77, 13);
            this.lblEmpName.TabIndex = 5;
            this.lblEmpName.Text = "Emp_Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "이메일";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(571, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "직급";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "소속";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "직원ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "직원명";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(229, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 99);
            this.panel1.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::BedFactory.Properties.Resources.pngwing_com__1_;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(-10, -3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 108);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BedFactory.Properties.Resources.free_icon_hotel_bed_1274839;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pnMenu2
            // 
            this.pnMenu2.Controls.Add(this.pnMenu);
            this.pnMenu2.Controls.Add(this.btnMenuPut);
            this.pnMenu2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu2.Location = new System.Drawing.Point(0, 108);
            this.pnMenu2.Name = "pnMenu2";
            this.pnMenu2.Size = new System.Drawing.Size(229, 825);
            this.pnMenu2.TabIndex = 6;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.White;
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(207, 825);
            this.pnMenu.TabIndex = 1;
            // 
            // btnMenuPut
            // 
            this.btnMenuPut.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMenuPut.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMenuPut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenuPut.Location = new System.Drawing.Point(207, 0);
            this.btnMenuPut.Name = "btnMenuPut";
            this.btnMenuPut.Size = new System.Drawing.Size(22, 825);
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
            this.tabControl1.Location = new System.Drawing.Point(229, 108);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1353, 393);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDown);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 933);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnSplitScreen);
            this.Controls.Add(this.pnMenu2);
            this.Controls.Add(this.pnMenu1);
            this.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.pnMenu1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEmpEmail;
        private System.Windows.Forms.Label lblEmpDepartment;
        private System.Windows.Forms.Label lblEmpCategory;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}