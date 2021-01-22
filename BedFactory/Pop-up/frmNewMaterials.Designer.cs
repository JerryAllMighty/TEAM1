
namespace BedFactory
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("원자재");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("반자재");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("완제품");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("메트릭스");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialsCheckList4 = new BedFactory.Controls.MaterialsCheckList();
            this.materialsCheckList3 = new BedFactory.Controls.MaterialsCheckList();
            this.materialsCheckList2 = new BedFactory.Controls.MaterialsCheckList();
            this.materialsCheckList1 = new BedFactory.Controls.MaterialsCheckList();
            this.onlyNumberTextBox4 = new BedFactory.Controls.OnlyNumberTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelComboText4 = new BedFactory.LabelComboText();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.onlyNumberTextBox3 = new BedFactory.Controls.OnlyNumberTextBox();
            this.onlyNumberTextBox2 = new BedFactory.Controls.OnlyNumberTextBox();
            this.labelComboText3 = new BedFactory.LabelComboText();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.onlyNumberTextBox1 = new BedFactory.Controls.OnlyNumberTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelComboText2 = new BedFactory.LabelComboText();
            this.labelComboText1 = new BedFactory.LabelComboText();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.onlyNumberTextBox4);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.labelComboText4);
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.onlyNumberTextBox3);
            this.splitContainer1.Panel2.Controls.Add(this.onlyNumberTextBox2);
            this.splitContainer1.Panel2.Controls.Add(this.labelComboText3);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.onlyNumberTextBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.labelComboText2);
            this.splitContainer1.Panel2.Controls.Add(this.labelComboText1);
            this.splitContainer1.Size = new System.Drawing.Size(1184, 459);
            this.splitContainer1.SplitterDistance = 199;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "노드0";
            treeNode1.Text = "원자재";
            treeNode2.Name = "노드1";
            treeNode2.Text = "반자재";
            treeNode3.Name = "노드2";
            treeNode3.Text = "완제품";
            treeNode4.Name = "노드3";
            treeNode4.Text = "메트릭스";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(199, 459);
            this.treeView1.TabIndex = 0;
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
            this.panel1.Controls.Add(this.materialsCheckList4);
            this.panel1.Controls.Add(this.materialsCheckList3);
            this.panel1.Controls.Add(this.materialsCheckList2);
            this.panel1.Controls.Add(this.materialsCheckList1);
            this.panel1.Location = new System.Drawing.Point(469, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 337);
            this.panel1.TabIndex = 19;
            // 
            // materialsCheckList4
            // 
            this.materialsCheckList4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialsCheckList4.BackColor = System.Drawing.Color.Transparent;
            this.materialsCheckList4.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.materialsCheckList4.Location = new System.Drawing.Point(5, 256);
            this.materialsCheckList4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialsCheckList4.Name = "materialsCheckList4";
            this.materialsCheckList4.Size = new System.Drawing.Size(490, 77);
            this.materialsCheckList4.TabIndex = 3;
            // 
            // materialsCheckList3
            // 
            this.materialsCheckList3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialsCheckList3.BackColor = System.Drawing.Color.Transparent;
            this.materialsCheckList3.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.materialsCheckList3.Location = new System.Drawing.Point(5, 171);
            this.materialsCheckList3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialsCheckList3.Name = "materialsCheckList3";
            this.materialsCheckList3.Size = new System.Drawing.Size(490, 77);
            this.materialsCheckList3.TabIndex = 2;
            // 
            // materialsCheckList2
            // 
            this.materialsCheckList2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialsCheckList2.BackColor = System.Drawing.Color.Transparent;
            this.materialsCheckList2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.materialsCheckList2.Location = new System.Drawing.Point(5, 86);
            this.materialsCheckList2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialsCheckList2.Name = "materialsCheckList2";
            this.materialsCheckList2.Size = new System.Drawing.Size(490, 77);
            this.materialsCheckList2.TabIndex = 1;
            // 
            // materialsCheckList1
            // 
            this.materialsCheckList1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialsCheckList1.BackColor = System.Drawing.Color.Transparent;
            this.materialsCheckList1.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.materialsCheckList1.Location = new System.Drawing.Point(5, 1);
            this.materialsCheckList1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialsCheckList1.Name = "materialsCheckList1";
            this.materialsCheckList1.Size = new System.Drawing.Size(490, 77);
            this.materialsCheckList1.TabIndex = 0;
            // 
            // onlyNumberTextBox4
            // 
            this.onlyNumberTextBox4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.onlyNumberTextBox4.Decimal = false;
            this.onlyNumberTextBox4.Location = new System.Drawing.Point(146, 230);
            this.onlyNumberTextBox4.Name = "onlyNumberTextBox4";
            this.onlyNumberTextBox4.Size = new System.Drawing.Size(311, 25);
            this.onlyNumberTextBox4.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(50, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "* 단  가";
            // 
            // labelComboText4
            // 
            this.labelComboText4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelComboText4.BackColor = System.Drawing.Color.Transparent;
            this.labelComboText4.BoxKind = BedFactory.LabelComboText.Kind.combo;
            this.labelComboText4.ComboData = null;
            this.labelComboText4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.labelComboText4.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.labelComboText4.Header = "종  류";
            this.labelComboText4.Important = false;
            this.labelComboText4.Location = new System.Drawing.Point(50, 350);
            this.labelComboText4.MultiLine = false;
            this.labelComboText4.MultiLineCnt = 0;
            this.labelComboText4.Name = "labelComboText4";
            this.labelComboText4.Size = new System.Drawing.Size(413, 38);
            this.labelComboText4.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(887, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 34);
            this.button3.TabIndex = 14;
            this.button3.Text = "삭 제";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(793, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 34);
            this.button2.TabIndex = 13;
            this.button2.Text = "수 정";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(699, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "등 록";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // onlyNumberTextBox3
            // 
            this.onlyNumberTextBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.onlyNumberTextBox3.Decimal = false;
            this.onlyNumberTextBox3.Location = new System.Drawing.Point(374, 174);
            this.onlyNumberTextBox3.Name = "onlyNumberTextBox3";
            this.onlyNumberTextBox3.Size = new System.Drawing.Size(83, 25);
            this.onlyNumberTextBox3.TabIndex = 11;
            // 
            // onlyNumberTextBox2
            // 
            this.onlyNumberTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.onlyNumberTextBox2.Decimal = false;
            this.onlyNumberTextBox2.Location = new System.Drawing.Point(260, 174);
            this.onlyNumberTextBox2.Name = "onlyNumberTextBox2";
            this.onlyNumberTextBox2.Size = new System.Drawing.Size(83, 25);
            this.onlyNumberTextBox2.TabIndex = 10;
            // 
            // labelComboText3
            // 
            this.labelComboText3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelComboText3.BackColor = System.Drawing.Color.Transparent;
            this.labelComboText3.BoxKind = BedFactory.LabelComboText.Kind.combo;
            this.labelComboText3.ComboData = null;
            this.labelComboText3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.labelComboText3.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.labelComboText3.Header = "BOM";
            this.labelComboText3.Important = false;
            this.labelComboText3.Location = new System.Drawing.Point(50, 282);
            this.labelComboText3.MultiLine = false;
            this.labelComboText3.MultiLineCnt = 0;
            this.labelComboText3.Name = "labelComboText3";
            this.labelComboText3.Size = new System.Drawing.Size(413, 38);
            this.labelComboText3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "X";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            // 
            // onlyNumberTextBox1
            // 
            this.onlyNumberTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.onlyNumberTextBox1.Decimal = false;
            this.onlyNumberTextBox1.Location = new System.Drawing.Point(146, 174);
            this.onlyNumberTextBox1.Name = "onlyNumberTextBox1";
            this.onlyNumberTextBox1.Size = new System.Drawing.Size(83, 25);
            this.onlyNumberTextBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "* 사이즈";
            // 
            // labelComboText2
            // 
            this.labelComboText2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelComboText2.BackColor = System.Drawing.Color.Transparent;
            this.labelComboText2.BoxKind = BedFactory.LabelComboText.Kind.text;
            this.labelComboText2.ComboData = null;
            this.labelComboText2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.labelComboText2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.labelComboText2.Header = "거래처";
            this.labelComboText2.Important = true;
            this.labelComboText2.Location = new System.Drawing.Point(50, 109);
            this.labelComboText2.MultiLine = false;
            this.labelComboText2.MultiLineCnt = 0;
            this.labelComboText2.Name = "labelComboText2";
            this.labelComboText2.Size = new System.Drawing.Size(413, 38);
            this.labelComboText2.TabIndex = 1;
            // 
            // labelComboText1
            // 
            this.labelComboText1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelComboText1.BackColor = System.Drawing.Color.Transparent;
            this.labelComboText1.BoxKind = BedFactory.LabelComboText.Kind.text;
            this.labelComboText1.ComboData = null;
            this.labelComboText1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.labelComboText1.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.labelComboText1.Header = "품  명";
            this.labelComboText1.Important = true;
            this.labelComboText1.Location = new System.Drawing.Point(50, 41);
            this.labelComboText1.MultiLine = false;
            this.labelComboText1.MultiLineCnt = 0;
            this.labelComboText1.Name = "labelComboText1";
            this.labelComboText1.Size = new System.Drawing.Size(413, 38);
            this.labelComboText1.TabIndex = 0;
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
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private LabelComboText labelComboText1;
        private LabelComboText labelComboText2;
        private System.Windows.Forms.Label label1;
        private Controls.OnlyNumberTextBox onlyNumberTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private LabelComboText labelComboText3;
        private Controls.OnlyNumberTextBox onlyNumberTextBox3;
        private Controls.OnlyNumberTextBox onlyNumberTextBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private LabelComboText labelComboText4;
        private Controls.OnlyNumberTextBox onlyNumberTextBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private Controls.MaterialsCheckList materialsCheckList4;
        private Controls.MaterialsCheckList materialsCheckList3;
        private Controls.MaterialsCheckList materialsCheckList2;
        private Controls.MaterialsCheckList materialsCheckList1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}