
namespace BedFactory
{
    partial class frmDemandPlan
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
            this.lblPlanID = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.cboCompany = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblSalesMaster_Num = new System.Windows.Forms.TextBox();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.dgvDemandPlan = new BedFactory.DatagridviewControl();
            this.pnlDgv.SuspendLayout();
            this.pnlSelect.SuspendLayout();
            this.searchLocationControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemandPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(1220, 156);
            this.btn2.Size = new System.Drawing.Size(150, 25);
            this.btn2.Text = "생산계획생성";
            this.btn2.Visible = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click_1);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(1078, 157);
            this.btn3.Visible = false;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(841, 156);
            this.btn5.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 156);
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.Text = "수요계획";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(1149, 156);
            this.btn1.Text = "엑셀";
            this.btn1.Visible = false;
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.dgvDemandPlan);
            this.pnlDgv.Location = new System.Drawing.Point(12, 192);
            this.pnlDgv.Size = new System.Drawing.Size(1358, 649);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(972, 156);
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
            this.searchLocationControl1.Controls.Add(this.lblPlanID, 0, 0);
            this.searchLocationControl1.Controls.Add(this.lblSubject, 0, 1);
            this.searchLocationControl1.Controls.Add(this.lblCompany, 3, 0);
            this.searchLocationControl1.Controls.Add(this.cboCompany, 4, 0);
            this.searchLocationControl1.Controls.Add(this.lblDate, 6, 0);
            this.searchLocationControl1.Controls.Add(this.dtpFrom, 7, 0);
            this.searchLocationControl1.Controls.Add(this.btnSelect, 9, 1);
            this.searchLocationControl1.Controls.Add(this.lblSalesMaster_Num, 1, 0);
            this.searchLocationControl1.Controls.Add(this.txtSubjectName, 1, 1);
            this.searchLocationControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchLocationControl1.Location = new System.Drawing.Point(0, 0);
            this.searchLocationControl1.Name = "searchLocationControl1";
            this.searchLocationControl1.RowCount = 2;
            this.searchLocationControl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchLocationControl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchLocationControl1.Size = new System.Drawing.Size(1356, 98);
            this.searchLocationControl1.TabIndex = 0;
            // 
            // lblPlanID
            // 
            this.lblPlanID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlanID.AutoSize = true;
            this.lblPlanID.Location = new System.Drawing.Point(5, 1);
            this.lblPlanID.Name = "lblPlanID";
            this.lblPlanID.Size = new System.Drawing.Size(113, 46);
            this.lblPlanID.TabIndex = 11;
            this.lblPlanID.Text = "영업마스터     번호";
            // 
            // lblSubject
            // 
            this.lblSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(31, 62);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(61, 23);
            this.lblSubject.TabIndex = 18;
            this.lblSubject.Text = "품목명";
            // 
            // lblCompany
            // 
            this.lblCompany.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(419, 13);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(44, 23);
            this.lblCompany.TabIndex = 12;
            this.lblCompany.Text = "업체";
            // 
            // cboCompany
            // 
            this.cboCompany.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.Location = new System.Drawing.Point(506, 13);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(215, 31);
            this.cboCompany.TabIndex = 13;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(791, 13);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(61, 23);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "등록일";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFrom.Location = new System.Drawing.Point(886, 9);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(215, 30);
            this.dtpFrom.TabIndex = 15;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelect.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSelect.Location = new System.Drawing.Point(1275, 58);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(70, 30);
            this.btnSelect.TabIndex = 16;
            this.btnSelect.Text = "조회";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblSalesMaster_Num
            // 
            this.lblSalesMaster_Num.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSalesMaster_Num.Location = new System.Drawing.Point(126, 9);
            this.lblSalesMaster_Num.Name = "lblSalesMaster_Num";
            this.lblSalesMaster_Num.Size = new System.Drawing.Size(215, 30);
            this.lblSalesMaster_Num.TabIndex = 20;
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSubjectName.Location = new System.Drawing.Point(126, 58);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(215, 30);
            this.txtSubjectName.TabIndex = 21;
            // 
            // dgvDemandPlan
            // 
            this.dgvDemandPlan.AllowUserToAddRows = false;
            this.dgvDemandPlan.AllowUserToResizeRows = false;
            this.dgvDemandPlan.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvDemandPlan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDemandPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDemandPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDemandPlan.Location = new System.Drawing.Point(0, 0);
            this.dgvDemandPlan.Name = "dgvDemandPlan";
            this.dgvDemandPlan.RowHeadersVisible = false;
            this.dgvDemandPlan.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvDemandPlan.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDemandPlan.RowTemplate.Height = 27;
            this.dgvDemandPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDemandPlan.Size = new System.Drawing.Size(1358, 649);
            this.dgvDemandPlan.TabIndex = 0;
            // 
            // frmDemandPlan
            // 
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Name = "frmDemandPlan";
            this.Text = "수요계획";
            this.Load += new System.EventHandler(this.frmDemandPlan_Load);
            this.pnlDgv.ResumeLayout(false);
            this.pnlSelect.ResumeLayout(false);
            this.searchLocationControl1.ResumeLayout(false);
            this.searchLocationControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemandPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.SearchLocationControl searchLocationControl1;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblPlanID;
        private System.Windows.Forms.ComboBox cboCompany;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button btnSelect;
        private DatagridviewControl dgvDemandPlan;
        private System.Windows.Forms.TextBox lblSalesMaster_Num;
        private System.Windows.Forms.TextBox txtSubjectName;
    }
}
