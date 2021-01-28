
namespace BedFactory
{
    partial class frmCompanyManagement
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
            this.lblPrcName = new System.Windows.Forms.Label();
            this.txtComName = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboComType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvComList = new BedFactory.DatagridviewControl();
            this.pnlDgv.SuspendLayout();
            this.pnlSelect.SuspendLayout();
            this.searchLocationControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.Text = "삭제";
            // 
            // btn3
            // 
            this.btn3.Text = "수정";
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(855, 100);
            this.btn5.Visible = false;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.Text = "업체목록";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(1305, 100);
            this.btn1.Text = "액셀";
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.dgvComList);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(986, 100);
            this.btn4.Visible = false;
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.searchLocationControl1);
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
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.searchLocationControl1.Controls.Add(this.lblPrcName, 0, 0);
            this.searchLocationControl1.Controls.Add(this.txtComName, 1, 0);
            this.searchLocationControl1.Controls.Add(this.btnSelect, 9, 0);
            this.searchLocationControl1.Controls.Add(this.label3, 3, 0);
            this.searchLocationControl1.Controls.Add(this.cboComType, 4, 0);
            this.searchLocationControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchLocationControl1.Location = new System.Drawing.Point(0, 0);
            this.searchLocationControl1.Name = "searchLocationControl1";
            this.searchLocationControl1.RowCount = 1;
            this.searchLocationControl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchLocationControl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchLocationControl1.Size = new System.Drawing.Size(1356, 63);
            this.searchLocationControl1.TabIndex = 0;
            // 
            // lblPrcName
            // 
            this.lblPrcName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrcName.AutoSize = true;
            this.lblPrcName.Location = new System.Drawing.Point(31, 20);
            this.lblPrcName.Name = "lblPrcName";
            this.lblPrcName.Size = new System.Drawing.Size(61, 23);
            this.lblPrcName.TabIndex = 14;
            this.lblPrcName.Text = "업체명";
            // 
            // txtComName
            // 
            this.txtComName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtComName.Location = new System.Drawing.Point(126, 16);
            this.txtComName.Name = "txtComName";
            this.txtComName.Size = new System.Drawing.Size(215, 30);
            this.txtComName.TabIndex = 16;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelect.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelect.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelect.Location = new System.Drawing.Point(1275, 16);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(10);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(70, 30);
            this.btnSelect.TabIndex = 22;
            this.btnSelect.Text = "조회";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "업체타입";
            // 
            // cboComType
            // 
            this.cboComType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboComType.FormattingEnabled = true;
            this.cboComType.Location = new System.Drawing.Point(506, 20);
            this.cboComType.Name = "cboComType";
            this.cboComType.Size = new System.Drawing.Size(215, 31);
            this.cboComType.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(1092, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 25);
            this.button1.TabIndex = 17;
            this.button1.Text = "등록";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dgvComList
            // 
            this.dgvComList.AllowUserToAddRows = false;
            this.dgvComList.AllowUserToResizeRows = false;
            this.dgvComList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvComList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComList.Location = new System.Drawing.Point(0, 0);
            this.dgvComList.Name = "dgvComList";
            this.dgvComList.RowHeadersVisible = false;
            this.dgvComList.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvComList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvComList.RowTemplate.Height = 27;
            this.dgvComList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComList.Size = new System.Drawing.Size(1358, 711);
            this.dgvComList.TabIndex = 0;
            // 
            // frmCompanyManagement
            // 
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Controls.Add(this.button1);
            this.Name = "frmCompanyManagement";
            this.Text = "업체관리";
            this.Load += new System.EventHandler(this.frmWorkspaceManagement_Load);
            this.Controls.SetChildIndex(this.button1, 0);
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
            this.searchLocationControl1.ResumeLayout(false);
            this.searchLocationControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.SearchLocationControl searchLocationControl1;
        private System.Windows.Forms.Label lblPrcName;
        private System.Windows.Forms.TextBox txtComName;
        protected System.Windows.Forms.Button btnSelect;
        protected System.Windows.Forms.Button button1;
        private DatagridviewControl dgvComList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboComType;
    }
}
