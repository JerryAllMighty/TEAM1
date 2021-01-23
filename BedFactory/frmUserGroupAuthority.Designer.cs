
namespace BedFactory
{
    partial class frmUserGroupAuthority
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.asd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.datagridviewControl1 = new BedFactory.DatagridviewControl();
            this.datagridviewControl2 = new BedFactory.DatagridviewControl();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 100);
            this.panel1.TabIndex = 1;
            // 
            // asd
            // 
            this.asd.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.asd.Location = new System.Drawing.Point(12, 147);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(132, 23);
            this.asd.TabIndex = 8;
            this.asd.Text = "그룹 목록";
            this.asd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(661, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "허용된 권한";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.datagridviewControl1);
            this.panel2.Location = new System.Drawing.Point(17, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(611, 552);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.datagridviewControl2);
            this.panel3.Location = new System.Drawing.Point(634, 173);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(635, 552);
            this.panel3.TabIndex = 11;
            // 
            // datagridviewControl1
            // 
            this.datagridviewControl1.AllowUserToAddRows = false;
            this.datagridviewControl1.AllowUserToResizeRows = false;
            this.datagridviewControl1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
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
            this.datagridviewControl1.Size = new System.Drawing.Size(611, 552);
            this.datagridviewControl1.TabIndex = 0;
            // 
            // datagridviewControl2
            // 
            this.datagridviewControl2.AllowUserToAddRows = false;
            this.datagridviewControl2.AllowUserToResizeRows = false;
            this.datagridviewControl2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
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
            this.datagridviewControl2.Size = new System.Drawing.Size(635, 552);
            this.datagridviewControl2.TabIndex = 0;
            // 
            // frmUserGroupAuthority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.asd);
            this.Controls.Add(this.panel1);
            this.Name = "frmUserGroupAuthority";
            this.Text = "사용자 그룹별 권한 관리";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label asd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DatagridviewControl datagridviewControl1;
        private DatagridviewControl datagridviewControl2;
    }
}