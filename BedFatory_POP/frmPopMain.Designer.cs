
namespace BedFatory_POP
{
    partial class frmPopMain
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
            this.pnlChild = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.lblChildName = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnError = new System.Windows.Forms.Button();
            this.btnPacking = new System.Windows.Forms.Button();
            this.btnDrilling = new System.Windows.Forms.Button();
            this.btnSawing = new System.Windows.Forms.Button();
            this.btnNonOperation = new System.Windows.Forms.Button();
            this.btnPlaning = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChild
            // 
            this.pnlChild.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChild.Location = new System.Drawing.Point(10, 85);
            this.pnlChild.Name = "pnlChild";
            this.pnlChild.Size = new System.Drawing.Size(1000, 755);
            this.pnlChild.TabIndex = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMinimize.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimize.Location = new System.Drawing.Point(988, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(188, 75);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "최소화";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancel.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(1182, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(188, 75);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "닫기";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnHome.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.Black;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(794, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(188, 75);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "홈";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblChildName
            // 
            this.lblChildName.AutoSize = true;
            this.lblChildName.Font = new System.Drawing.Font("맑은 고딕", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblChildName.Location = new System.Drawing.Point(12, 19);
            this.lblChildName.Name = "lblChildName";
            this.lblChildName.Size = new System.Drawing.Size(0, 106);
            this.lblChildName.TabIndex = 4;
            this.lblChildName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenu.Controls.Add(this.btnError);
            this.pnlMenu.Controls.Add(this.btnPacking);
            this.pnlMenu.Controls.Add(this.btnDrilling);
            this.pnlMenu.Controls.Add(this.btnSawing);
            this.pnlMenu.Controls.Add(this.btnNonOperation);
            this.pnlMenu.Controls.Add(this.btnPlaning);
            this.pnlMenu.Location = new System.Drawing.Point(1016, 85);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(354, 755);
            this.pnlMenu.TabIndex = 5;
            // 
            // btnError
            // 
            this.btnError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnError.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnError.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnError.Location = new System.Drawing.Point(3, 124);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(349, 113);
            this.btnError.TabIndex = 9;
            this.btnError.Text = "불량 관리";
            this.btnError.UseVisualStyleBackColor = false;
            this.btnError.Visible = false;
            // 
            // btnPacking
            // 
            this.btnPacking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPacking.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPacking.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPacking.Location = new System.Drawing.Point(3, 604);
            this.btnPacking.Name = "btnPacking";
            this.btnPacking.Size = new System.Drawing.Size(349, 113);
            this.btnPacking.TabIndex = 13;
            this.btnPacking.Text = "포장";
            this.btnPacking.UseVisualStyleBackColor = false;
            this.btnPacking.Click += new System.EventHandler(this.btnPacking_Click_1);
            // 
            // btnDrilling
            // 
            this.btnDrilling.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDrilling.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDrilling.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDrilling.Location = new System.Drawing.Point(3, 484);
            this.btnDrilling.Name = "btnDrilling";
            this.btnDrilling.Size = new System.Drawing.Size(349, 113);
            this.btnDrilling.TabIndex = 14;
            this.btnDrilling.Text = "착조";
            this.btnDrilling.UseVisualStyleBackColor = false;
            this.btnDrilling.Click += new System.EventHandler(this.btnDrilling_Click_1);
            // 
            // btnSawing
            // 
            this.btnSawing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSawing.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSawing.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSawing.Location = new System.Drawing.Point(3, 364);
            this.btnSawing.Name = "btnSawing";
            this.btnSawing.Size = new System.Drawing.Size(349, 113);
            this.btnSawing.TabIndex = 12;
            this.btnSawing.Text = "평삭";
            this.btnSawing.UseVisualStyleBackColor = false;
            this.btnSawing.Click += new System.EventHandler(this.btnSawing_Click_1);
            // 
            // btnNonOperation
            // 
            this.btnNonOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNonOperation.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNonOperation.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNonOperation.Location = new System.Drawing.Point(3, 3);
            this.btnNonOperation.Name = "btnNonOperation";
            this.btnNonOperation.Size = new System.Drawing.Size(349, 113);
            this.btnNonOperation.TabIndex = 10;
            this.btnNonOperation.Text = "비가동관리";
            this.btnNonOperation.UseVisualStyleBackColor = false;
            this.btnNonOperation.Visible = false;
            // 
            // btnPlaning
            // 
            this.btnPlaning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlaning.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPlaning.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPlaning.Location = new System.Drawing.Point(3, 244);
            this.btnPlaning.Name = "btnPlaning";
            this.btnPlaning.Size = new System.Drawing.Size(349, 113);
            this.btnPlaning.TabIndex = 11;
            this.btnPlaning.Text = "제재";
            this.btnPlaning.UseVisualStyleBackColor = false;
            this.btnPlaning.Click += new System.EventHandler(this.btnPlaning_Click_1);
            // 
            // frmPopMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(34F, 81F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.lblChildName);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.pnlChild);
            this.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "frmPopMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPopMain_FormClosed);
            this.Load += new System.EventHandler(this.frmPopMain_Load);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlChild;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Label lblChildName;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnError;
        private System.Windows.Forms.Button btnPacking;
        private System.Windows.Forms.Button btnDrilling;
        private System.Windows.Forms.Button btnSawing;
        private System.Windows.Forms.Button btnNonOperation;
        private System.Windows.Forms.Button btnPlaning;
    }
}