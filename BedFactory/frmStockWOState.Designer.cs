
namespace BedFactory
{
    partial class frmStockWOState
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboWOcategory = new System.Windows.Forms.ComboBox();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.cboStorage = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSerch = new System.Windows.Forms.Button();
            this.searchLocationControl1 = new BedFactory.Controls.SearchLocationControl();
            this.cboMcategory = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.dgvWO = new BedFactory.DatagridviewControl();
            this.pnlDgv.SuspendLayout();
            this.pnlSelect.SuspendLayout();
            this.searchLocationControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWO)).BeginInit();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(1235, 133);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(1164, 133);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(927, 133);
            this.btn5.Text = "엑셀 내보내기";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 133);
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.Text = "입출고입력";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(1306, 133);
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.dgvWO);
            this.pnlDgv.Location = new System.Drawing.Point(13, 164);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(1058, 133);
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.searchLocationControl1);
            this.pnlSelect.Size = new System.Drawing.Size(1358, 100);
            // 
            // cboWOcategory
            // 
            this.cboWOcategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboWOcategory.FormattingEnabled = true;
            this.cboWOcategory.Location = new System.Drawing.Point(139, 63);
            this.cboWOcategory.Name = "cboWOcategory";
            this.cboWOcategory.Size = new System.Drawing.Size(235, 25);
            this.cboWOcategory.TabIndex = 76;
            // 
            // txtMaterial
            // 
            this.txtMaterial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaterial.Location = new System.Drawing.Point(977, 12);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(235, 25);
            this.txtMaterial.TabIndex = 75;
            // 
            // cboStorage
            // 
            this.cboStorage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboStorage.FormattingEnabled = true;
            this.cboStorage.Location = new System.Drawing.Point(558, 14);
            this.cboStorage.Name = "cboStorage";
            this.cboStorage.Size = new System.Drawing.Size(235, 25);
            this.cboStorage.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 72;
            this.label2.Text = "창고";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(888, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 17);
            this.label12.TabIndex = 69;
            this.label12.Text = "자재";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 66;
            this.label5.Text = "입출고유형";
            // 
            // btnSerch
            // 
            this.btnSerch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSerch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSerch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSerch.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSerch.Location = new System.Drawing.Point(1271, 58);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(70, 30);
            this.btnSerch.TabIndex = 65;
            this.btnSerch.Text = "조회";
            this.btnSerch.UseVisualStyleBackColor = false;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
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
            this.searchLocationControl1.Controls.Add(this.btnSerch, 9, 1);
            this.searchLocationControl1.Controls.Add(this.cboMcategory, 7, 1);
            this.searchLocationControl1.Controls.Add(this.cboWOcategory, 1, 1);
            this.searchLocationControl1.Controls.Add(this.panel1, 1, 0);
            this.searchLocationControl1.Controls.Add(this.txtMaterial, 7, 0);
            this.searchLocationControl1.Controls.Add(this.label3, 0, 0);
            this.searchLocationControl1.Controls.Add(this.cboStorage, 4, 0);
            this.searchLocationControl1.Controls.Add(this.label5, 0, 1);
            this.searchLocationControl1.Controls.Add(this.label12, 6, 0);
            this.searchLocationControl1.Controls.Add(this.label2, 3, 0);
            this.searchLocationControl1.Controls.Add(this.label7, 3, 1);
            this.searchLocationControl1.Controls.Add(this.label8, 6, 1);
            this.searchLocationControl1.Controls.Add(this.cboCategory, 4, 1);
            this.searchLocationControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchLocationControl1.Location = new System.Drawing.Point(0, 0);
            this.searchLocationControl1.Name = "searchLocationControl1";
            this.searchLocationControl1.RowCount = 2;
            this.searchLocationControl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchLocationControl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchLocationControl1.Size = new System.Drawing.Size(1356, 98);
            this.searchLocationControl1.TabIndex = 0;
            // 
            // cboMcategory
            // 
            this.cboMcategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboMcategory.FormattingEnabled = true;
            this.cboMcategory.Location = new System.Drawing.Point(977, 63);
            this.cboMcategory.Name = "cboMcategory";
            this.cboMcategory.Size = new System.Drawing.Size(235, 25);
            this.cboMcategory.TabIndex = 81;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(139, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 26);
            this.panel1.TabIndex = 77;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "~";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 74;
            this.label3.Text = "입출고일";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 78;
            this.label7.Text = "카테고리";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(875, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 79;
            this.label8.Text = "자재유형";
            // 
            // cboCategory
            // 
            this.cboCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(558, 63);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(235, 25);
            this.cboCategory.TabIndex = 80;
            // 
            // dgvWO
            // 
            this.dgvWO.AllowUserToAddRows = false;
            this.dgvWO.AllowUserToResizeRows = false;
            this.dgvWO.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvWO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWO.Location = new System.Drawing.Point(0, 0);
            this.dgvWO.Name = "dgvWO";
            this.dgvWO.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvWO.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWO.RowTemplate.Height = 23;
            this.dgvWO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWO.Size = new System.Drawing.Size(1358, 711);
            this.dgvWO.TabIndex = 0;
            // 
            // frmStockWOState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmStockWOState";
            this.Text = "frmStockWOState";
            this.Load += new System.EventHandler(this.frmStockWOState_Load);
            this.pnlDgv.ResumeLayout(false);
            this.pnlSelect.ResumeLayout(false);
            this.searchLocationControl1.ResumeLayout(false);
            this.searchLocationControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboWOcategory;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.ComboBox cboStorage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        protected System.Windows.Forms.Button btnSerch;
        private Controls.SearchLocationControl searchLocationControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private DatagridviewControl dgvWO;
        private System.Windows.Forms.ComboBox cboMcategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboCategory;
    }
}