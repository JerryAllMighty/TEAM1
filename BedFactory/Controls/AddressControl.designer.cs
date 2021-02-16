namespace BedFactory
{
    partial class AddressControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDetailAddress = new System.Windows.Forms.TextBox();
            this.lblDetailAddress = new System.Windows.Forms.Label();
            this.txtRoad = new System.Windows.Forms.TextBox();
            this.txtJibun = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnSearchAddr = new System.Windows.Forms.Button();
            this.txtWooPyun = new System.Windows.Forms.TextBox();
            this.lblRoad = new System.Windows.Forms.Label();
            this.lblJibun = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDetailAddress
            // 
            this.txtDetailAddress.Location = new System.Drawing.Point(159, 93);
            this.txtDetailAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDetailAddress.Name = "txtDetailAddress";
            this.txtDetailAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDetailAddress.Size = new System.Drawing.Size(306, 25);
            this.txtDetailAddress.TabIndex = 3;
            // 
            // lblDetailAddress
            // 
            this.lblDetailAddress.AutoSize = true;
            this.lblDetailAddress.Location = new System.Drawing.Point(-3, 98);
            this.lblDetailAddress.Name = "lblDetailAddress";
            this.lblDetailAddress.Size = new System.Drawing.Size(79, 15);
            this.lblDetailAddress.TabIndex = 63;
            this.lblDetailAddress.Text = "*상세 주소";
            // 
            // txtRoad
            // 
            this.txtRoad.Location = new System.Drawing.Point(159, 35);
            this.txtRoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRoad.Name = "txtRoad";
            this.txtRoad.Size = new System.Drawing.Size(306, 25);
            this.txtRoad.TabIndex = 1;
            this.txtRoad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress1_KeyPress);
            // 
            // txtJibun
            // 
            this.txtJibun.Location = new System.Drawing.Point(159, 64);
            this.txtJibun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJibun.Name = "txtJibun";
            this.txtJibun.Size = new System.Drawing.Size(306, 25);
            this.txtJibun.TabIndex = 2;
            this.txtJibun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress2_KeyPress);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(-3, 9);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(44, 15);
            this.lblAddress.TabIndex = 60;
            this.lblAddress.Text = "*주소";
            // 
            // btnSearchAddr
            // 
            this.btnSearchAddr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchAddr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchAddr.Location = new System.Drawing.Point(491, 6);
            this.btnSearchAddr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchAddr.Name = "btnSearchAddr";
            this.btnSearchAddr.Size = new System.Drawing.Size(112, 30);
            this.btnSearchAddr.TabIndex = 4;
            this.btnSearchAddr.Text = "주소검색";
            this.btnSearchAddr.UseVisualStyleBackColor = false;
            this.btnSearchAddr.Click += new System.EventHandler(this.btnSearchAddr_Click);
            // 
            // txtWooPyun
            // 
            this.txtWooPyun.Location = new System.Drawing.Point(159, 6);
            this.txtWooPyun.Name = "txtWooPyun";
            this.txtWooPyun.Size = new System.Drawing.Size(113, 25);
            this.txtWooPyun.TabIndex = 0;
            this.txtWooPyun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWooPyun_KeyPress);
            // 
            // lblRoad
            // 
            this.lblRoad.AutoSize = true;
            this.lblRoad.Location = new System.Drawing.Point(-3, 35);
            this.lblRoad.Name = "lblRoad";
            this.lblRoad.Size = new System.Drawing.Size(79, 15);
            this.lblRoad.TabIndex = 64;
            this.lblRoad.Text = "*도로 주소";
            // 
            // lblJibun
            // 
            this.lblJibun.AutoSize = true;
            this.lblJibun.Location = new System.Drawing.Point(-3, 64);
            this.lblJibun.Name = "lblJibun";
            this.lblJibun.Size = new System.Drawing.Size(79, 15);
            this.lblJibun.TabIndex = 65;
            this.lblJibun.Text = "*지번 주소";
            // 
            // AddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.lblJibun);
            this.Controls.Add(this.lblRoad);
            this.Controls.Add(this.txtWooPyun);
            this.Controls.Add(this.btnSearchAddr);
            this.Controls.Add(this.txtDetailAddress);
            this.Controls.Add(this.lblDetailAddress);
            this.Controls.Add(this.txtRoad);
            this.Controls.Add(this.txtJibun);
            this.Controls.Add(this.lblAddress);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "AddressControl";
            this.Size = new System.Drawing.Size(606, 126);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDetailAddress;
        private System.Windows.Forms.Label lblDetailAddress;
        private System.Windows.Forms.TextBox txtRoad;
        private System.Windows.Forms.TextBox txtJibun;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnSearchAddr;
        private System.Windows.Forms.TextBox txtWooPyun;
        private System.Windows.Forms.Label lblRoad;
        private System.Windows.Forms.Label lblJibun;
    }
}
