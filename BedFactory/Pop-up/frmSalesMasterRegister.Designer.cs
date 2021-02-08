
namespace BedFactory.Pop_up
{
    partial class frmSalesMasterRegister
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpPlandate = new System.Windows.Forms.DateTimePicker();
            this.txtChosenFile = new System.Windows.Forms.TextBox();
            this.btnFileChoice = new System.Windows.Forms.Button();
            this.lblPlanDate = new System.Windows.Forms.Label();
            this.lblChosenFile = new System.Windows.Forms.Label();
            this.lblFileChoice = new System.Windows.Forms.Label();
            this.btnSalesMasterUpload = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpPlandate);
            this.panel1.Controls.Add(this.txtChosenFile);
            this.panel1.Controls.Add(this.btnFileChoice);
            this.panel1.Controls.Add(this.lblPlanDate);
            this.panel1.Controls.Add(this.lblChosenFile);
            this.panel1.Controls.Add(this.lblFileChoice);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 228);
            this.panel1.TabIndex = 0;
            // 
            // dtpPlandate
            // 
            this.dtpPlandate.Location = new System.Drawing.Point(148, 193);
            this.dtpPlandate.Name = "dtpPlandate";
            this.dtpPlandate.Size = new System.Drawing.Size(200, 25);
            this.dtpPlandate.TabIndex = 14;
            // 
            // txtChosenFile
            // 
            this.txtChosenFile.Location = new System.Drawing.Point(148, 123);
            this.txtChosenFile.Name = "txtChosenFile";
            this.txtChosenFile.Size = new System.Drawing.Size(200, 25);
            this.txtChosenFile.TabIndex = 13;
            // 
            // btnFileChoice
            // 
            this.btnFileChoice.Location = new System.Drawing.Point(148, 39);
            this.btnFileChoice.Name = "btnFileChoice";
            this.btnFileChoice.Size = new System.Drawing.Size(75, 23);
            this.btnFileChoice.TabIndex = 12;
            this.btnFileChoice.Text = "파일선택";
            this.btnFileChoice.UseVisualStyleBackColor = true;
            this.btnFileChoice.Click += new System.EventHandler(this.btnFileChoice_Click);
            // 
            // lblPlanDate
            // 
            this.lblPlanDate.AutoSize = true;
            this.lblPlanDate.Location = new System.Drawing.Point(20, 193);
            this.lblPlanDate.Name = "lblPlanDate";
            this.lblPlanDate.Size = new System.Drawing.Size(72, 15);
            this.lblPlanDate.TabIndex = 10;
            this.lblPlanDate.Text = "계획 일자";
            // 
            // lblChosenFile
            // 
            this.lblChosenFile.AutoSize = true;
            this.lblChosenFile.Location = new System.Drawing.Point(20, 123);
            this.lblChosenFile.Name = "lblChosenFile";
            this.lblChosenFile.Size = new System.Drawing.Size(107, 15);
            this.lblChosenFile.TabIndex = 9;
            this.lblChosenFile.Text = "선택 계획 파일";
            // 
            // lblFileChoice
            // 
            this.lblFileChoice.AutoSize = true;
            this.lblFileChoice.Location = new System.Drawing.Point(20, 39);
            this.lblFileChoice.Name = "lblFileChoice";
            this.lblFileChoice.Size = new System.Drawing.Size(72, 15);
            this.lblFileChoice.TabIndex = 8;
            this.lblFileChoice.Text = "파일 선택";
            // 
            // btnSalesMasterUpload
            // 
            this.btnSalesMasterUpload.Location = new System.Drawing.Point(121, 246);
            this.btnSalesMasterUpload.Name = "btnSalesMasterUpload";
            this.btnSalesMasterUpload.Size = new System.Drawing.Size(150, 44);
            this.btnSalesMasterUpload.TabIndex = 1;
            this.btnSalesMasterUpload.Text = "영업마스터 업로드";
            this.btnSalesMasterUpload.UseVisualStyleBackColor = true;
            this.btnSalesMasterUpload.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(277, 246);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "취소";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmSalesMasterRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(387, 299);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSalesMasterUpload);
            this.Controls.Add(this.panel1);
            this.Name = "frmSalesMasterRegister";
            this.Text = "영업 마스터 업로드";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpPlandate;
        private System.Windows.Forms.TextBox txtChosenFile;
        private System.Windows.Forms.Button btnFileChoice;
        private System.Windows.Forms.Label lblPlanDate;
        private System.Windows.Forms.Label lblChosenFile;
        private System.Windows.Forms.Label lblFileChoice;
        private System.Windows.Forms.Button btnSalesMasterUpload;
        private System.Windows.Forms.Button button3;
    }
}