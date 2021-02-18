
namespace BedFactory.Pop_up
{
    partial class frmWorkOrdersCreatePOPUP
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
            this.txtOrderCnt = new System.Windows.Forms.TextBox();
            this.txtPlanCnt = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.rdoN = new System.Windows.Forms.RadioButton();
            this.rdoY = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.txtEmp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboWOS = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMatName = new System.Windows.Forms.ComboBox();
            this.lblWPNum = new System.Windows.Forms.Label();
            this.cboWpName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPrcName = new System.Windows.Forms.ComboBox();
            this.txtWpName = new System.Windows.Forms.TextBox();
            this.txtMatName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtOrderCnt
            // 
            this.txtOrderCnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOrderCnt.Location = new System.Drawing.Point(534, 8);
            this.txtOrderCnt.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.txtOrderCnt.Name = "txtOrderCnt";
            this.txtOrderCnt.Size = new System.Drawing.Size(261, 30);
            this.txtOrderCnt.TabIndex = 207;
            // 
            // txtPlanCnt
            // 
            this.txtPlanCnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPlanCnt.Location = new System.Drawing.Point(128, 98);
            this.txtPlanCnt.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.txtPlanCnt.Name = "txtPlanCnt";
            this.txtPlanCnt.Size = new System.Drawing.Size(261, 30);
            this.txtPlanCnt.TabIndex = 206;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.Lavender;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Location = new System.Drawing.Point(420, 291);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(166, 42);
            this.btnCancel.TabIndex = 205;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.Lavender;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(215, 291);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(166, 42);
            this.btnSave.TabIndex = 204;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rdoN
            // 
            this.rdoN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoN.AutoSize = true;
            this.rdoN.Location = new System.Drawing.Point(751, 220);
            this.rdoN.Name = "rdoN";
            this.rdoN.Size = new System.Drawing.Size(44, 27);
            this.rdoN.TabIndex = 203;
            this.rdoN.TabStop = true;
            this.rdoN.Text = "N";
            this.rdoN.UseVisualStyleBackColor = true;
            this.rdoN.Visible = false;
            // 
            // rdoY
            // 
            this.rdoY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoY.AutoSize = true;
            this.rdoY.Location = new System.Drawing.Point(638, 220);
            this.rdoY.Name = "rdoY";
            this.rdoY.Size = new System.Drawing.Size(41, 27);
            this.rdoY.TabIndex = 202;
            this.rdoY.TabStop = true;
            this.rdoY.Text = "Y";
            this.rdoY.UseVisualStyleBackColor = true;
            this.rdoY.Visible = false;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 23);
            this.label13.TabIndex = 201;
            this.label13.Text = "생산시작";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(128, 54);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(262, 30);
            this.dtpFrom.TabIndex = 199;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(416, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 23);
            this.label11.TabIndex = 197;
            this.label11.Text = "작업내용";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(416, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 23);
            this.label10.TabIndex = 196;
            this.label10.Text = "작업담당자";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(416, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 23);
            this.label8.TabIndex = 194;
            this.label8.Text = "출고여부";
            this.label8.Visible = false;
            // 
            // txtDetail
            // 
            this.txtDetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDetail.Location = new System.Drawing.Point(534, 126);
            this.txtDetail.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(261, 72);
            this.txtDetail.TabIndex = 192;
            // 
            // txtEmp
            // 
            this.txtEmp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmp.Location = new System.Drawing.Point(534, 88);
            this.txtEmp.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.txtEmp.Name = "txtEmp";
            this.txtEmp.Size = new System.Drawing.Size(261, 30);
            this.txtEmp.TabIndex = 191;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(416, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 23);
            this.label7.TabIndex = 190;
            this.label7.Text = "지시수량";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 23);
            this.label6.TabIndex = 189;
            this.label6.Text = "작업지시상태";
            // 
            // cboWOS
            // 
            this.cboWOS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboWOS.FormattingEnabled = true;
            this.cboWOS.Location = new System.Drawing.Point(534, 53);
            this.cboWOS.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.cboWOS.Name = "cboWOS";
            this.cboWOS.Size = new System.Drawing.Size(261, 31);
            this.cboWOS.TabIndex = 188;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 187;
            this.label5.Text = "계획수량";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 186;
            this.label4.Text = "자재명";
            // 
            // cboMatName
            // 
            this.cboMatName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboMatName.FormattingEnabled = true;
            this.cboMatName.Location = new System.Drawing.Point(129, 256);
            this.cboMatName.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.cboMatName.Name = "cboMatName";
            this.cboMatName.Size = new System.Drawing.Size(261, 31);
            this.cboMatName.TabIndex = 185;
            this.cboMatName.Visible = false;
            // 
            // lblWPNum
            // 
            this.lblWPNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWPNum.AutoSize = true;
            this.lblWPNum.Location = new System.Drawing.Point(8, 15);
            this.lblWPNum.Name = "lblWPNum";
            this.lblWPNum.Size = new System.Drawing.Size(95, 23);
            this.lblWPNum.TabIndex = 184;
            this.lblWPNum.Text = "작업장이름";
            // 
            // cboWpName
            // 
            this.cboWpName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboWpName.FormattingEnabled = true;
            this.cboWpName.Location = new System.Drawing.Point(128, 221);
            this.cboWpName.Name = "cboWpName";
            this.cboWpName.Size = new System.Drawing.Size(261, 31);
            this.cboWpName.TabIndex = 183;
            this.cboWpName.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 182;
            this.label2.Text = "상세공정명";
            this.label2.Visible = false;
            // 
            // cboPrcName
            // 
            this.cboPrcName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboPrcName.FormattingEnabled = true;
            this.cboPrcName.Location = new System.Drawing.Point(128, 180);
            this.cboPrcName.Name = "cboPrcName";
            this.cboPrcName.Size = new System.Drawing.Size(261, 31);
            this.cboPrcName.TabIndex = 181;
            this.cboPrcName.Visible = false;
            // 
            // txtWpName
            // 
            this.txtWpName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWpName.Location = new System.Drawing.Point(129, 15);
            this.txtWpName.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.txtWpName.Name = "txtWpName";
            this.txtWpName.Size = new System.Drawing.Size(261, 30);
            this.txtWpName.TabIndex = 208;
            // 
            // txtMatName
            // 
            this.txtMatName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMatName.Location = new System.Drawing.Point(129, 139);
            this.txtMatName.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.txtMatName.Name = "txtMatName";
            this.txtMatName.Size = new System.Drawing.Size(261, 30);
            this.txtMatName.TabIndex = 209;
            // 
            // frmWorkOrdersCreatePOPUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(819, 349);
            this.Controls.Add(this.txtMatName);
            this.Controls.Add(this.txtWpName);
            this.Controls.Add(this.txtOrderCnt);
            this.Controls.Add(this.txtPlanCnt);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rdoN);
            this.Controls.Add(this.rdoY);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDetail);
            this.Controls.Add(this.txtEmp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboWOS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboMatName);
            this.Controls.Add(this.lblWPNum);
            this.Controls.Add(this.cboWpName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboPrcName);
            this.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "frmWorkOrdersCreatePOPUP";
            this.Text = "작업지시등록";
            this.Load += new System.EventHandler(this.frmWorkOrdersCreatePOPUP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrderCnt;
        private System.Windows.Forms.TextBox txtPlanCnt;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rdoN;
        private System.Windows.Forms.RadioButton rdoY;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.TextBox txtEmp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboWOS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMatName;
        private System.Windows.Forms.Label lblWPNum;
        private System.Windows.Forms.ComboBox cboWpName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPrcName;
        private System.Windows.Forms.TextBox txtWpName;
        private System.Windows.Forms.TextBox txtMatName;
    }
}