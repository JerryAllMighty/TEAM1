
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblCode_P_Code = new System.Windows.Forms.Label();
            this.lblCode_Category = new System.Windows.Forms.Label();
            this.lblCode_Name = new System.Windows.Forms.Label();
            this.lblCode_Num = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCommonCode = new BedFactory.DatagridviewControl();
            this.txtCode_Num = new System.Windows.Forms.TextBox();
            this.txtCode_Name = new System.Windows.Forms.TextBox();
            this.txtCode_Category = new System.Windows.Forms.TextBox();
            this.txtCode_P_Code = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommonCode)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCode_P_Code);
            this.panel1.Controls.Add(this.txtCode_Category);
            this.panel1.Controls.Add(this.txtCode_Name);
            this.panel1.Controls.Add(this.txtCode_Num);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.lblCode_P_Code);
            this.panel1.Controls.Add(this.lblCode_Category);
            this.panel1.Controls.Add(this.lblCode_Name);
            this.panel1.Controls.Add(this.lblCode_Num);
            this.panel1.Location = new System.Drawing.Point(13, 281);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 281);
            this.panel1.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(410, 159);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 25);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(410, 91);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 25);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(410, 27);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 25);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "등록";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblCode_P_Code
            // 
            this.lblCode_P_Code.AutoSize = true;
            this.lblCode_P_Code.Location = new System.Drawing.Point(22, 236);
            this.lblCode_P_Code.Name = "lblCode_P_Code";
            this.lblCode_P_Code.Size = new System.Drawing.Size(60, 15);
            this.lblCode_P_Code.TabIndex = 3;
            this.lblCode_P_Code.Text = "P_Code";
            // 
            // lblCode_Category
            // 
            this.lblCode_Category.AutoSize = true;
            this.lblCode_Category.ForeColor = System.Drawing.Color.Red;
            this.lblCode_Category.Location = new System.Drawing.Point(22, 159);
            this.lblCode_Category.Name = "lblCode_Category";
            this.lblCode_Category.Size = new System.Drawing.Size(73, 15);
            this.lblCode_Category.TabIndex = 2;
            this.lblCode_Category.Text = "*Category";
            // 
            // lblCode_Name
            // 
            this.lblCode_Name.AutoSize = true;
            this.lblCode_Name.ForeColor = System.Drawing.Color.Red;
            this.lblCode_Name.Location = new System.Drawing.Point(22, 91);
            this.lblCode_Name.Name = "lblCode_Name";
            this.lblCode_Name.Size = new System.Drawing.Size(93, 15);
            this.lblCode_Name.TabIndex = 1;
            this.lblCode_Name.Text = "*Code_Name";
            // 
            // lblCode_Num
            // 
            this.lblCode_Num.AutoSize = true;
            this.lblCode_Num.ForeColor = System.Drawing.Color.Red;
            this.lblCode_Num.Location = new System.Drawing.Point(22, 27);
            this.lblCode_Num.Name = "lblCode_Num";
            this.lblCode_Num.Size = new System.Drawing.Size(85, 15);
            this.lblCode_Num.TabIndex = 0;
            this.lblCode_Num.Text = "*Code_Num";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvCommonCode);
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(519, 250);
            this.panel2.TabIndex = 2;
            // 
            // dgvCommonCode
            // 
            this.dgvCommonCode.AllowUserToAddRows = false;
            this.dgvCommonCode.AllowUserToResizeRows = false;
            this.dgvCommonCode.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.dgvCommonCode.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCommonCode.ColumnHeadersHeight = 29;
            this.dgvCommonCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCommonCode.Location = new System.Drawing.Point(0, 0);
            this.dgvCommonCode.Name = "dgvCommonCode";
            this.dgvCommonCode.RowHeadersVisible = false;
            this.dgvCommonCode.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvCommonCode.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCommonCode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCommonCode.Size = new System.Drawing.Size(519, 250);
            this.dgvCommonCode.TabIndex = 0;
            this.dgvCommonCode.Text = "datagridviewControl1";
            this.dgvCommonCode.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCommonCode_CellDoubleClick);
            // 
            // txtCode_Num
            // 
            this.txtCode_Num.Location = new System.Drawing.Point(122, 27);
            this.txtCode_Num.Name = "txtCode_Num";
            this.txtCode_Num.Size = new System.Drawing.Size(235, 25);
            this.txtCode_Num.TabIndex = 11;
            // 
            // txtCode_Name
            // 
            this.txtCode_Name.Location = new System.Drawing.Point(122, 91);
            this.txtCode_Name.Name = "txtCode_Name";
            this.txtCode_Name.Size = new System.Drawing.Size(235, 25);
            this.txtCode_Name.TabIndex = 12;
            // 
            // txtCode_Category
            // 
            this.txtCode_Category.Location = new System.Drawing.Point(122, 159);
            this.txtCode_Category.Name = "txtCode_Category";
            this.txtCode_Category.Size = new System.Drawing.Size(235, 25);
            this.txtCode_Category.TabIndex = 13;
            // 
            // txtCode_P_Code
            // 
            this.txtCode_P_Code.Location = new System.Drawing.Point(122, 236);
            this.txtCode_P_Code.Name = "txtCode_P_Code";
            this.txtCode_P_Code.Size = new System.Drawing.Size(235, 25);
            this.txtCode_P_Code.TabIndex = 14;
            // 
            // frmCommonCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(545, 574);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmCommonCode";
            this.Text = "공통코드관리";
            this.Load += new System.EventHandler(this.frmCommonCode_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommonCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCode_P_Code;
        private System.Windows.Forms.Label lblCode_Category;
        private System.Windows.Forms.Label lblCode_Name;
        private System.Windows.Forms.Label lblCode_Num;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel2;
        private DatagridviewControl dgvCommonCode;
        private System.Windows.Forms.TextBox txtCode_P_Code;
        private System.Windows.Forms.TextBox txtCode_Category;
        private System.Windows.Forms.TextBox txtCode_Name;
        private System.Windows.Forms.TextBox txtCode_Num;
    }
}