
namespace BedFactory
{
    partial class frmUserGroupAuthority
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datagridviewControl2 = new BedFactory.DatagridviewControl();
            this.datagridviewControl1 = new BedFactory.DatagridviewControl();
            this.searchLocationControl1 = new BedFactory.Controls.SearchLocationControl();
            this.searchLocationControl2 = new BedFactory.Controls.SearchLocationControl();
            this.button1 = new System.Windows.Forms.Button();
            this.lblGroupCode = new System.Windows.Forms.Label();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.cboGroupCode = new System.Windows.Forms.ComboBox();
            this.cboGroupName = new System.Windows.Forms.ComboBox();
            this.pnlDgv.SuspendLayout();
            this.pnlSelect.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewControl1)).BeginInit();
            this.searchLocationControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(1233, 161);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(1162, 161);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(925, 161);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 161);
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.Text = "그룹 목록";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(1304, 161);
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.datagridviewControl1);
            this.pnlDgv.Location = new System.Drawing.Point(12, 200);
            this.pnlDgv.Size = new System.Drawing.Size(615, 711);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(1056, 161);
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.searchLocationControl2);
            this.pnlSelect.Controls.Add(this.searchLocationControl1);
            this.pnlSelect.Size = new System.Drawing.Size(1358, 67);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(629, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "허용된 권한";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datagridviewControl2);
            this.panel1.Location = new System.Drawing.Point(634, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 641);
            this.panel1.TabIndex = 12;
            // 
            // datagridviewControl2
            // 
            this.datagridviewControl2.AllowUserToAddRows = false;
            this.datagridviewControl2.AllowUserToResizeRows = false;
            this.datagridviewControl2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.datagridviewControl2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagridviewControl2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridviewControl2.Location = new System.Drawing.Point(0, 0);
            this.datagridviewControl2.Name = "datagridviewControl2";
            this.datagridviewControl2.RowHeadersVisible = false;
            this.datagridviewControl2.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.datagridviewControl2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridviewControl2.RowTemplate.Height = 27;
            this.datagridviewControl2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewControl2.Size = new System.Drawing.Size(736, 641);
            this.datagridviewControl2.TabIndex = 0;
            // 
            // datagridviewControl1
            // 
            this.datagridviewControl1.AllowUserToAddRows = false;
            this.datagridviewControl1.AllowUserToResizeRows = false;
            this.datagridviewControl1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.datagridviewControl1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridviewControl1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridviewControl1.Location = new System.Drawing.Point(0, 0);
            this.datagridviewControl1.Name = "datagridviewControl1";
            this.datagridviewControl1.RowHeadersVisible = false;
            this.datagridviewControl1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.datagridviewControl1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridviewControl1.RowTemplate.Height = 27;
            this.datagridviewControl1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewControl1.Size = new System.Drawing.Size(615, 711);
            this.datagridviewControl1.TabIndex = 0;
            // 
            // searchLocationControl1
            // 
            this.searchLocationControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLocationControl1.ColumnCount = 2;
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.searchLocationControl1.Location = new System.Drawing.Point(-41, -70);
            this.searchLocationControl1.Name = "searchLocationControl1";
            this.searchLocationControl1.RowCount = 2;
            this.searchLocationControl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchLocationControl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchLocationControl1.Size = new System.Drawing.Size(1400, 0);
            this.searchLocationControl1.TabIndex = 0;
            // 
            // searchLocationControl2
            // 
            this.searchLocationControl2.ColumnCount = 10;
            this.searchLocationControl2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.searchLocationControl2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.searchLocationControl2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.searchLocationControl2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.searchLocationControl2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.searchLocationControl2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.searchLocationControl2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.searchLocationControl2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.searchLocationControl2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.searchLocationControl2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.searchLocationControl2.Controls.Add(this.button1, 9, 0);
            this.searchLocationControl2.Controls.Add(this.lblGroupCode, 0, 0);
            this.searchLocationControl2.Controls.Add(this.lblGroupName, 3, 0);
            this.searchLocationControl2.Controls.Add(this.cboGroupCode, 1, 0);
            this.searchLocationControl2.Controls.Add(this.cboGroupName, 4, 0);
            this.searchLocationControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchLocationControl2.Location = new System.Drawing.Point(0, 0);
            this.searchLocationControl2.Name = "searchLocationControl2";
            this.searchLocationControl2.RowCount = 1;
            this.searchLocationControl2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchLocationControl2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchLocationControl2.Size = new System.Drawing.Size(1356, 65);
            this.searchLocationControl2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Location = new System.Drawing.Point(1275, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "조회";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblGroupCode
            // 
            this.lblGroupCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGroupCode.AutoSize = true;
            this.lblGroupCode.Location = new System.Drawing.Point(22, 21);
            this.lblGroupCode.Name = "lblGroupCode";
            this.lblGroupCode.Size = new System.Drawing.Size(78, 23);
            this.lblGroupCode.TabIndex = 17;
            this.lblGroupCode.Text = "그룹코드";
            // 
            // lblGroupName
            // 
            this.lblGroupName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Location = new System.Drawing.Point(411, 21);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(61, 23);
            this.lblGroupName.TabIndex = 18;
            this.lblGroupName.Text = "그룹명";
            // 
            // cboGroupCode
            // 
            this.cboGroupCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboGroupCode.FormattingEnabled = true;
            this.cboGroupCode.Location = new System.Drawing.Point(126, 20);
            this.cboGroupCode.Name = "cboGroupCode";
            this.cboGroupCode.Size = new System.Drawing.Size(215, 31);
            this.cboGroupCode.TabIndex = 19;
            // 
            // cboGroupName
            // 
            this.cboGroupName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboGroupName.FormattingEnabled = true;
            this.cboGroupName.Location = new System.Drawing.Point(506, 20);
            this.cboGroupName.Name = "cboGroupName";
            this.cboGroupName.Size = new System.Drawing.Size(215, 31);
            this.cboGroupName.TabIndex = 20;
            // 
            // frmUserGroupAuthority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "frmUserGroupAuthority";
            this.Text = "사용자 그룹별 권한 관리";
            this.Load += new System.EventHandler(this.frmUserGroupAuthority_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
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
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewControl1)).EndInit();
            this.searchLocationControl2.ResumeLayout(false);
            this.searchLocationControl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private DatagridviewControl datagridviewControl1;
        private DatagridviewControl datagridviewControl2;
        private Controls.SearchLocationControl searchLocationControl1;
        private Controls.SearchLocationControl searchLocationControl2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblGroupCode;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.ComboBox cboGroupCode;
        private System.Windows.Forms.ComboBox cboGroupName;
    }
}
