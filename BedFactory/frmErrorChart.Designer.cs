
namespace BedFactory
{
    partial class frmErrorChart
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
            this.dgvErrorList = new BedFactory.DatagridviewControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboKind = new System.Windows.Forms.ComboBox();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cboErrorKind = new System.Windows.Forms.ComboBox();
            this.pnlDgv.SuspendLayout();
            this.pnlSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorList)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(1284, 99);
            this.btn2.Visible = false;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(1284, 99);
            this.btn3.Visible = false;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(1245, 99);
            this.btn5.Text = "엑셀 내보내기";
            this.btn5.Visible = false;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.Text = "검사현황";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(1289, 99);
            this.btn1.Visible = false;
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.dgvErrorList);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(1270, 99);
            this.btn4.Visible = false;
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.tableLayoutPanel1);
            // 
            // dgvErrorList
            // 
            this.dgvErrorList.AllowUserToAddRows = false;
            this.dgvErrorList.AllowUserToResizeRows = false;
            this.dgvErrorList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvErrorList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvErrorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrorList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvErrorList.Location = new System.Drawing.Point(0, 0);
            this.dgvErrorList.Name = "dgvErrorList";
            this.dgvErrorList.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvErrorList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvErrorList.RowTemplate.Height = 23;
            this.dgvErrorList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvErrorList.Size = new System.Drawing.Size(1358, 711);
            this.dgvErrorList.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.63943F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.15097F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.54293F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.63943F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.15097F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.54293F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.63943F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.15097F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.54293F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboKind, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboName, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboErrorKind, 7, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1356, 63);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "* 자재명";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "* 자재구분";
            // 
            // cboKind
            // 
            this.cboKind.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKind.FormattingEnabled = true;
            this.cboKind.Location = new System.Drawing.Point(136, 21);
            this.cboKind.Name = "cboKind";
            this.cboKind.Size = new System.Drawing.Size(231, 25);
            this.cboKind.TabIndex = 1;
            this.cboKind.SelectedIndexChanged += new System.EventHandler(this.cbbKind_SelectedIndexChanged);
            // 
            // cboName
            // 
            this.cboName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboName.FormattingEnabled = true;
            this.cboName.Location = new System.Drawing.Point(553, 18);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(231, 25);
            this.cboName.TabIndex = 18;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(1268, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 26);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "조 회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(862, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "* 불량유형";
            // 
            // cboErrorKind
            // 
            this.cboErrorKind.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboErrorKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboErrorKind.FormattingEnabled = true;
            this.cboErrorKind.Location = new System.Drawing.Point(970, 21);
            this.cboErrorKind.Name = "cboErrorKind";
            this.cboErrorKind.Size = new System.Drawing.Size(231, 25);
            this.cboErrorKind.TabIndex = 23;
            // 
            // frmErrorChart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.Name = "frmErrorChart";
            this.Text = "frmErrorChart";
            this.Load += new System.EventHandler(this.frmErrorChart_Load);
            this.pnlDgv.ResumeLayout(false);
            this.pnlSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorList)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DatagridviewControl dgvErrorList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboKind;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboErrorKind;
    }
}