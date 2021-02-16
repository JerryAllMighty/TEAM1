namespace BedFactory.Pop_up
{
    partial class frmZipSearchPopup
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
            this.btnJibun = new System.Windows.Forms.Button();
            this.txtRoad = new System.Windows.Forms.TextBox();
            this.txtWoopyun = new System.Windows.Forms.TextBox();
            this.txtJibun = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblZibun = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblJibun = new System.Windows.Forms.Label();
            this.lblDoro = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMember = new BedFactory.DatagridviewControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJibun
            // 
            this.btnJibun.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnJibun.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnJibun.Location = new System.Drawing.Point(370, 404);
            this.btnJibun.Name = "btnJibun";
            this.btnJibun.Size = new System.Drawing.Size(127, 48);
            this.btnJibun.TabIndex = 23;
            this.btnJibun.Text = "주소  확인";
            this.btnJibun.UseVisualStyleBackColor = false;
            this.btnJibun.Click += new System.EventHandler(this.btnJibun_Click);
            // 
            // txtRoad
            // 
            this.txtRoad.Location = new System.Drawing.Point(126, 345);
            this.txtRoad.Name = "txtRoad";
            this.txtRoad.Size = new System.Drawing.Size(374, 21);
            this.txtRoad.TabIndex = 21;
            // 
            // txtWoopyun
            // 
            this.txtWoopyun.Location = new System.Drawing.Point(126, 322);
            this.txtWoopyun.Name = "txtWoopyun";
            this.txtWoopyun.Size = new System.Drawing.Size(90, 21);
            this.txtWoopyun.TabIndex = 20;
            // 
            // txtJibun
            // 
            this.txtJibun.Location = new System.Drawing.Point(126, 371);
            this.txtJibun.Name = "txtJibun";
            this.txtJibun.Size = new System.Drawing.Size(374, 21);
            this.txtJibun.TabIndex = 19;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(422, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(172, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(245, 21);
            this.txtSearch.TabIndex = 12;
            // 
            // lblZibun
            // 
            this.lblZibun.AutoSize = true;
            this.lblZibun.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblZibun.Location = new System.Drawing.Point(16, 14);
            this.lblZibun.Name = "lblZibun";
            this.lblZibun.Size = new System.Drawing.Size(127, 12);
            this.lblZibun.TabIndex = 13;
            this.lblZibun.Text = "도로번/지번 주소 검색";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(16, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "우편번호";
            // 
            // lblJibun
            // 
            this.lblJibun.AutoSize = true;
            this.lblJibun.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblJibun.Location = new System.Drawing.Point(16, 379);
            this.lblJibun.Name = "lblJibun";
            this.lblJibun.Size = new System.Drawing.Size(57, 12);
            this.lblJibun.TabIndex = 25;
            this.lblJibun.Text = "지번 주소";
            // 
            // lblDoro
            // 
            this.lblDoro.AutoSize = true;
            this.lblDoro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDoro.Location = new System.Drawing.Point(16, 353);
            this.lblDoro.Name = "lblDoro";
            this.lblDoro.Size = new System.Drawing.Size(69, 12);
            this.lblDoro.TabIndex = 26;
            this.lblDoro.Text = "도로번 주소";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvMember);
            this.panel1.Location = new System.Drawing.Point(18, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 278);
            this.panel1.TabIndex = 27;
            // 
            // dgvMember
            // 
            this.dgvMember.AllowUserToAddRows = false;
            this.dgvMember.AllowUserToResizeRows = false;
            this.dgvMember.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.dgvMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMember.Location = new System.Drawing.Point(0, 0);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvMember.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMember.RowTemplate.Height = 23;
            this.dgvMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMember.Size = new System.Drawing.Size(479, 278);
            this.dgvMember.TabIndex = 0;
            // 
            // frmZipSearchPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(510, 463);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDoro);
            this.Controls.Add(this.lblJibun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnJibun);
            this.Controls.Add(this.txtRoad);
            this.Controls.Add(this.txtWoopyun);
            this.Controls.Add(this.txtJibun);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblZibun);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "frmZipSearchPopup";
            this.Text = "주소 검색";
            this.Load += new System.EventHandler(this.frmZipSearchPopup_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJibun;
        private System.Windows.Forms.TextBox txtRoad;
        private System.Windows.Forms.TextBox txtWoopyun;
        private System.Windows.Forms.TextBox txtJibun;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblZibun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblJibun;
        private System.Windows.Forms.Label lblDoro;
        private System.Windows.Forms.Panel panel1;
        private DatagridviewControl dgvMember;
    }
}