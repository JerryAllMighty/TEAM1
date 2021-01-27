
namespace BedFactory
{
    partial class frmWorkplaceManagement
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboProcessName = new System.Windows.Forms.ComboBox();
            this.txtPlaceName = new System.Windows.Forms.TextBox();
            this.dgvWorkplace = new BedFactory.DatagridviewControl();
            this.pnlDgv.SuspendLayout();
            this.pnlSelect.SuspendLayout();
            this.searchLocationControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkplace)).BeginInit();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.Text = "삭제";
            // 
            // btn3
            // 
            this.btn3.Text = "수정";
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(961, 100);
            this.btn5.Visible = false;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.Text = "작업장정보";
            // 
            // btn1
            // 
            this.btn1.Text = "액셀";
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.dgvWorkplace);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(1092, 99);
            this.btn4.Size = new System.Drawing.Size(65, 25);
            this.btn4.Text = "등록";
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
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
            this.searchLocationControl1.Controls.Add(this.label2, 0, 0);
            this.searchLocationControl1.Controls.Add(this.btnSelect, 9, 0);
            this.searchLocationControl1.Controls.Add(this.label3, 3, 0);
            this.searchLocationControl1.Controls.Add(this.cboProcessName, 1, 0);
            this.searchLocationControl1.Controls.Add(this.txtPlaceName, 4, 0);
            this.searchLocationControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchLocationControl1.Location = new System.Drawing.Point(0, 0);
            this.searchLocationControl1.Name = "searchLocationControl1";
            this.searchLocationControl1.RowCount = 1;
            this.searchLocationControl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchLocationControl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchLocationControl1.Size = new System.Drawing.Size(1356, 63);
            this.searchLocationControl1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "공정명";
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelect.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelect.Location = new System.Drawing.Point(1275, 16);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(70, 30);
            this.btnSelect.TabIndex = 20;
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
            this.label3.TabIndex = 22;
            this.label3.Text = "작업장명";
            // 
            // cboProcessName
            // 
            this.cboProcessName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboProcessName.FormattingEnabled = true;
            this.cboProcessName.Location = new System.Drawing.Point(126, 16);
            this.cboProcessName.Name = "cboProcessName";
            this.cboProcessName.Size = new System.Drawing.Size(215, 31);
            this.cboProcessName.TabIndex = 23;
            // 
            // txtPlaceName
            // 
            this.txtPlaceName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPlaceName.Location = new System.Drawing.Point(506, 16);
            this.txtPlaceName.Name = "txtPlaceName";
            this.txtPlaceName.Size = new System.Drawing.Size(215, 30);
            this.txtPlaceName.TabIndex = 24;
            // 
            // dgvWorkplace
            // 
            this.dgvWorkplace.AllowUserToAddRows = false;
            this.dgvWorkplace.AllowUserToResizeRows = false;
            this.dgvWorkplace.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvWorkplace.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWorkplace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkplace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorkplace.Location = new System.Drawing.Point(0, 0);
            this.dgvWorkplace.Name = "dgvWorkplace";
            this.dgvWorkplace.RowHeadersVisible = false;
            this.dgvWorkplace.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvWorkplace.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWorkplace.RowTemplate.Height = 27;
            this.dgvWorkplace.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorkplace.Size = new System.Drawing.Size(1358, 711);
            this.dgvWorkplace.TabIndex = 0;
            // 
            // frmWorkplaceManagement
            // 
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Name = "frmWorkplaceManagement";
            this.Text = "작업장관리";
            this.Load += new System.EventHandler(this.frmWorkplaceManagement_Load);
            this.pnlDgv.ResumeLayout(false);
            this.pnlSelect.ResumeLayout(false);
            this.searchLocationControl1.ResumeLayout(false);
            this.searchLocationControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkplace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.SearchLocationControl searchLocationControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboProcessName;
        private System.Windows.Forms.TextBox txtPlaceName;
        private DatagridviewControl dgvWorkplace;
    }
}
