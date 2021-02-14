
namespace BedFatory_POP
{
    partial class frmSawing
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlCurrentStatus = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnlMenu.Controls.Add(this.button6);
            this.pnlMenu.Controls.Add(this.button5);
            this.pnlMenu.Controls.Add(this.button4);
            this.pnlMenu.Controls.Add(this.button3);
            this.pnlMenu.Controls.Add(this.button1);
            this.pnlMenu.Controls.Add(this.button2);
            this.pnlMenu.Location = new System.Drawing.Point(12, 561);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1258, 180);
            this.pnlMenu.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Location = new System.Drawing.Point(882, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(168, 165);
            this.button6.TabIndex = 6;
            this.button6.Text = "생산 실적   등록";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(708, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(168, 165);
            this.button5.TabIndex = 5;
            this.button5.Text = "현장마감";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(534, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 165);
            this.button4.TabIndex = 4;
            this.button4.Text = "작업시작";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(360, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 165);
            this.button3.TabIndex = 3;
            this.button3.Text = "공정 조건   등록";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(186, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 165);
            this.button1.TabIndex = 2;
            this.button1.Text = "작업자 할당";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 165);
            this.button2.TabIndex = 1;
            this.button2.Text = "작업지시현황";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pnlCurrentStatus
            // 
            this.pnlCurrentStatus.Location = new System.Drawing.Point(12, 12);
            this.pnlCurrentStatus.Name = "pnlCurrentStatus";
            this.pnlCurrentStatus.Size = new System.Drawing.Size(1258, 543);
            this.pnlCurrentStatus.TabIndex = 6;
            // 
            // frmSawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlCurrentStatus);
            this.Name = "frmSawing";
            this.Text = "제재";
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlCurrentStatus;
        private System.Windows.Forms.Button button6;
    }
}