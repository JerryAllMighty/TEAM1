
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSalesMasterUpload = new BedFactory.DatagridviewControl();
            this.btnSalesMasterUpload = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesMasterUpload)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "영업마스터 업로드";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSalesMasterUpload);
            this.panel1.Location = new System.Drawing.Point(12, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 363);
            this.panel1.TabIndex = 1;
            // 
            // dgvSalesMasterUpload
            // 
            this.dgvSalesMasterUpload.AllowUserToAddRows = false;
            this.dgvSalesMasterUpload.AllowUserToResizeRows = false;
            this.dgvSalesMasterUpload.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.dgvSalesMasterUpload.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSalesMasterUpload.ColumnHeadersHeight = 29;
            this.dgvSalesMasterUpload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalesMasterUpload.Location = new System.Drawing.Point(0, 0);
            this.dgvSalesMasterUpload.Name = "dgvSalesMasterUpload";
            this.dgvSalesMasterUpload.RowHeadersVisible = false;
            this.dgvSalesMasterUpload.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvSalesMasterUpload.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSalesMasterUpload.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesMasterUpload.Size = new System.Drawing.Size(1258, 363);
            this.dgvSalesMasterUpload.TabIndex = 0;
            this.dgvSalesMasterUpload.Text = "datagridviewControl1";
            // 
            // btnSalesMasterUpload
            // 
            this.btnSalesMasterUpload.Location = new System.Drawing.Point(989, 98);
            this.btnSalesMasterUpload.Name = "btnSalesMasterUpload";
            this.btnSalesMasterUpload.Size = new System.Drawing.Size(150, 25);
            this.btnSalesMasterUpload.TabIndex = 2;
            this.btnSalesMasterUpload.Text = "영업마스터 업로드";
            this.btnSalesMasterUpload.UseVisualStyleBackColor = true;
            this.btnSalesMasterUpload.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1145, 98);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 25);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "영업마스터 저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmSalesMasterUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSalesMasterUpload);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frmSalesMasterUpload";
            this.Text = "영업마스터 업로드";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSalesMasterUpload_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesMasterUpload)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalesMasterUpload;
        private System.Windows.Forms.Button btnSave;
        private DatagridviewControl dgvSalesMasterUpload;
    }
}