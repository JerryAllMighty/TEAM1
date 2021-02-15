
namespace BedFactory
{
    partial class frmWorkOrdersCreate
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
            this.dgvWOS = new BedFactory.DatagridviewControl();
            this.btnWOdelete = new System.Windows.Forms.Button();
            this.searchLocationControl1 = new BedFactory.Controls.SearchLocationControl();
            this.cboWp = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cboMat = new System.Windows.Forms.ComboBox();
            this.cboWs = new System.Windows.Forms.ComboBox();
            this.pnlDgv.SuspendLayout();
            this.pnlSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWOS)).BeginInit();
            this.searchLocationControl1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(1234, 133);
            this.btn2.Text = "등록";
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(866, 134);
            this.btn3.Visible = false;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(1103, 134);
            this.btn5.Text = "작업지시확정";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.Text = "작업지시생성";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(1305, 133);
            this.btn1.Text = "엑셀";
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.dgvWOS);
            this.pnlDgv.Location = new System.Drawing.Point(12, 165);
            this.pnlDgv.Size = new System.Drawing.Size(1358, 676);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(760, 134);
            this.btn4.Visible = false;
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.searchLocationControl1);
            this.pnlSelect.Size = new System.Drawing.Size(1358, 100);
            // 
            // dgvWOS
            // 
            this.dgvWOS.AllowUserToAddRows = false;
            this.dgvWOS.AllowUserToResizeRows = false;
            this.dgvWOS.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvWOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvWOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWOS.Location = new System.Drawing.Point(0, 0);
            this.dgvWOS.Name = "dgvWOS";
            this.dgvWOS.RowHeadersVisible = false;
            this.dgvWOS.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvWOS.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvWOS.RowTemplate.Height = 27;
            this.dgvWOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWOS.Size = new System.Drawing.Size(1358, 676);
            this.dgvWOS.TabIndex = 0;
            // 
            // btnWOdelete
            // 
            this.btnWOdelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWOdelete.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnWOdelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWOdelete.Location = new System.Drawing.Point(937, 134);
            this.btnWOdelete.Name = "btnWOdelete";
            this.btnWOdelete.Size = new System.Drawing.Size(160, 25);
            this.btnWOdelete.TabIndex = 52;
            this.btnWOdelete.Text = "작업지시계획삭제";
            this.btnWOdelete.UseVisualStyleBackColor = false;
            // 
            // searchLocationControl1
            // 
            this.searchLocationControl1.ColumnCount = 10;
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.searchLocationControl1.Controls.Add(this.cboWp, 4, 0);
            this.searchLocationControl1.Controls.Add(this.btnSelect, 9, 1);
            this.searchLocationControl1.Controls.Add(this.panel2, 1, 0);
            this.searchLocationControl1.Controls.Add(this.label3, 0, 0);
            this.searchLocationControl1.Controls.Add(this.label5, 3, 0);
            this.searchLocationControl1.Controls.Add(this.label2, 6, 0);
            this.searchLocationControl1.Controls.Add(this.label12, 0, 1);
            this.searchLocationControl1.Controls.Add(this.cboMat, 7, 0);
            this.searchLocationControl1.Controls.Add(this.cboWs, 1, 1);
            this.searchLocationControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchLocationControl1.Location = new System.Drawing.Point(0, 0);
            this.searchLocationControl1.Name = "searchLocationControl1";
            this.searchLocationControl1.RowCount = 2;
            this.searchLocationControl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchLocationControl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchLocationControl1.Size = new System.Drawing.Size(1356, 98);
            this.searchLocationControl1.TabIndex = 1;
            // 
            // cboWp
            // 
            this.cboWp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboWp.FormattingEnabled = true;
            this.cboWp.Location = new System.Drawing.Point(558, 13);
            this.cboWp.Name = "cboWp";
            this.cboWp.Size = new System.Drawing.Size(235, 31);
            this.cboWp.TabIndex = 80;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelect.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelect.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelect.Location = new System.Drawing.Point(1271, 58);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(70, 30);
            this.btnSelect.TabIndex = 68;
            this.btnSelect.Text = "조회";
            this.btnSelect.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.dtpTo);
            this.panel2.Controls.Add(this.dtpFrom);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(139, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 26);
            this.panel2.TabIndex = 79;
            // 
            // dtpTo
            // 
            this.dtpTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(122, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(113, 30);
            this.dtpTo.TabIndex = 71;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(113, 30);
            this.dtpFrom.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "~";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 78;
            this.label3.Text = "계획시작일";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 23);
            this.label5.TabIndex = 69;
            this.label5.Text = "작업장";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(875, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 80;
            this.label2.Text = "자재명";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 23);
            this.label12.TabIndex = 75;
            this.label12.Text = "작업상태";
            // 
            // cboMat
            // 
            this.cboMat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboMat.FormattingEnabled = true;
            this.cboMat.Location = new System.Drawing.Point(977, 13);
            this.cboMat.Name = "cboMat";
            this.cboMat.Size = new System.Drawing.Size(235, 31);
            this.cboMat.TabIndex = 83;
            // 
            // cboWs
            // 
            this.cboWs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboWs.FormattingEnabled = true;
            this.cboWs.Location = new System.Drawing.Point(139, 62);
            this.cboWs.Name = "cboWs";
            this.cboWs.Size = new System.Drawing.Size(235, 31);
            this.cboWs.TabIndex = 84;
            // 
            // frmWorkOrdersCreate
            // 
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Controls.Add(this.btnWOdelete);
            this.Name = "frmWorkOrdersCreate";
            this.Text = "작업지시생성";
            this.Load += new System.EventHandler(this.frmWorkOrderCreate_Load);
            this.Controls.SetChildIndex(this.btnWOdelete, 0);
            this.Controls.SetChildIndex(this.pnlSelect, 0);
            this.Controls.SetChildIndex(this.btn4, 0);
            this.Controls.SetChildIndex(this.pnlDgv, 0);
            this.Controls.SetChildIndex(this.btn1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btn5, 0);
            this.Controls.SetChildIndex(this.btn3, 0);
            this.Controls.SetChildIndex(this.btn2, 0);
            this.pnlDgv.ResumeLayout(false);
            this.pnlSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWOS)).EndInit();
            this.searchLocationControl1.ResumeLayout(false);
            this.searchLocationControl1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatagridviewControl dgvWOS;
        private System.Windows.Forms.Button btnWOdelete;
        private Controls.SearchLocationControl searchLocationControl1;
        private System.Windows.Forms.ComboBox cboWp;
        protected System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboMat;
        private System.Windows.Forms.ComboBox cboWs;
    }
}
