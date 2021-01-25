
namespace BedFactory.Pop_up
{
    partial class frmShift
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboShift = new System.Windows.Forms.ComboBox();
            this.lblShift = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtWp = new System.Windows.Forms.TextBox();
            this.txtMan = new System.Windows.Forms.TextBox();
            this.lblMan = new System.Windows.Forms.Label();
            this.cboIsUse = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEndTime = new BedFactory.Controls.OnlyNumberTextBox();
            this.txtStartTime = new BedFactory.Controls.OnlyNumberTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPeopleCnt = new BedFactory.Controls.OnlyNumberTextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(413, 274);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(266, 274);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtPeopleCnt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cboShift);
            this.panel2.Controls.Add(this.lblShift);
            this.panel2.Controls.Add(this.dtpDate);
            this.panel2.Controls.Add(this.dtpEndDate);
            this.panel2.Controls.Add(this.dtpStartDate);
            this.panel2.Controls.Add(this.txtWp);
            this.panel2.Controls.Add(this.txtMan);
            this.panel2.Controls.Add(this.txtEndTime);
            this.panel2.Controls.Add(this.txtStartTime);
            this.panel2.Controls.Add(this.lblMan);
            this.panel2.Controls.Add(this.cboIsUse);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(759, 256);
            this.panel2.TabIndex = 5;
            // 
            // cboShift
            // 
            this.cboShift.FormattingEnabled = true;
            this.cboShift.Items.AddRange(new object[] {
            "주간",
            "야산"});
            this.cboShift.Location = new System.Drawing.Point(178, 22);
            this.cboShift.Name = "cboShift";
            this.cboShift.Size = new System.Drawing.Size(176, 25);
            this.cboShift.TabIndex = 89;
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.ForeColor = System.Drawing.Color.Red;
            this.lblShift.Location = new System.Drawing.Point(52, 25);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(40, 17);
            this.lblShift.TabIndex = 88;
            this.lblShift.Text = "*Shift";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(526, 209);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(176, 25);
            this.dtpDate.TabIndex = 87;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(178, 161);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(176, 25);
            this.dtpEndDate.TabIndex = 86;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(526, 113);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(176, 25);
            this.dtpStartDate.TabIndex = 85;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // txtWp
            // 
            this.txtWp.Location = new System.Drawing.Point(178, 67);
            this.txtWp.Name = "txtWp";
            this.txtWp.Size = new System.Drawing.Size(176, 25);
            this.txtWp.TabIndex = 84;
            // 
            // txtMan
            // 
            this.txtMan.Location = new System.Drawing.Point(178, 209);
            this.txtMan.Name = "txtMan";
            this.txtMan.Size = new System.Drawing.Size(176, 25);
            this.txtMan.TabIndex = 83;
            // 
            // lblMan
            // 
            this.lblMan.AutoSize = true;
            this.lblMan.Location = new System.Drawing.Point(52, 212);
            this.lblMan.Name = "lblMan";
            this.lblMan.Size = new System.Drawing.Size(53, 17);
            this.lblMan.TabIndex = 79;
            this.lblMan.Text = "*수정자";
            // 
            // cboIsUse
            // 
            this.cboIsUse.FormattingEnabled = true;
            this.cboIsUse.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cboIsUse.Location = new System.Drawing.Point(526, 22);
            this.cboIsUse.Name = "cboIsUse";
            this.cboIsUse.Size = new System.Drawing.Size(176, 25);
            this.cboIsUse.TabIndex = 77;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(400, 212);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 17);
            this.lblDate.TabIndex = 76;
            this.lblDate.Text = "*수정일";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(400, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 17);
            this.label16.TabIndex = 75;
            this.label16.Text = "*사용유무";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(49, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 70;
            this.label11.Text = "*완료시간";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(49, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 17);
            this.label10.TabIndex = 69;
            this.label10.Text = "*적용완료일자";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(400, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 67;
            this.label3.Text = "*적용시작일자";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(400, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 66;
            this.label2.Text = "*시작시간";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(52, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 65;
            this.label1.Text = "*설비코드";
            // 
            // txtEndTime
            // 
            this.txtEndTime.Decimal = false;
            this.txtEndTime.Location = new System.Drawing.Point(178, 113);
            this.txtEndTime.MaxLength = 6;
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(176, 25);
            this.txtEndTime.TabIndex = 82;
            // 
            // txtStartTime
            // 
            this.txtStartTime.Decimal = false;
            this.txtStartTime.Location = new System.Drawing.Point(526, 67);
            this.txtStartTime.MaxLength = 6;
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(176, 25);
            this.txtStartTime.TabIndex = 81;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(400, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 90;
            this.label4.Text = "*투입인원";
            // 
            // txtPeopleCnt
            // 
            this.txtPeopleCnt.Decimal = false;
            this.txtPeopleCnt.Location = new System.Drawing.Point(526, 161);
            this.txtPeopleCnt.Name = "txtPeopleCnt";
            this.txtPeopleCnt.Size = new System.Drawing.Size(176, 25);
            this.txtPeopleCnt.TabIndex = 91;
            // 
            // frmShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(783, 326);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmShift";
            this.Text = "Shift";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private Controls.OnlyNumberTextBox txtEndTime;
        private Controls.OnlyNumberTextBox txtStartTime;
        private System.Windows.Forms.Label lblMan;
        private System.Windows.Forms.ComboBox cboIsUse;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMan;
        private System.Windows.Forms.TextBox txtWp;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.ComboBox cboShift;
        private Controls.OnlyNumberTextBox txtPeopleCnt;
        private System.Windows.Forms.Label label4;
    }
}