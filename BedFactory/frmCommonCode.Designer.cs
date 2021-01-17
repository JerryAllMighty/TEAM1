
namespace BedFactory
{
    partial class frmCommonCode
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
            this.dgvCommonCode = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommonCode)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCommonCode
            // 
            this.dgvCommonCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommonCode.Location = new System.Drawing.Point(13, 13);
            this.dgvCommonCode.Name = "dgvCommonCode";
            this.dgvCommonCode.RowHeadersWidth = 51;
            this.dgvCommonCode.RowTemplate.Height = 27;
            this.dgvCommonCode.Size = new System.Drawing.Size(775, 150);
            this.dgvCommonCode.TabIndex = 0;
            // 
            // frmCommonCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCommonCode);
            this.Name = "frmCommonCode";
            this.Text = "공통코드관리";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommonCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCommonCode;
    }
}