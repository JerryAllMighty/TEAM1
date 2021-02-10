
namespace BedFactory.Pop_up
{
    partial class frmStockBackgroundCheck
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvState = new BedFactory.DatagridviewControl();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvState)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(417, 525);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 50);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvState);
            this.panel2.Location = new System.Drawing.Point(12, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(947, 478);
            this.panel2.TabIndex = 5;
            // 
            // dgvState
            // 
            this.dgvState.AllowUserToAddRows = false;
            this.dgvState.AllowUserToResizeRows = false;
            this.dgvState.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvState.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvState.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvState.Location = new System.Drawing.Point(0, 0);
            this.dgvState.Name = "dgvState";
            this.dgvState.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvState.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvState.RowTemplate.Height = 23;
            this.dgvState.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvState.Size = new System.Drawing.Size(945, 476);
            this.dgvState.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(12, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "창고자재이력조회";
            // 
            // frmStockBackgroundCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(971, 587);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmStockBackgroundCheck";
            this.Text = "frmStockBackgroundCheck";
            this.Load += new System.EventHandler(this.frmStockBackgroundCheck_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvState)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private DatagridviewControl dgvState;
    }
}