
namespace BedFactory
{
    partial class frmSalesMasterUpload
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
            this.dgvSalesMasterUpload = new BedFactory.DatagridviewControl();
            this.pnlDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesMasterUpload)).BeginInit();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(1192, 12);
            this.btn2.Size = new System.Drawing.Size(170, 25);
            this.btn2.Text = "영업마스터 저장";
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(1016, 12);
            this.btn3.Size = new System.Drawing.Size(170, 25);
            this.btn3.Text = "영업마스터 업로드";
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(779, 12);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.Text = "영업 마스터 업로드";
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.dgvSalesMasterUpload);
            this.pnlDgv.Size = new System.Drawing.Size(1350, 798);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(910, 12);
            // 
            // dgvSalesMasterUpload
            // 
            this.dgvSalesMasterUpload.AllowUserToAddRows = false;
            this.dgvSalesMasterUpload.AllowUserToResizeRows = false;
            this.dgvSalesMasterUpload.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvSalesMasterUpload.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSalesMasterUpload.ColumnHeadersHeight = 29;
            this.dgvSalesMasterUpload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalesMasterUpload.Location = new System.Drawing.Point(0, 0);
            this.dgvSalesMasterUpload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSalesMasterUpload.Name = "dgvSalesMasterUpload";
            this.dgvSalesMasterUpload.RowHeadersVisible = false;
            this.dgvSalesMasterUpload.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvSalesMasterUpload.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSalesMasterUpload.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesMasterUpload.Size = new System.Drawing.Size(1350, 798);
            this.dgvSalesMasterUpload.TabIndex = 1;
            this.dgvSalesMasterUpload.Text = "datagridviewControl1";
            // 
            // frmSalesMasterUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "frmSalesMasterUpload";
            this.Text = "영업마스터 업로드";
            this.Load += new System.EventHandler(this.frmSalesMasterUpload_Load);
            this.pnlDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesMasterUpload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatagridviewControl dgvSalesMasterUpload;
    }
}