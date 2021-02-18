
namespace BedFactory.Pop_up
{
    partial class frmProcessReg
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
            this.label18 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCategory_Code = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoY = new System.Windows.Forms.RadioButton();
            this.rdoN = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 156);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 23);
            this.label18.TabIndex = 75;
            this.label18.Text = "*";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(15, 109);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(17, 23);
            this.label21.TabIndex = 72;
            this.label21.Text = "*";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(15, 65);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(17, 23);
            this.label22.TabIndex = 71;
            this.label22.Text = "*";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(265, 59);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(286, 31);
            this.txtName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 23);
            this.label7.TabIndex = 64;
            this.label7.Text = "공정조건";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(35, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 59;
            this.label4.Text = "사용유무";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(35, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 58;
            this.label2.Text = "상세공정명";
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point(14, 183);
            this.txtCondition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCondition.Multiline = true;
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(537, 180);
            this.txtCondition.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lavender;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(302, 373);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 50);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Lavender;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(430, 373);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 50);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 23);
            this.label1.TabIndex = 88;
            this.label1.Text = "*";
            // 
            // cboCategory_Code
            // 
            this.cboCategory_Code.FormattingEnabled = true;
            this.cboCategory_Code.Location = new System.Drawing.Point(265, 19);
            this.cboCategory_Code.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboCategory_Code.Name = "cboCategory_Code";
            this.cboCategory_Code.Size = new System.Drawing.Size(286, 31);
            this.cboCategory_Code.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(35, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 86;
            this.label3.Text = "공정분류";
            // 
            // rdoY
            // 
            this.rdoY.AutoSize = true;
            this.rdoY.Location = new System.Drawing.Point(351, 107);
            this.rdoY.Name = "rdoY";
            this.rdoY.Size = new System.Drawing.Size(99, 27);
            this.rdoY.TabIndex = 2;
            this.rdoY.TabStop = true;
            this.rdoY.Text = "사용안함";
            this.rdoY.UseVisualStyleBackColor = true;
            // 
            // rdoN
            // 
            this.rdoN.AutoSize = true;
            this.rdoN.Location = new System.Drawing.Point(265, 107);
            this.rdoN.Name = "rdoN";
            this.rdoN.Size = new System.Drawing.Size(65, 27);
            this.rdoN.TabIndex = 90;
            this.rdoN.TabStop = true;
            this.rdoN.Text = "사용";
            this.rdoN.UseVisualStyleBackColor = true;
            // 
            // frmProcessReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(563, 436);
            this.Controls.Add(this.rdoN);
            this.Controls.Add(this.rdoY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCategory_Code);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCondition);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProcessReg";
            this.Text = "공정등록수정";
            this.Load += new System.EventHandler(this.frmProcessReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCategory_Code;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdoY;
        private System.Windows.Forms.RadioButton rdoN;
    }
}