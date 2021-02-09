
namespace BedFactory
{
    partial class frmBusinessCostManagement
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cboCompany = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.searchLocationControl1 = new BedFactory.Controls.SearchLocationControl();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvCost = new BedFactory.DatagridviewControl();
            this.button7 = new System.Windows.Forms.Button();
            this.pnlDgv.SuspendLayout();
            this.pnlSelect.SuspendLayout();
            this.searchLocationControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCost)).BeginInit();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(749, 96);
            this.btn2.Text = "등록";
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(962, 98);
            this.btn3.Text = "삭제";
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(1139, 99);
            this.btn5.Text = "양식 다운로드";
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.Text = "영업단가관리";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(891, 97);
            this.btn1.Text = "복사";
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.dgvCost);
            this.pnlDgv.Size = new System.Drawing.Size(1358, 719);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(1270, 99);
            this.btn4.Text = "가져오기";
            // 
            // pnlSelect
            // 
            this.pnlSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSelect.Controls.Add(this.searchLocationControl1);
            this.pnlSelect.Location = new System.Drawing.Point(16, 12);
            this.pnlSelect.Size = new System.Drawing.Size(1356, 65);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(833, 381);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 25);
            this.comboBox1.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(766, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "업체";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(495, 381);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 25);
            this.textBox1.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "품목";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(219, 378);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 25);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "기준일자";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(847, 459);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(48, 23);
            this.button6.TabIndex = 35;
            this.button6.Text = "등록";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(901, 459);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 23);
            this.button5.TabIndex = 34;
            this.button5.Text = "삭제";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(955, 459);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 23);
            this.button4.TabIndex = 33;
            this.button4.Text = "복사";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(1009, 459);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "엑셀";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(1063, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "양식다운로드";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(1173, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Excel등록";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cboCompany
            // 
            this.cboCompany.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.Location = new System.Drawing.Point(975, 21);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(235, 25);
            this.cboCompany.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(886, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "업체";
            // 
            // txtMaterial
            // 
            this.txtMaterial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaterial.Location = new System.Drawing.Point(557, 19);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(235, 25);
            this.txtMaterial.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "품목";
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(139, 19);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(235, 25);
            this.dtpDate.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "기준일자";
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Location = new System.Drawing.Point(1033, 99);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 25);
            this.button12.TabIndex = 30;
            this.button12.Text = "내보내기";
            this.button12.UseVisualStyleBackColor = false;
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
            this.searchLocationControl1.Controls.Add(this.cboCompany, 7, 0);
            this.searchLocationControl1.Controls.Add(this.btnSearch, 9, 0);
            this.searchLocationControl1.Controls.Add(this.label5, 6, 0);
            this.searchLocationControl1.Controls.Add(this.label7, 0, 0);
            this.searchLocationControl1.Controls.Add(this.txtMaterial, 4, 0);
            this.searchLocationControl1.Controls.Add(this.dtpDate, 1, 0);
            this.searchLocationControl1.Controls.Add(this.label6, 3, 0);
            this.searchLocationControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchLocationControl1.Location = new System.Drawing.Point(0, 0);
            this.searchLocationControl1.Name = "searchLocationControl1";
            this.searchLocationControl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.searchLocationControl1.Size = new System.Drawing.Size(1354, 63);
            this.searchLocationControl1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(1269, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 30);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvCost
            // 
            this.dgvCost.AllowUserToAddRows = false;
            this.dgvCost.AllowUserToResizeRows = false;
            this.dgvCost.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvCost.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCost.Location = new System.Drawing.Point(0, 0);
            this.dgvCost.Name = "dgvCost";
            this.dgvCost.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvCost.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCost.RowTemplate.Height = 23;
            this.dgvCost.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCost.Size = new System.Drawing.Size(1358, 719);
            this.dgvCost.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(820, 97);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(65, 25);
            this.button7.TabIndex = 31;
            this.button7.Text = "수정";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // frmBusinessCostManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "frmBusinessCostManagement";
            this.Text = "frmBusinessCostManagement";
            this.Load += new System.EventHandler(this.frmBusinessCostManagement_Load);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            this.Controls.SetChildIndex(this.button6, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.button12, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.pnlSelect, 0);
            this.Controls.SetChildIndex(this.btn4, 0);
            this.Controls.SetChildIndex(this.pnlDgv, 0);
            this.Controls.SetChildIndex(this.btn1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btn5, 0);
            this.Controls.SetChildIndex(this.btn3, 0);
            this.Controls.SetChildIndex(this.btn2, 0);
            this.Controls.SetChildIndex(this.button7, 0);
            this.pnlDgv.ResumeLayout(false);
            this.pnlSelect.ResumeLayout(false);
            this.searchLocationControl1.ResumeLayout(false);
            this.searchLocationControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCompany;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button12;
        private DatagridviewControl dgvCost;
        private Controls.SearchLocationControl searchLocationControl1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button7;
    }
}