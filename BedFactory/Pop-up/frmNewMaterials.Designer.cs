
namespace BedFactory.Pop_up
{
    partial class frmNewMaterials
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trvMaterials = new System.Windows.Forms.TreeView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lctCategory = new BedFactory.LabelComboText();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lctKind = new BedFactory.LabelComboText();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.ontSizeZ = new BedFactory.Controls.OnlyNumberTextBox();
            this.ontSizeY = new BedFactory.Controls.OnlyNumberTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ontSizeX = new BedFactory.Controls.OnlyNumberTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lctProductName = new BedFactory.LabelComboText();
            this.search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trvMaterials);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel2.Controls.Add(this.lctCategory);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.lctKind);
            this.splitContainer1.Panel2.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel2.Controls.Add(this.btnUpdate);
            this.splitContainer1.Panel2.Controls.Add(this.btnInsert);
            this.splitContainer1.Panel2.Controls.Add(this.ontSizeZ);
            this.splitContainer1.Panel2.Controls.Add(this.ontSizeY);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.ontSizeX);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.lctProductName);
            this.splitContainer1.Panel2.Controls.Add(this.search);
            this.splitContainer1.Size = new System.Drawing.Size(1184, 459);
            this.splitContainer1.SplitterDistance = 199;
            this.splitContainer1.TabIndex = 0;
            // 
            // trvMaterials
            // 
            this.trvMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvMaterials.Location = new System.Drawing.Point(0, 0);
            this.trvMaterials.Name = "trvMaterials";
            this.trvMaterials.Size = new System.Drawing.Size(199, 459);
            this.trvMaterials.TabIndex = 0;
            this.trvMaterials.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvMaterials_NodeMouseClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(899, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 25);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "추 가";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lctCategory
            // 
            this.lctCategory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lctCategory.BackColor = System.Drawing.Color.Transparent;
            this.lctCategory.BoxKind = BedFactory.LabelComboText.Kind.combo;
            this.lctCategory.ComboData = null;
            this.lctCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lctCategory.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lctCategory.Header = "구  분";
            this.lctCategory.Important = false;
            this.lctCategory.Location = new System.Drawing.Point(50, 234);
            this.lctCategory.MultiLine = false;
            this.lctCategory.MultiLineCnt = 0;
            this.lctCategory.Name = "lctCategory";
            this.lctCategory.Size = new System.Drawing.Size(413, 38);
            this.lctCategory.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(50, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "자재정보 설정";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(465, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "검사항목 설정";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(469, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 337);
            this.panel1.TabIndex = 19;
            // 
            // lctKind
            // 
            this.lctKind.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lctKind.BackColor = System.Drawing.Color.Transparent;
            this.lctKind.BoxKind = BedFactory.LabelComboText.Kind.combo;
            this.lctKind.ComboData = null;
            this.lctKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lctKind.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lctKind.Header = "종  류";
            this.lctKind.Important = false;
            this.lctKind.Location = new System.Drawing.Point(50, 340);
            this.lctKind.MultiLine = false;
            this.lctKind.MultiLineCnt = 0;
            this.lctKind.Name = "lctKind";
            this.lctKind.Size = new System.Drawing.Size(413, 38);
            this.lctKind.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(844, 397);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 50);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "삭 제";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUpdate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(713, 397);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 50);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "수 정";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnInsert.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsert.Location = new System.Drawing.Point(582, 397);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(125, 50);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "등 록";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // ontSizeZ
            // 
            this.ontSizeZ.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ontSizeZ.Decimal = false;
            this.ontSizeZ.Location = new System.Drawing.Point(374, 144);
            this.ontSizeZ.Name = "ontSizeZ";
            this.ontSizeZ.Size = new System.Drawing.Size(83, 25);
            this.ontSizeZ.TabIndex = 3;
            // 
            // ontSizeY
            // 
            this.ontSizeY.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ontSizeY.Decimal = false;
            this.ontSizeY.Location = new System.Drawing.Point(260, 144);
            this.ontSizeY.Name = "ontSizeY";
            this.ontSizeY.Size = new System.Drawing.Size(83, 25);
            this.ontSizeY.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "X";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            // 
            // ontSizeX
            // 
            this.ontSizeX.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ontSizeX.Decimal = false;
            this.ontSizeX.Location = new System.Drawing.Point(146, 144);
            this.ontSizeX.Name = "ontSizeX";
            this.ontSizeX.Size = new System.Drawing.Size(83, 25);
            this.ontSizeX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "* 사이즈";
            // 
            // lctProductName
            // 
            this.lctProductName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lctProductName.BackColor = System.Drawing.Color.Transparent;
            this.lctProductName.BoxKind = BedFactory.LabelComboText.Kind.text;
            this.lctProductName.ComboData = null;
            this.lctProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.lctProductName.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lctProductName.Header = "품  명";
            this.lctProductName.Important = true;
            this.lctProductName.Location = new System.Drawing.Point(50, 41);
            this.lctProductName.MultiLine = false;
            this.lctProductName.MultiLineCnt = 0;
            this.lctProductName.Name = "lctProductName";
            this.lctProductName.Size = new System.Drawing.Size(413, 38);
            this.lctProductName.TabIndex = 0;
            // 
            // search
            // 
            this.search.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.search.BackColor = System.Drawing.Color.LightSteelBlue;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search.Location = new System.Drawing.Point(260, 354);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(25, 17);
            this.search.TabIndex = 24;
            this.search.Text = "등 록";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // frmNewMaterials
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1184, 459);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.Name = "frmNewMaterials";
            this.Text = "품목등록";
            this.Load += new System.EventHandler(this.frmNewMaterials_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView trvMaterials;
        private LabelComboText lctProductName;
        private System.Windows.Forms.Label label1;
        private Controls.OnlyNumberTextBox ontSizeX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Controls.OnlyNumberTextBox ontSizeZ;
        private Controls.OnlyNumberTextBox ontSizeY;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private LabelComboText lctKind;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private LabelComboText lctCategory;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button btnAdd;
    }
}