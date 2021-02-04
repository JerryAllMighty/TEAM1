
namespace BedFactory
{
    partial class frmBOM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbKind = new System.Windows.Forms.ComboBox();
            this.cbbName = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlKindBtn = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvBOM = new BedFactory.DatagridviewControl();
            this.dgvList = new BedFactory.DatagridviewControl();
            this.pnlDgv.SuspendLayout();
            this.pnlSelect.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(1305, 99);
            this.btn2.Text = "변경";
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(1234, 99);
            this.btn3.Text = "프린트";
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(1103, 99);
            this.btn5.Text = "Excel내보내기";
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.Text = "BOM정보";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(1129, 99);
            this.btn1.Visible = false;
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.splitContainer1);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(1117, 99);
            this.btn4.Visible = false;
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.tableLayoutPanel1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbbKind, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbbName, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 9, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1356, 63);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "* 자재명";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "* 자재종류";
            // 
            // cbbKind
            // 
            this.cbbKind.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKind.FormattingEnabled = true;
            this.cbbKind.Location = new System.Drawing.Point(138, 21);
            this.cbbKind.Name = "cbbKind";
            this.cbbKind.Size = new System.Drawing.Size(231, 25);
            this.cbbKind.TabIndex = 1;
            // 
            // cbbName
            // 
            this.cbbName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbName.FormattingEnabled = true;
            this.cbbName.Location = new System.Drawing.Point(557, 18);
            this.cbbName.Name = "cbbName";
            this.cbbName.Size = new System.Drawing.Size(231, 25);
            this.cbbName.TabIndex = 18;
            this.cbbName.SelectedIndexChanged += new System.EventHandler(this.cbbName_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(1271, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 26);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "조 회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlKindBtn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(1358, 711);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 0;
            // 
            // pnlKindBtn
            // 
            this.pnlKindBtn.AutoScroll = true;
            this.pnlKindBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlKindBtn.Location = new System.Drawing.Point(0, 314);
            this.pnlKindBtn.Name = "pnlKindBtn";
            this.pnlKindBtn.Size = new System.Drawing.Size(230, 397);
            this.pnlKindBtn.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dgvBOM, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvList, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1124, 711);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dgvBOM
            // 
            this.dgvBOM.AllowUserToAddRows = false;
            this.dgvBOM.AllowUserToResizeRows = false;
            this.dgvBOM.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvBOM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBOM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBOM.Location = new System.Drawing.Point(3, 3);
            this.dgvBOM.Name = "dgvBOM";
            this.dgvBOM.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvBOM.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBOM.RowTemplate.Height = 23;
            this.dgvBOM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBOM.Size = new System.Drawing.Size(556, 705);
            this.dgvBOM.TabIndex = 0;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(565, 3);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(556, 705);
            this.dgvList.TabIndex = 1;
            // 
            // frmBOM
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmBOM";
            this.Text = "BOM설정";
            this.Load += new System.EventHandler(this.frmBOM_Load);
            this.pnlDgv.ResumeLayout(false);
            this.pnlSelect.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbKind;
        private System.Windows.Forms.ComboBox cbbName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DatagridviewControl dgvBOM;
        private DatagridviewControl dgvList;
        private System.Windows.Forms.Panel pnlKindBtn;
    }
}