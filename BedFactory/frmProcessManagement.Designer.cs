
namespace BedFactory
{
    partial class frmProcessManagement
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelComboText1 = new BedFactory.LabelComboText();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPrcName = new System.Windows.Forms.Label();
            this.lblPrcDName = new System.Windows.Forms.Label();
            this.dvgProcessInfo = new BedFactory.DatagridviewControl();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.txtProcessName = new System.Windows.Forms.TextBox();
            this.pnlSelect.SuspendLayout();
            this.pnlDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProcessInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.txtProcessName);
            this.pnlSelect.Controls.Add(this.cboCategory);
            this.pnlSelect.Controls.Add(this.label2);
            this.pnlSelect.Controls.Add(this.lblPrcDName);
            this.pnlSelect.Controls.Add(this.lblPrcName);
            this.pnlSelect.Controls.Add(this.label3);
            this.pnlSelect.Controls.SetChildIndex(this.label3, 0);
            this.pnlSelect.Controls.SetChildIndex(this.lblPrcName, 0);
            this.pnlSelect.Controls.SetChildIndex(this.lblPrcDName, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label2, 0);
            this.pnlSelect.Controls.SetChildIndex(this.cboCategory, 0);
            this.pnlSelect.Controls.SetChildIndex(this.txtProcessName, 0);
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.dvgProcessInfo);
            // 
            // btn1
            // 
            this.btn1.Text = "삭제";
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.Visible = false;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.Text = "공정정보";
            // 
            // btn5
            // 
            this.btn5.Visible = false;
            // 
            // btn3
            // 
            this.btn3.Text = "수정";
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Text = "등록";
            // 
            // labelComboText1
            // 
            this.labelComboText1.BackColor = System.Drawing.Color.Transparent;
            this.labelComboText1.BoxKind = BedFactory.LabelComboText.Kind.combo;
            this.labelComboText1.ComboData = null;
            this.labelComboText1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.labelComboText1.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.labelComboText1.Header = null;
            this.labelComboText1.Important = false;
            this.labelComboText1.Location = new System.Drawing.Point(492, 411);
            this.labelComboText1.MultiLine = false;
            this.labelComboText1.MultiLineCnt = 0;
            this.labelComboText1.Name = "labelComboText1";
            this.labelComboText1.Size = new System.Drawing.Size(398, 31);
            this.labelComboText1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "*";
            // 
            // lblPrcName
            // 
            this.lblPrcName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrcName.AutoSize = true;
            this.lblPrcName.Location = new System.Drawing.Point(26, 20);
            this.lblPrcName.Name = "lblPrcName";
            this.lblPrcName.Size = new System.Drawing.Size(78, 23);
            this.lblPrcName.TabIndex = 13;
            this.lblPrcName.Text = "공정분류";
            // 
            // lblPrcDName
            // 
            this.lblPrcDName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrcDName.AutoSize = true;
            this.lblPrcDName.Location = new System.Drawing.Point(391, 20);
            this.lblPrcDName.Name = "lblPrcDName";
            this.lblPrcDName.Size = new System.Drawing.Size(61, 23);
            this.lblPrcDName.TabIndex = 17;
            this.lblPrcDName.Text = "공정명";
            // 
            // dvgProcessInfo
            // 
            this.dvgProcessInfo.AllowUserToAddRows = false;
            this.dvgProcessInfo.AllowUserToResizeRows = false;
            this.dvgProcessInfo.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dvgProcessInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgProcessInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProcessInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgProcessInfo.Location = new System.Drawing.Point(0, 0);
            this.dvgProcessInfo.Name = "dvgProcessInfo";
            this.dvgProcessInfo.RowHeadersVisible = false;
            this.dvgProcessInfo.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dvgProcessInfo.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgProcessInfo.RowTemplate.Height = 27;
            this.dvgProcessInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgProcessInfo.Size = new System.Drawing.Size(1358, 711);
            this.dvgProcessInfo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "*";
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(129, 16);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(212, 31);
            this.cboCategory.TabIndex = 19;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // txtProcessName
            // 
            this.txtProcessName.Location = new System.Drawing.Point(517, 24);
            this.txtProcessName.Name = "txtProcessName";
            this.txtProcessName.Size = new System.Drawing.Size(100, 30);
            this.txtProcessName.TabIndex = 20;
            // 
            // frmProcessManagement
            // 
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Controls.Add(this.labelComboText1);
            this.Name = "frmProcessManagement";
            this.Text = "공정관리";
            this.Load += new System.EventHandler(this.frmFacilitiesManagement_Load);
            this.Controls.SetChildIndex(this.labelComboText1, 0);
            this.Controls.SetChildIndex(this.pnlSelect, 0);
            this.Controls.SetChildIndex(this.btn4, 0);
            this.Controls.SetChildIndex(this.pnlDgv, 0);
            this.Controls.SetChildIndex(this.btn1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btn5, 0);
            this.Controls.SetChildIndex(this.btn3, 0);
            this.Controls.SetChildIndex(this.btn2, 0);
            this.pnlSelect.ResumeLayout(false);
            this.pnlSelect.PerformLayout();
            this.pnlDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgProcessInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrcDName;
        private System.Windows.Forms.Label lblPrcName;
        private System.Windows.Forms.Label label3;
        private LabelComboText labelComboText1;
        private DatagridviewControl dvgProcessInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.TextBox txtProcessName;
    }
}
