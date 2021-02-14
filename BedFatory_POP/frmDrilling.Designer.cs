
namespace BedFatory_POP
{
    partial class frmDrilling
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddCnt = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnWS = new System.Windows.Forms.Button();
            this.btnWA = new System.Windows.Forms.Button();
            this.btnWO = new System.Windows.Forms.Button();
            this.pnlDrillMain = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTotCnt = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblTotalProductCnt = new System.Windows.Forms.Label();
            this.lblOrderLeftCnt = new System.Windows.Forms.Label();
            this.lblOkayProductCnt = new System.Windows.Forms.Label();
            this.lblErrorCnt = new System.Windows.Forms.Label();
            this.lblTotalOrderCnt = new System.Windows.Forms.Label();
            this.cboWorkPlace = new System.Windows.Forms.ComboBox();
            this.lblWorkPlace = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtWorker = new System.Windows.Forms.TextBox();
            this.txtWO_Num = new System.Windows.Forms.TextBox();
            this.lblWO_Num = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblWorker_Num = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.pnlDrillMain.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.btnAddCnt);
            this.panel2.Controls.Add(this.btnFinish);
            this.panel2.Controls.Add(this.btnWS);
            this.panel2.Controls.Add(this.btnWA);
            this.panel2.Controls.Add(this.btnWO);
            this.panel2.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel2.Location = new System.Drawing.Point(12, 561);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1258, 180);
            this.panel2.TabIndex = 9;
            // 
            // btnAddCnt
            // 
            this.btnAddCnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCnt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddCnt.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAddCnt.Location = new System.Drawing.Point(991, 15);
            this.btnAddCnt.Name = "btnAddCnt";
            this.btnAddCnt.Size = new System.Drawing.Size(236, 165);
            this.btnAddCnt.TabIndex = 11;
            this.btnAddCnt.Text = "생산 실적   등록";
            this.btnAddCnt.UseVisualStyleBackColor = false;
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFinish.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFinish.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFinish.Location = new System.Drawing.Point(505, 15);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(236, 165);
            this.btnFinish.TabIndex = 10;
            this.btnFinish.Text = "현장마감";
            this.btnFinish.UseVisualStyleBackColor = false;
            // 
            // btnWS
            // 
            this.btnWS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWS.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnWS.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWS.Location = new System.Drawing.Point(262, 15);
            this.btnWS.Name = "btnWS";
            this.btnWS.Size = new System.Drawing.Size(236, 165);
            this.btnWS.TabIndex = 9;
            this.btnWS.Text = "작업시작";
            this.btnWS.UseVisualStyleBackColor = false;
            // 
            // btnWA
            // 
            this.btnWA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWA.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnWA.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWA.Location = new System.Drawing.Point(19, 15);
            this.btnWA.Name = "btnWA";
            this.btnWA.Size = new System.Drawing.Size(236, 165);
            this.btnWA.TabIndex = 7;
            this.btnWA.Text = "작업자 할당";
            this.btnWA.UseVisualStyleBackColor = false;
            this.btnWA.Click += new System.EventHandler(this.btnWA_Click);
            // 
            // btnWO
            // 
            this.btnWO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWO.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnWO.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWO.Location = new System.Drawing.Point(748, 15);
            this.btnWO.Name = "btnWO";
            this.btnWO.Size = new System.Drawing.Size(236, 165);
            this.btnWO.TabIndex = 6;
            this.btnWO.Text = "작업 중지";
            this.btnWO.UseVisualStyleBackColor = false;
            this.btnWO.Click += new System.EventHandler(this.btnWO_Click);
            // 
            // pnlDrillMain
            // 
            this.pnlDrillMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDrillMain.Controls.Add(this.groupBox4);
            this.pnlDrillMain.Controls.Add(this.groupBox2);
            this.pnlDrillMain.Controls.Add(this.groupBox3);
            this.pnlDrillMain.Controls.Add(this.panel4);
            this.pnlDrillMain.Controls.Add(this.panel3);
            this.pnlDrillMain.Controls.Add(this.groupBox1);
            this.pnlDrillMain.Controls.Add(this.panel5);
            this.pnlDrillMain.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pnlDrillMain.Location = new System.Drawing.Point(12, 12);
            this.pnlDrillMain.Name = "pnlDrillMain";
            this.pnlDrillMain.Size = new System.Drawing.Size(1258, 543);
            this.pnlDrillMain.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.cboWorkPlace);
            this.panel3.Controls.Add(this.lblWorkPlace);
            this.panel3.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel3.Location = new System.Drawing.Point(4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(833, 79);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Controls.Add(this.txtSubject);
            this.panel4.Controls.Add(this.txtWorker);
            this.panel4.Controls.Add(this.txtWO_Num);
            this.panel4.Controls.Add(this.lblWO_Num);
            this.panel4.Controls.Add(this.lblSubject);
            this.panel4.Controls.Add(this.lblWorker_Num);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel4.Location = new System.Drawing.Point(4, 88);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(833, 237);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.Controls.Add(this.lblTotalOrderCnt);
            this.panel5.Controls.Add(this.lblTotCnt);
            this.panel5.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel5.Location = new System.Drawing.Point(843, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(412, 320);
            this.panel5.TabIndex = 5;
            // 
            // lblTotCnt
            // 
            this.lblTotCnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotCnt.AutoSize = true;
            this.lblTotCnt.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotCnt.Location = new System.Drawing.Point(11, -11);
            this.lblTotCnt.Name = "lblTotCnt";
            this.lblTotCnt.Size = new System.Drawing.Size(187, 51);
            this.lblTotCnt.TabIndex = 1;
            this.lblTotCnt.Text = "총 오더량";
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel6.Location = new System.Drawing.Point(3, 249);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1239, 199);
            this.panel6.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.lblTotalProductCnt);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(13, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "총 작업량";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.lblOrderLeftCnt);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(323, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "오더 잔량";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.lblOkayProductCnt);
            this.groupBox3.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(633, 340);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 185);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "양품 수량";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.lblErrorCnt);
            this.groupBox4.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.Location = new System.Drawing.Point(943, 340);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(280, 185);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "불량 수량";
            // 
            // lblTotalProductCnt
            // 
            this.lblTotalProductCnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalProductCnt.AutoSize = true;
            this.lblTotalProductCnt.Font = new System.Drawing.Font("맑은 고딕", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotalProductCnt.ForeColor = System.Drawing.Color.Yellow;
            this.lblTotalProductCnt.Location = new System.Drawing.Point(19, 64);
            this.lblTotalProductCnt.Name = "lblTotalProductCnt";
            this.lblTotalProductCnt.Size = new System.Drawing.Size(0, 106);
            this.lblTotalProductCnt.TabIndex = 0;
            // 
            // lblOrderLeftCnt
            // 
            this.lblOrderLeftCnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrderLeftCnt.AutoSize = true;
            this.lblOrderLeftCnt.Font = new System.Drawing.Font("맑은 고딕", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOrderLeftCnt.Location = new System.Drawing.Point(22, 64);
            this.lblOrderLeftCnt.Name = "lblOrderLeftCnt";
            this.lblOrderLeftCnt.Size = new System.Drawing.Size(0, 106);
            this.lblOrderLeftCnt.TabIndex = 1;
            // 
            // lblOkayProductCnt
            // 
            this.lblOkayProductCnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOkayProductCnt.AutoSize = true;
            this.lblOkayProductCnt.Font = new System.Drawing.Font("맑은 고딕", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOkayProductCnt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOkayProductCnt.Location = new System.Drawing.Point(24, 64);
            this.lblOkayProductCnt.Name = "lblOkayProductCnt";
            this.lblOkayProductCnt.Size = new System.Drawing.Size(0, 106);
            this.lblOkayProductCnt.TabIndex = 2;
            // 
            // lblErrorCnt
            // 
            this.lblErrorCnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorCnt.AutoSize = true;
            this.lblErrorCnt.Font = new System.Drawing.Font("맑은 고딕", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblErrorCnt.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCnt.Location = new System.Drawing.Point(44, 64);
            this.lblErrorCnt.Name = "lblErrorCnt";
            this.lblErrorCnt.Size = new System.Drawing.Size(0, 106);
            this.lblErrorCnt.TabIndex = 3;
            // 
            // lblTotalOrderCnt
            // 
            this.lblTotalOrderCnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalOrderCnt.AutoSize = true;
            this.lblTotalOrderCnt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblTotalOrderCnt.Font = new System.Drawing.Font("맑은 고딕", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotalOrderCnt.ForeColor = System.Drawing.Color.Lime;
            this.lblTotalOrderCnt.Location = new System.Drawing.Point(32, 99);
            this.lblTotalOrderCnt.Name = "lblTotalOrderCnt";
            this.lblTotalOrderCnt.Size = new System.Drawing.Size(0, 159);
            this.lblTotalOrderCnt.TabIndex = 2;
            // 
            // cboWorkPlace
            // 
            this.cboWorkPlace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboWorkPlace.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboWorkPlace.FormattingEnabled = true;
            this.cboWorkPlace.Location = new System.Drawing.Point(323, 3);
            this.cboWorkPlace.Name = "cboWorkPlace";
            this.cboWorkPlace.Size = new System.Drawing.Size(486, 58);
            this.cboWorkPlace.TabIndex = 3;
            this.cboWorkPlace.SelectedIndexChanged += new System.EventHandler(this.cboWorkPlace_SelectedIndexChanged_1);
            // 
            // lblWorkPlace
            // 
            this.lblWorkPlace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWorkPlace.AutoSize = true;
            this.lblWorkPlace.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWorkPlace.Location = new System.Drawing.Point(28, 6);
            this.lblWorkPlace.Name = "lblWorkPlace";
            this.lblWorkPlace.Size = new System.Drawing.Size(136, 51);
            this.lblWorkPlace.TabIndex = 2;
            this.lblWorkPlace.Text = "작업장";
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSubject.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSubject.Location = new System.Drawing.Point(321, 164);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(486, 57);
            this.txtSubject.TabIndex = 18;
            // 
            // txtWorker
            // 
            this.txtWorker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWorker.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorker.Location = new System.Drawing.Point(321, 89);
            this.txtWorker.Name = "txtWorker";
            this.txtWorker.Size = new System.Drawing.Size(486, 57);
            this.txtWorker.TabIndex = 17;
            // 
            // txtWO_Num
            // 
            this.txtWO_Num.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWO_Num.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWO_Num.Location = new System.Drawing.Point(321, 16);
            this.txtWO_Num.Name = "txtWO_Num";
            this.txtWO_Num.Size = new System.Drawing.Size(486, 57);
            this.txtWO_Num.TabIndex = 16;
            // 
            // lblWO_Num
            // 
            this.lblWO_Num.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWO_Num.AutoSize = true;
            this.lblWO_Num.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWO_Num.Location = new System.Drawing.Point(26, 16);
            this.lblWO_Num.Name = "lblWO_Num";
            this.lblWO_Num.Size = new System.Drawing.Size(250, 51);
            this.lblWO_Num.TabIndex = 13;
            this.lblWO_Num.Text = "작업지시번호";
            // 
            // lblSubject
            // 
            this.lblSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSubject.Location = new System.Drawing.Point(26, 153);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(174, 51);
            this.lblSubject.TabIndex = 15;
            this.lblSubject.Text = "작업품목";
            // 
            // lblWorker_Num
            // 
            this.lblWorker_Num.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWorker_Num.AutoSize = true;
            this.lblWorker_Num.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWorker_Num.Location = new System.Drawing.Point(26, 76);
            this.lblWorker_Num.Name = "lblWorker_Num";
            this.lblWorker_Num.Size = new System.Drawing.Size(136, 51);
            this.lblWorker_Num.TabIndex = 14;
            this.lblWorker_Num.Text = "작업자";
            // 
            // frmDrilling
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.pnlDrillMain);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "frmDrilling";
            this.Text = "착조";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDrilling_Load);
            this.panel2.ResumeLayout(false);
            this.pnlDrillMain.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddCnt;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnWS;
        private System.Windows.Forms.Button btnWA;
        private System.Windows.Forms.Button btnWO;
        private System.Windows.Forms.Panel pnlDrillMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTotCnt;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblOrderLeftCnt;
        private System.Windows.Forms.Label lblErrorCnt;
        private System.Windows.Forms.Label lblOkayProductCnt;
        private System.Windows.Forms.Label lblTotalProductCnt;
        private System.Windows.Forms.Label lblTotalOrderCnt;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtWorker;
        private System.Windows.Forms.TextBox txtWO_Num;
        private System.Windows.Forms.Label lblWO_Num;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblWorker_Num;
        private System.Windows.Forms.ComboBox cboWorkPlace;
        private System.Windows.Forms.Label lblWorkPlace;
    }
}