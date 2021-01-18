
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.labelComboText1 = new BedFactory.LabelComboText();
            this.labelComboText2 = new BedFactory.LabelComboText();
            this.labelComboText3 = new BedFactory.LabelComboText();
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
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labelComboText3);
            this.splitContainer1.Panel2.Controls.Add(this.labelComboText2);
            this.splitContainer1.Panel2.Controls.Add(this.labelComboText1);
            this.splitContainer1.Size = new System.Drawing.Size(1184, 661);
            this.splitContainer1.SplitterDistance = 251;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(251, 661);
            this.treeView1.TabIndex = 0;
            // 
            // labelComboText1
            // 
            this.labelComboText1.BackColor = System.Drawing.Color.Transparent;
            this.labelComboText1.BoxKind = BedFactory.LabelComboText.Kind.text;
            this.labelComboText1.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.labelComboText1.Header = "* 품명";
            this.labelComboText1.Important = false;
            this.labelComboText1.Location = new System.Drawing.Point(65, 156);
            this.labelComboText1.MultiLine = false;
            this.labelComboText1.MultiLineCnt = 0;
            this.labelComboText1.Name = "labelComboText1";
            this.labelComboText1.Size = new System.Drawing.Size(279, 38);
            this.labelComboText1.TabIndex = 0;
            // 
            // labelComboText2
            // 
            this.labelComboText2.BackColor = System.Drawing.Color.Transparent;
            this.labelComboText2.BoxKind = BedFactory.LabelComboText.Kind.text;
            this.labelComboText2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.labelComboText2.Header = "* 거래처";
            this.labelComboText2.Important = false;
            this.labelComboText2.Location = new System.Drawing.Point(65, 223);
            this.labelComboText2.MultiLine = false;
            this.labelComboText2.MultiLineCnt = 0;
            this.labelComboText2.Name = "labelComboText2";
            this.labelComboText2.Size = new System.Drawing.Size(279, 38);
            this.labelComboText2.TabIndex = 1;
            // 
            // labelComboText3
            // 
            this.labelComboText3.BackColor = System.Drawing.Color.Transparent;
            this.labelComboText3.BoxKind = BedFactory.LabelComboText.Kind.text;
            this.labelComboText3.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.labelComboText3.Header = "* 사이즈";
            this.labelComboText3.Important = false;
            this.labelComboText3.Location = new System.Drawing.Point(65, 287);
            this.labelComboText3.MultiLine = false;
            this.labelComboText3.MultiLineCnt = 0;
            this.labelComboText3.Name = "labelComboText3";
            this.labelComboText3.Size = new System.Drawing.Size(279, 38);
            this.labelComboText3.TabIndex = 2;
            // 
            // frmNewMaterials
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.Name = "frmNewMaterials";
            this.Text = "품목등록";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private LabelComboText labelComboText1;
        private LabelComboText labelComboText2;
        private LabelComboText labelComboText3;
    }
}