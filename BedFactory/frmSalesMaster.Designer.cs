
namespace BedFactory
{
    partial class frmSalesMaster
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
            this.searchLocationControl1 = new BedFactory.Controls.SearchLocationControl();
            this.lblCustomerDeadline = new System.Windows.Forms.Label();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.txtOrder_Num = new System.Windows.Forms.TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblOrder_Num = new System.Windows.Forms.Label();
            this.cboCompany = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblSubject_Name = new System.Windows.Forms.Label();
            this.txtSubject_Name = new System.Windows.Forms.TextBox();
            this.lblUploadDate = new System.Windows.Forms.Label();
            this.dtpUploadDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvSalesMaster = new BedFactory.DatagridviewControl();
            this.pnlDgv.SuspendLayout();
            this.pnlSelect.SuspendLayout();
            this.searchLocationControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(1199, 144);
            this.btn2.Text = "수동";
            this.btn2.Visible = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click_1);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(1270, 140);
            this.btn3.Size = new System.Drawing.Size(100, 30);
            this.btn3.Text = "수요 계획 생성";
            this.btn3.Click += new System.EventHandler(this.btn3_Click_1);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(962, 143);
            this.btn5.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 144);
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.Text = "영업 마스터";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(891, 143);
            this.btn1.Visible = false;
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.dgvSalesMaster);
            this.pnlDgv.Controls.Add(this.button1);
            this.pnlDgv.Location = new System.Drawing.Point(12, 181);
            this.pnlDgv.Size = new System.Drawing.Size(1358, 660);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(1093, 143);
            this.btn4.Visible = false;
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.searchLocationControl1);
            this.pnlSelect.Size = new System.Drawing.Size(1358, 100);
            // 
            // searchLocationControl1
            // 
            this.searchLocationControl1.ColumnCount = 10;
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.36364F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.727273F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.36364F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.727273F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.36364F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.81818F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.363636F));
            this.searchLocationControl1.Controls.Add(this.lblCustomerDeadline, 0, 0);
            this.searchLocationControl1.Controls.Add(this.dtpDeadline, 1, 0);
            this.searchLocationControl1.Controls.Add(this.txtOrder_Num, 7, 0);
            this.searchLocationControl1.Controls.Add(this.lblCompany, 3, 0);
            this.searchLocationControl1.Controls.Add(this.lblOrder_Num, 6, 0);
            this.searchLocationControl1.Controls.Add(this.cboCompany, 4, 0);
            this.searchLocationControl1.Controls.Add(this.btnSelect, 9, 1);
            this.searchLocationControl1.Controls.Add(this.lblSubject_Name, 0, 1);
            this.searchLocationControl1.Controls.Add(this.txtSubject_Name, 1, 1);
            this.searchLocationControl1.Controls.Add(this.lblUploadDate, 3, 1);
            this.searchLocationControl1.Controls.Add(this.dtpUploadDate, 4, 1);
            this.searchLocationControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchLocationControl1.Location = new System.Drawing.Point(0, 0);
            this.searchLocationControl1.Name = "searchLocationControl1";
            this.searchLocationControl1.RowCount = 2;
            this.searchLocationControl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchLocationControl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchLocationControl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.searchLocationControl1.Size = new System.Drawing.Size(1356, 98);
            this.searchLocationControl1.TabIndex = 0;
            // 
            // lblCustomerDeadline
            // 
            this.lblCustomerDeadline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCustomerDeadline.AutoSize = true;
            this.lblCustomerDeadline.Location = new System.Drawing.Point(11, 13);
            this.lblCustomerDeadline.Name = "lblCustomerDeadline";
            this.lblCustomerDeadline.Size = new System.Drawing.Size(101, 23);
            this.lblCustomerDeadline.TabIndex = 29;
            this.lblCustomerDeadline.Text = "고객 납기일";
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDeadline.Location = new System.Drawing.Point(127, 9);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(212, 30);
            this.dtpDeadline.TabIndex = 37;
            // 
            // txtOrder_Num
            // 
            this.txtOrder_Num.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOrder_Num.Location = new System.Drawing.Point(887, 9);
            this.txtOrder_Num.Name = "txtOrder_Num";
            this.txtOrder_Num.Size = new System.Drawing.Size(212, 30);
            this.txtOrder_Num.TabIndex = 45;
            // 
            // lblCompany
            // 
            this.lblCompany.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(411, 13);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(61, 23);
            this.lblCompany.TabIndex = 30;
            this.lblCompany.Text = "고객사";
            // 
            // lblOrder_Num
            // 
            this.lblOrder_Num.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrder_Num.AutoSize = true;
            this.lblOrder_Num.Location = new System.Drawing.Point(782, 13);
            this.lblOrder_Num.Name = "lblOrder_Num";
            this.lblOrder_Num.Size = new System.Drawing.Size(78, 23);
            this.lblOrder_Num.TabIndex = 33;
            this.lblOrder_Num.Text = "주문번호";
            // 
            // cboCompany
            // 
            this.cboCompany.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.Location = new System.Drawing.Point(507, 9);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(212, 31);
            this.cboCompany.TabIndex = 49;
            this.cboCompany.Enter += new System.EventHandler(this.cboCompany_Enter);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelect.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSelect.Location = new System.Drawing.Point(1275, 58);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(70, 30);
            this.btnSelect.TabIndex = 48;
            this.btnSelect.Text = "조회";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblSubject_Name
            // 
            this.lblSubject_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubject_Name.AutoSize = true;
            this.lblSubject_Name.Location = new System.Drawing.Point(28, 62);
            this.lblSubject_Name.Name = "lblSubject_Name";
            this.lblSubject_Name.Size = new System.Drawing.Size(67, 23);
            this.lblSubject_Name.TabIndex = 43;
            this.lblSubject_Name.Text = "품목 명";
            // 
            // txtSubject_Name
            // 
            this.txtSubject_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSubject_Name.Location = new System.Drawing.Point(127, 58);
            this.txtSubject_Name.Name = "txtSubject_Name";
            this.txtSubject_Name.Size = new System.Drawing.Size(212, 30);
            this.txtSubject_Name.TabIndex = 44;
            // 
            // lblUploadDate
            // 
            this.lblUploadDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUploadDate.AutoSize = true;
            this.lblUploadDate.Location = new System.Drawing.Point(411, 62);
            this.lblUploadDate.Name = "lblUploadDate";
            this.lblUploadDate.Size = new System.Drawing.Size(61, 23);
            this.lblUploadDate.TabIndex = 32;
            this.lblUploadDate.Text = "등록일";
            // 
            // dtpUploadDate
            // 
            this.dtpUploadDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpUploadDate.Location = new System.Drawing.Point(507, 58);
            this.dtpUploadDate.Name = "dtpUploadDate";
            this.dtpUploadDate.Size = new System.Drawing.Size(212, 30);
            this.dtpUploadDate.TabIndex = 42;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1143, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 60);
            this.button1.TabIndex = 36;
            this.button1.Text = "조회";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvSalesMaster
            // 
            this.dgvSalesMaster.AllowUserToAddRows = false;
            this.dgvSalesMaster.AllowUserToResizeRows = false;
            this.dgvSalesMaster.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvSalesMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalesMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalesMaster.Location = new System.Drawing.Point(0, 0);
            this.dgvSalesMaster.Name = "dgvSalesMaster";
            this.dgvSalesMaster.RowHeadersVisible = false;
            this.dgvSalesMaster.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvSalesMaster.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSalesMaster.RowTemplate.Height = 27;
            this.dgvSalesMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesMaster.Size = new System.Drawing.Size(1358, 660);
            this.dgvSalesMaster.TabIndex = 37;
            // 
            // frmSalesMaster
            // 
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Name = "frmSalesMaster";
            this.Text = "영업마스터";
            this.Load += new System.EventHandler(this.frmSalesMaster_Load);
            this.pnlDgv.ResumeLayout(false);
            this.pnlSelect.ResumeLayout(false);
            this.searchLocationControl1.ResumeLayout(false);
            this.searchLocationControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesMaster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.SearchLocationControl searchLocationControl1;
        private System.Windows.Forms.TextBox txtOrder_Num;
        private System.Windows.Forms.TextBox txtSubject_Name;
        private System.Windows.Forms.Label lblSubject_Name;
        private System.Windows.Forms.DateTimePicker dtpUploadDate;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblOrder_Num;
        private System.Windows.Forms.Label lblUploadDate;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblCustomerDeadline;
        private System.Windows.Forms.Button btnSelect;
        private DatagridviewControl dgvSalesMaster;
        private System.Windows.Forms.ComboBox cboCompany;
    }
}
