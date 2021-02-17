
namespace BedFactory
{
    partial class frmMaterialLedgerStockWarehousing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboCompany = new System.Windows.Forms.ComboBox();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.searchLocationControl1 = new BedFactory.Controls.SearchLocationControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvWearing = new BedFactory.DatagridviewControl();
            this.dgvWait = new BedFactory.DatagridviewControl();
            this.pnlDgv.SuspendLayout();
            this.pnlSelect.SuspendLayout();
            this.searchLocationControl1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWearing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWait)).BeginInit();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn2.Location = new System.Drawing.Point(1304, 501);
            this.btn2.Text = "취소";
            this.btn2.Click += new System.EventHandler(this.btn2_Click_1);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(1304, 99);
            this.btn3.Text = "선택";
            this.btn3.Click += new System.EventHandler(this.btn3_Click_1);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(1173, 99);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.Text = "입고대기리스트";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(1102, 99);
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.dgvWait);
            this.pnlDgv.Size = new System.Drawing.Size(1358, 349);
            // 
            // btn4
            // 
            this.btn4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn4.Location = new System.Drawing.Point(1198, 501);
            this.btn4.Text = "입고처리";
            this.btn4.Click += new System.EventHandler(this.btn4_Click_1);
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.searchLocationControl1);
            // 
            // cboCompany
            // 
            this.cboCompany.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.Location = new System.Drawing.Point(558, 18);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(235, 25);
            this.cboCompany.TabIndex = 57;
            // 
            // txtMaterial
            // 
            this.txtMaterial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaterial.Location = new System.Drawing.Point(977, 19);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(235, 25);
            this.txtMaterial.TabIndex = 62;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(888, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 17);
            this.label12.TabIndex = 58;
            this.label12.Text = "자재";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 56;
            this.label5.Text = "거래처";
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
            this.btnSelect.TabIndex = 54;
            this.btnSelect.Text = "조회";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(662, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "납기일자";
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
            this.searchLocationControl1.Controls.Add(this.panel2, 1, 0);
            this.searchLocationControl1.Controls.Add(this.cboCompany, 4, 0);
            this.searchLocationControl1.Controls.Add(this.txtMaterial, 7, 0);
            this.searchLocationControl1.Controls.Add(this.label5, 3, 0);
            this.searchLocationControl1.Controls.Add(this.label6, 0, 0);
            this.searchLocationControl1.Controls.Add(this.btnSelect, 9, 0);
            this.searchLocationControl1.Controls.Add(this.label12, 6, 0);
            this.searchLocationControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchLocationControl1.Location = new System.Drawing.Point(0, 0);
            this.searchLocationControl1.Name = "searchLocationControl1";
            this.searchLocationControl1.RowCount = 1;
            this.searchLocationControl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchLocationControl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchLocationControl1.Size = new System.Drawing.Size(1356, 63);
            this.searchLocationControl1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.dtpTo);
            this.panel2.Controls.Add(this.dtpFrom);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(139, 18);
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
            this.dtpTo.Size = new System.Drawing.Size(113, 25);
            this.dtpTo.TabIndex = 71;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(113, 25);
            this.dtpFrom.TabIndex = 70;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "~";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 59;
            this.label6.Text = "납기일자";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(13, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "자재입고";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dgvWearing);
            this.panel3.Location = new System.Drawing.Point(13, 532);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1356, 317);
            this.panel3.TabIndex = 67;
            // 
            // dgvWearing
            // 
            this.dgvWearing.AllowUserToAddRows = false;
            this.dgvWearing.AllowUserToResizeRows = false;
            this.dgvWearing.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvWearing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvWearing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWearing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWearing.Location = new System.Drawing.Point(0, 0);
            this.dgvWearing.Name = "dgvWearing";
            this.dgvWearing.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvWearing.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvWearing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWearing.Size = new System.Drawing.Size(1356, 317);
            this.dgvWearing.TabIndex = 0;
            this.dgvWearing.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWearing_CellContentClick);
            // 
            // dgvWait
            // 
            this.dgvWait.AllowUserToAddRows = false;
            this.dgvWait.AllowUserToResizeRows = false;
            this.dgvWait.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvWait.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWait.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWait.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWait.Location = new System.Drawing.Point(0, 0);
            this.dgvWait.Name = "dgvWait";
            this.dgvWait.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvWait.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWait.RowTemplate.Height = 23;
            this.dgvWait.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWait.Size = new System.Drawing.Size(1358, 349);
            this.dgvWait.TabIndex = 0;
            this.dgvWait.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWait_CellContentClick);
            // 
            // frmMaterialLedgerStockWarehousing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMaterialLedgerStockWarehousing";
            this.Text = "자재입고";
            this.Load += new System.EventHandler(this.frmMaterialLedgerStockWarehousing_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.pnlSelect, 0);
            this.Controls.SetChildIndex(this.btn4, 0);
            this.Controls.SetChildIndex(this.pnlDgv, 0);
            this.Controls.SetChildIndex(this.btn1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btn5, 0);
            this.Controls.SetChildIndex(this.btn3, 0);
            this.Controls.SetChildIndex(this.btn2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.pnlDgv.ResumeLayout(false);
            this.pnlSelect.ResumeLayout(false);
            this.searchLocationControl1.ResumeLayout(false);
            this.searchLocationControl1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWearing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCompany;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Button btnSelect;
        private Controls.SearchLocationControl searchLocationControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private DatagridviewControl dgvWait;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private DatagridviewControl dgvWearing;
    }
}