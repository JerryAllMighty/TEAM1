
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
            this.btnDualScreen = new System.Windows.Forms.Button();
            this.pnMenu2 = new System.Windows.Forms.Panel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnMenuPut = new System.Windows.Forms.Button();
            this.pnSplitScreen = new System.Windows.Forms.Panel();
            this.pnNewTab = new System.Windows.Forms.Panel();
            this.btnTabPut = new System.Windows.Forms.Button();
            this.tabControl1 = new BadFactory.TabCustomControl1();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.lblEmpCategory = new System.Windows.Forms.Label();
            this.lblEmpDepartment = new System.Windows.Forms.Label();
            this.lblEmpEmail = new System.Windows.Forms.Label();
            this.pnMenu1.SuspendLayout();
            this.pnMenu2.SuspendLayout();
            this.pnSplitScreen.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu1
            // 
            this.pnMenu1.Controls.Add(this.btnUpdate);
            this.pnMenu1.Controls.Add(this.groupBox1);
            this.pnMenu1.Controls.Add(this.btnDualScreen);
            this.pnMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenu1.Location = new System.Drawing.Point(0, 0);
            this.pnMenu1.Name = "pnMenu1";
            this.pnMenu1.Size = new System.Drawing.Size(1384, 100);
            this.pnMenu1.TabIndex = 5;
            // 
            // btnDualScreen
            // 
            this.btnDualScreen.Location = new System.Drawing.Point(1292, 12);
            this.btnDualScreen.Name = "btnDualScreen";
            this.btnDualScreen.Size = new System.Drawing.Size(80, 80);
            this.btnDualScreen.TabIndex = 5;
            this.btnDualScreen.Text = "화면분활";
            this.btnDualScreen.UseVisualStyleBackColor = true;
            this.btnDualScreen.Click += new System.EventHandler(this.button3_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 82);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "직원정보";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "직원명";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1206, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 80);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "회원정보수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "직원ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "소속";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(571, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "직급";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "이메일";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(73, 26);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(75, 17);
            this.lblEmpName.TabIndex = 5;
            this.lblEmpName.Text = "Emp_Name";
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Location = new System.Drawing.Point(73, 53);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(53, 17);
            this.lblEmpID.TabIndex = 6;
            this.lblEmpID.Text = "Emp_ID";
            // 
            // lblEmpCategory
            // 
            this.lblEmpCategory.AutoSize = true;
            this.lblEmpCategory.Location = new System.Drawing.Point(624, 26);
            this.lblEmpCategory.Name = "lblEmpCategory";
            this.lblEmpCategory.Size = new System.Drawing.Size(93, 17);
            this.lblEmpCategory.TabIndex = 7;
            this.lblEmpCategory.Text = "Emp_Category";
            // 
            // lblEmpDepartment
            // 
            this.lblEmpDepartment.AutoSize = true;
            this.lblEmpDepartment.Location = new System.Drawing.Point(326, 26);
            this.lblEmpDepartment.Name = "lblEmpDepartment";
            this.lblEmpDepartment.Size = new System.Drawing.Size(110, 17);
            this.lblEmpDepartment.TabIndex = 8;
            this.lblEmpDepartment.Text = "Emp_Department";
            // 
            // lblEmpEmail
            // 
            this.lblEmpEmail.AutoSize = true;
            this.lblEmpEmail.Location = new System.Drawing.Point(326, 53);
            this.lblEmpEmail.Name = "lblEmpEmail";
            this.lblEmpEmail.Size = new System.Drawing.Size(93, 17);
            this.lblEmpEmail.TabIndex = 9;
            this.lblEmpEmail.Text = "Emp_Category";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnSplitScreen);
            this.Controls.Add(this.pnMenu2);
            this.Controls.Add(this.pnMenu1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "메인화면";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.pnMenu1.ResumeLayout(false);
            this.pnMenu2.ResumeLayout(false);
            this.pnSplitScreen.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnMenu1;
        private System.Windows.Forms.Button btnDualScreen;
        private System.Windows.Forms.Panel pnMenu2;
        private System.Windows.Forms.Button btnMenuPut;
        private TabCustomControl1 tabControl1;
        private System.Windows.Forms.Panel pnSplitScreen;
        private System.Windows.Forms.Panel pnNewTab;
        private System.Windows.Forms.Button btnTabPut;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEmpCategory;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEmpDepartment;
        private System.Windows.Forms.Label lblEmpEmail;
    }
}