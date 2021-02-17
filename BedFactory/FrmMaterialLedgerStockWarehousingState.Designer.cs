
namespace BedFactory
{
    partial class frmMaterialLedgerStockWarehousingState
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
            this.txtWearing = new System.Windows.Forms.TextBox();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.cboCom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSerch = new System.Windows.Forms.Button();
            this.searchLocationControl1 = new BedFactory.Controls.SearchLocationControl();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvState = new BedFactory.DatagridviewControl();
            this.pnlDgv.SuspendLayout();
            this.pnlSelect.SuspendLayout();
            this.searchLocationControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvState)).BeginInit();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn2.Location = new System.Drawing.Point(997, 134);
            // 
            // btn3
            // 
            this.btn3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn3.Location = new System.Drawing.Point(926, 134);
            // 
            // btn5
            // 
            this.btn5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn5.Location = new System.Drawing.Point(1139, 134);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 134);
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.Text = "자재입고현황";
            // 
            // btn1
            // 
            this.btn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1.Location = new System.Drawing.Point(1068, 134);
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.dgvState);
            this.pnlDgv.Location = new System.Drawing.Point(12, 165);
            this.pnlDgv.Size = new System.Drawing.Size(1358, 659);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(1270, 134);
            this.btn4.Text = "입고취소";
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.searchLocationControl1);
            this.pnlSelect.Size = new System.Drawing.Size(1358, 100);
            // 
            // txtWearing
            // 
            this.txtWearing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWearing.Location = new System.Drawing.Point(139, 61);
            this.txtWearing.Name = "txtWearing";
            this.txtWearing.Size = new System.Drawing.Size(235, 25);
            this.txtWearing.TabIndex = 74;
            // 
            // txtMaterial
            // 
            this.txtMaterial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaterial.Location = new System.Drawing.Point(977, 12);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(235, 25);
            this.txtMaterial.TabIndex = 73;
            // 
            // cboCom
            // 
            this.cboCom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCom.FormattingEnabled = true;
            this.cboCom.Location = new System.Drawing.Point(558, 14);
            this.cboCom.Name = "cboCom";
            this.cboCom.Size = new System.Drawing.Size(235, 25);
            this.cboCom.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 71;
            this.label2.Text = "거래처";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 67;
            this.label6.Text = "입고번호";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(882, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 65;
            this.label5.Text = "자재명";
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
            this.btnSerch.TabIndex = 62;
            this.btnSerch.Text = "조회";
            this.btnSerch.UseVisualStyleBackColor = false;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // searchLocationControl1
            // 
            this.searchLocationControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.searchLocationControl1.Controls.Add(this.label4, 0, 0);
            this.searchLocationControl1.Controls.Add(this.panel1, 1, 0);
            this.searchLocationControl1.Controls.Add(this.btnSerch, 9, 1);
            this.searchLocationControl1.Controls.Add(this.txtMaterial, 7, 0);
            this.searchLocationControl1.Controls.Add(this.txtWearing, 1, 1);
            this.searchLocationControl1.Controls.Add(this.label2, 3, 0);
            this.searchLocationControl1.Controls.Add(this.cboCom, 4, 0);
            this.searchLocationControl1.Controls.Add(this.label5, 6, 0);
            this.searchLocationControl1.Controls.Add(this.label6, 0, 1);
            this.searchLocationControl1.Location = new System.Drawing.Point(0, 0);
            this.searchLocationControl1.Name = "searchLocationControl1";
            this.searchLocationControl1.RowCount = 2;
            this.searchLocationControl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchLocationControl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchLocationControl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.searchLocationControl1.Size = new System.Drawing.Size(1356, 98);
            this.searchLocationControl1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 68;
            this.label4.Text = "입고일";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(139, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 26);
            this.panel1.TabIndex = 75;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "~";
            // 
            // dgvState
            // 
            this.dgvState.AllowUserToAddRows = false;
            this.dgvState.AllowUserToResizeRows = false;
            this.dgvState.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvState.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvState.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvState.Location = new System.Drawing.Point(0, 0);
            this.dgvState.Name = "dgvState";
            this.dgvState.RowHeadersVisible = false;
            this.dgvState.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvState.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvState.RowTemplate.Height = 23;
            this.dgvState.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvState.Size = new System.Drawing.Size(1358, 659);
            this.dgvState.TabIndex = 0;
            this.dgvState.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvState_CellContentClick);
            this.dgvState.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvState_CurrentCellDirtyStateChanged);
            this.dgvState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvState_KeyPress);
            // 
            // frmMaterialLedgerStockWarehousingState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMaterialLedgerStockWarehousingState";
            this.Text = "자재입고현황";
            this.Load += new System.EventHandler(this.frmMaterialLedgerStockWarehousingState_Load);
            this.pnlDgv.ResumeLayout(false);
            this.pnlSelect.ResumeLayout(false);
            this.searchLocationControl1.ResumeLayout(false);
            this.searchLocationControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvState)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.SearchLocationControl searchLocationControl1;
        protected System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.TextBox txtWearing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DatagridviewControl dgvState;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}