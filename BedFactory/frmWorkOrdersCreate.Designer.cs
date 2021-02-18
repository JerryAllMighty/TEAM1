
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvWOC = new BedFactory.DatagridviewControl();
            this.searchLocationControl1 = new BedFactory.Controls.SearchLocationControl();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPlanNum = new System.Windows.Forms.Label();
            this.txtProductionPlanNum = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pnlDgv.SuspendLayout();
            this.pnlSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWOC)).BeginInit();
            this.searchLocationControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(1304, 133);
            this.btn2.Text = "등록";
            this.btn2.Click += new System.EventHandler(this.btn2_Click_1);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(1102, 134);
            this.btn3.Visible = false;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(1173, 134);
            this.btn5.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.Text = "생산계획현황";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(925, 134);
            this.btn1.Visible = false;
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.dgvWOC);
            this.pnlDgv.Location = new System.Drawing.Point(12, 165);
            this.pnlDgv.Size = new System.Drawing.Size(1358, 676);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(996, 134);
            this.btn4.Visible = false;
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.searchLocationControl1);
            // 
            // dgvWOC
            // 
            this.dgvWOC.AllowUserToAddRows = false;
            this.dgvWOC.AllowUserToResizeRows = false;
            this.dgvWOC.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvWOC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWOC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWOC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWOC.Location = new System.Drawing.Point(0, 0);
            this.dgvWOC.Name = "dgvWOC";
            this.dgvWOC.RowHeadersVisible = false;
            this.dgvWOC.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvWOC.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWOC.RowTemplate.Height = 27;
            this.dgvWOC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWOC.Size = new System.Drawing.Size(1358, 676);
            this.dgvWOC.TabIndex = 0;
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
            this.searchLocationControl1.Controls.Add(this.dtpFrom, 1, 0);
            this.searchLocationControl1.Controls.Add(this.label3, 0, 0);
            this.searchLocationControl1.Controls.Add(this.lblPlanNum, 3, 0);
            this.searchLocationControl1.Controls.Add(this.txtProductionPlanNum, 4, 0);
            this.searchLocationControl1.Controls.Add(this.btnSelect, 9, 0);
            this.searchLocationControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchLocationControl1.Location = new System.Drawing.Point(0, 0);
            this.searchLocationControl1.Name = "searchLocationControl1";
            this.searchLocationControl1.RowCount = 1;
            this.searchLocationControl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchLocationControl1.Size = new System.Drawing.Size(1356, 63);
            this.searchLocationControl1.TabIndex = 1;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(200, 16);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(113, 30);
            this.dtpFrom.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 78;
            this.label3.Text = "계획시작일";
            // 
            // lblPlanNum
            // 
            this.lblPlanNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlanNum.AutoSize = true;
            this.lblPlanNum.Location = new System.Drawing.Point(430, 20);
            this.lblPlanNum.Name = "lblPlanNum";
            this.lblPlanNum.Size = new System.Drawing.Size(112, 23);
            this.lblPlanNum.TabIndex = 85;
            this.lblPlanNum.Text = "생산계획번호";
            // 
            // txtProductionPlanNum
            // 
            this.txtProductionPlanNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductionPlanNum.Location = new System.Drawing.Point(558, 16);
            this.txtProductionPlanNum.Name = "txtProductionPlanNum";
            this.txtProductionPlanNum.Size = new System.Drawing.Size(235, 30);
            this.txtProductionPlanNum.TabIndex = 86;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelect.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelect.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelect.Location = new System.Drawing.Point(1271, 16);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(70, 30);
            this.btnSelect.TabIndex = 68;
            this.btnSelect.Text = "조회";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // frmWorkOrdersCreate
            // 
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Name = "frmWorkOrdersCreate";
            this.Text = "작업지시생성";
            this.Load += new System.EventHandler(this.frmWorkOrderCreate_Load);
            this.pnlDgv.ResumeLayout(false);
            this.pnlSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWOC)).EndInit();
            this.searchLocationControl1.ResumeLayout(false);
            this.searchLocationControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatagridviewControl dgvWOC;
        private Controls.SearchLocationControl searchLocationControl1;
        protected System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPlanNum;
        private System.Windows.Forms.TextBox txtProductionPlanNum;
        private System.Windows.Forms.DateTimePicker dtpFrom;
    }
}
