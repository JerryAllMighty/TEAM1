
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelComboText1 = new BedFactory.LabelComboText();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFcsName = new System.Windows.Forms.Label();
            this.lblFcsNum = new System.Windows.Forms.Label();
            this.datagridviewControl1 = new BedFactory.DatagridviewControl();
            this.label2 = new System.Windows.Forms.Label();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.cboNum_D = new System.Windows.Forms.ComboBox();
            this.pnlSelect.SuspendLayout();
            this.pnlDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.cboNum_D);
            this.pnlSelect.Controls.Add(this.cboName);
            this.pnlSelect.Controls.Add(this.label2);
            this.pnlSelect.Controls.Add(this.lblFcsNum);
            this.pnlSelect.Controls.Add(this.lblFcsName);
            this.pnlSelect.Controls.Add(this.label3);
            this.pnlSelect.Controls.SetChildIndex(this.label3, 0);
            this.pnlSelect.Controls.SetChildIndex(this.lblFcsName, 0);
            this.pnlSelect.Controls.SetChildIndex(this.lblFcsNum, 0);
            this.pnlSelect.Controls.SetChildIndex(this.label2, 0);
            this.pnlSelect.Controls.SetChildIndex(this.cboName, 0);
            this.pnlSelect.Controls.SetChildIndex(this.cboNum_D, 0);
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.datagridviewControl1);
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
            this.btn3.Visible = false;
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
            // lblFcsName
            // 
            this.lblFcsName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFcsName.AutoSize = true;
            this.lblFcsName.Location = new System.Drawing.Point(26, 20);
            this.lblFcsName.Name = "lblFcsName";
            this.lblFcsName.Size = new System.Drawing.Size(78, 23);
            this.lblFcsName.TabIndex = 13;
            this.lblFcsName.Text = "공정분류";
            // 
            // lblFcsNum
            // 
            this.lblFcsNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFcsNum.AutoSize = true;
            this.lblFcsNum.Location = new System.Drawing.Point(391, 20);
            this.lblFcsNum.Name = "lblFcsNum";
            this.lblFcsNum.Size = new System.Drawing.Size(112, 23);
            this.lblFcsNum.TabIndex = 17;
            this.lblFcsNum.Text = "공정상세번호";
            // 
            // datagridviewControl1
            // 
            this.datagridviewControl1.AllowUserToAddRows = false;
            this.datagridviewControl1.AllowUserToResizeRows = false;
            this.datagridviewControl1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.datagridviewControl1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagridviewControl1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridviewControl1.Location = new System.Drawing.Point(0, 0);
            this.datagridviewControl1.Name = "datagridviewControl1";
            this.datagridviewControl1.RowHeadersVisible = false;
            this.datagridviewControl1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.datagridviewControl1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridviewControl1.RowTemplate.Height = 27;
            this.datagridviewControl1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewControl1.Size = new System.Drawing.Size(1358, 711);
            this.datagridviewControl1.TabIndex = 0;
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
            // cboName
            // 
            this.cboName.FormattingEnabled = true;
            this.cboName.Location = new System.Drawing.Point(129, 16);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(212, 31);
            this.cboName.TabIndex = 19;
            // 
            // cboNum_D
            // 
            this.cboNum_D.FormattingEnabled = true;
            this.cboNum_D.Location = new System.Drawing.Point(509, 16);
            this.cboNum_D.Name = "cboNum_D";
            this.cboNum_D.Size = new System.Drawing.Size(212, 31);
            this.cboNum_D.TabIndex = 20;
            // 
            // frmFacilitiesManagement
            // 
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Controls.Add(this.labelComboText1);
            this.Name = "frmFacilitiesManagement";
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
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFcsNum;
        private System.Windows.Forms.Label lblFcsName;
        private System.Windows.Forms.Label label3;
        private LabelComboText labelComboText1;
        private DatagridviewControl datagridviewControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboNum_D;
        private System.Windows.Forms.ComboBox cboName;
    }
}
