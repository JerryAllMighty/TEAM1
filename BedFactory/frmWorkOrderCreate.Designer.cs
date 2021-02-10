
namespace BedFactory
{
    partial class frmWorkOrderCreate
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
            this.dgvWOS = new BedFactory.DatagridviewControl();
            this.searchLocationControl1 = new BedFactory.Controls.SearchLocationControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pnlDgv.SuspendLayout();
            this.pnlSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWOS)).BeginInit();
            this.searchLocationControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(1234, 133);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(1163, 133);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(926, 133);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.Text = "작업지시생성";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(1305, 133);
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.dgvWOS);
            this.pnlDgv.Location = new System.Drawing.Point(12, 165);
            this.pnlDgv.Size = new System.Drawing.Size(1358, 676);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(1057, 133);
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.searchLocationControl1);
            this.pnlSelect.Size = new System.Drawing.Size(1358, 100);
            // 
            // dgvWOS
            // 
            this.dgvWOS.AllowUserToAddRows = false;
            this.dgvWOS.AllowUserToResizeRows = false;
            this.dgvWOS.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvWOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWOS.Location = new System.Drawing.Point(0, 0);
            this.dgvWOS.Name = "dgvWOS";
            this.dgvWOS.RowHeadersVisible = false;
            this.dgvWOS.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvWOS.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWOS.RowTemplate.Height = 27;
            this.dgvWOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWOS.Size = new System.Drawing.Size(1358, 676);
            this.dgvWOS.TabIndex = 0;
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
            this.searchLocationControl1.Controls.Add(this.btnSelect, 9, 1);
            this.searchLocationControl1.Controls.Add(this.label2, 0, 0);
            this.searchLocationControl1.Controls.Add(this.label6, 3, 0);
            this.searchLocationControl1.Controls.Add(this.comboBox2, 4, 0);
            this.searchLocationControl1.Controls.Add(this.label4, 6, 0);
            this.searchLocationControl1.Controls.Add(this.comboBox5, 7, 0);
            this.searchLocationControl1.Controls.Add(this.label8, 0, 1);
            this.searchLocationControl1.Controls.Add(this.comboBox1, 1, 1);
            this.searchLocationControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchLocationControl1.Location = new System.Drawing.Point(0, 0);
            this.searchLocationControl1.Name = "searchLocationControl1";
            this.searchLocationControl1.RowCount = 2;
            this.searchLocationControl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchLocationControl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchLocationControl1.Size = new System.Drawing.Size(1356, 98);
            this.searchLocationControl1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 43;
            this.label2.Text = "시작일자";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 23);
            this.label6.TabIndex = 44;
            this.label6.Text = "작업장";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(506, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(215, 31);
            this.comboBox2.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(799, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "자재";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(886, 3);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(215, 31);
            this.comboBox5.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 23);
            this.label8.TabIndex = 45;
            this.label8.Text = "상태";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 31);
            this.comboBox1.TabIndex = 47;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelect.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelect.Location = new System.Drawing.Point(1275, 58);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(70, 30);
            this.btnSelect.TabIndex = 17;
            this.btnSelect.Text = "조회";
            this.btnSelect.UseVisualStyleBackColor = false;
            // 
            // frmWorkOrderCreate
            // 
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Name = "frmWorkOrderCreate";
            this.Text = "작업지시생성";
            this.Load += new System.EventHandler(this.frmWorkOrderCreate_Load);
            this.pnlDgv.ResumeLayout(false);
            this.pnlSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWOS)).EndInit();
            this.searchLocationControl1.ResumeLayout(false);
            this.searchLocationControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatagridviewControl dgvWOS;
        private Controls.SearchLocationControl searchLocationControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnSelect;
    }
}
