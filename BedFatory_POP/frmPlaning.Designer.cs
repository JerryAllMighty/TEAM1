
namespace BedFatory_POP
{
    partial class frmPlaning
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
            this.components = new System.ComponentModel.Container();
            this.pnlDrillMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddCnt = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnWS = new System.Windows.Forms.Button();
            this.btnWA = new System.Windows.Forms.Button();
            this.btnWStop = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblWorkStopTime = new System.Windows.Forms.Label();
            this.lblWorkDuration = new System.Windows.Forms.Label();
            this.lblWorkTime = new System.Windows.Forms.Label();
            this.lblWorkStop = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtWorker = new System.Windows.Forms.TextBox();
            this.txtWO_Num = new System.Windows.Forms.TextBox();
            this.lblWO_Num = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblWorker_Num = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboWorkPlace = new System.Windows.Forms.ComboBox();
            this.lblWorkPlace = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTotalOrderCnt = new System.Windows.Forms.Label();
            this.lblTotCnt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalProductCnt = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblErrorCnt = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblOkayProductCnt = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblOrderLeftCnt = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pnlDrillMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDrillMain
            // 
            this.pnlDrillMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDrillMain.Controls.Add(this.panel2);
            this.pnlDrillMain.Controls.Add(this.panel6);
            this.pnlDrillMain.Controls.Add(this.panel4);
            this.pnlDrillMain.Controls.Add(this.panel3);
            this.pnlDrillMain.Controls.Add(this.panel5);
            this.pnlDrillMain.Controls.Add(this.panel1);
            this.pnlDrillMain.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pnlDrillMain.Location = new System.Drawing.Point(12, 12);
            this.pnlDrillMain.Name = "pnlDrillMain";
            this.pnlDrillMain.Size = new System.Drawing.Size(1258, 958);
            this.pnlDrillMain.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.btnAddCnt);
            this.panel2.Controls.Add(this.btnFinish);
            this.panel2.Controls.Add(this.btnWS);
            this.panel2.Controls.Add(this.btnWA);
            this.panel2.Controls.Add(this.btnWStop);
            this.panel2.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel2.Location = new System.Drawing.Point(0, 725);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1250, 216);
            this.panel2.TabIndex = 9;
            // 
            // btnAddCnt
            // 
            this.btnAddCnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCnt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddCnt.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAddCnt.Location = new System.Drawing.Point(987, 33);
            this.btnAddCnt.Name = "btnAddCnt";
            this.btnAddCnt.Size = new System.Drawing.Size(236, 165);
            this.btnAddCnt.TabIndex = 11;
            this.btnAddCnt.Text = "생산 실적   등록";
            this.btnAddCnt.UseVisualStyleBackColor = false;
            this.btnAddCnt.Click += new System.EventHandler(this.btnAddCnt_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFinish.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFinish.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFinish.Location = new System.Drawing.Point(742, 33);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(236, 165);
            this.btnFinish.TabIndex = 10;
            this.btnFinish.Text = "현장마감";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnWS
            // 
            this.btnWS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWS.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnWS.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWS.Location = new System.Drawing.Point(258, 33);
            this.btnWS.Name = "btnWS";
            this.btnWS.Size = new System.Drawing.Size(236, 165);
            this.btnWS.TabIndex = 9;
            this.btnWS.Text = "작업시작";
            this.btnWS.UseVisualStyleBackColor = false;
            this.btnWS.Click += new System.EventHandler(this.btnWS_Click);
            // 
            // btnWA
            // 
            this.btnWA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWA.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnWA.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWA.Location = new System.Drawing.Point(15, 33);
            this.btnWA.Name = "btnWA";
            this.btnWA.Size = new System.Drawing.Size(236, 165);
            this.btnWA.TabIndex = 7;
            this.btnWA.Text = "작업자 할당";
            this.btnWA.UseVisualStyleBackColor = false;
            this.btnWA.Click += new System.EventHandler(this.btnWA_Click);
            // 
            // btnWStop
            // 
            this.btnWStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWStop.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnWStop.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWStop.Location = new System.Drawing.Point(500, 33);
            this.btnWStop.Name = "btnWStop";
            this.btnWStop.Size = new System.Drawing.Size(236, 165);
            this.btnWStop.TabIndex = 6;
            this.btnWStop.Text = "작업 중지";
            this.btnWStop.UseVisualStyleBackColor = false;
            this.btnWStop.Click += new System.EventHandler(this.btnWStop_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.lblWorkStopTime);
            this.panel6.Controls.Add(this.lblWorkDuration);
            this.panel6.Controls.Add(this.lblWorkTime);
            this.panel6.Controls.Add(this.lblWorkStop);
            this.panel6.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel6.Location = new System.Drawing.Point(4, 630);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1246, 89);
            this.panel6.TabIndex = 6;
            // 
            // lblWorkStopTime
            // 
            this.lblWorkStopTime.AutoSize = true;
            this.lblWorkStopTime.ForeColor = System.Drawing.Color.Red;
            this.lblWorkStopTime.Location = new System.Drawing.Point(987, 10);
            this.lblWorkStopTime.Name = "lblWorkStopTime";
            this.lblWorkStopTime.Size = new System.Drawing.Size(0, 51);
            this.lblWorkStopTime.TabIndex = 24;
            // 
            // lblWorkDuration
            // 
            this.lblWorkDuration.AutoSize = true;
            this.lblWorkDuration.ForeColor = System.Drawing.Color.Lime;
            this.lblWorkDuration.Location = new System.Drawing.Point(312, 10);
            this.lblWorkDuration.Name = "lblWorkDuration";
            this.lblWorkDuration.Size = new System.Drawing.Size(0, 51);
            this.lblWorkDuration.TabIndex = 23;
            // 
            // lblWorkTime
            // 
            this.lblWorkTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWorkTime.AutoSize = true;
            this.lblWorkTime.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWorkTime.Location = new System.Drawing.Point(26, 10);
            this.lblWorkTime.Name = "lblWorkTime";
            this.lblWorkTime.Size = new System.Drawing.Size(174, 51);
            this.lblWorkTime.TabIndex = 21;
            this.lblWorkTime.Text = "작업시간";
            // 
            // lblWorkStop
            // 
            this.lblWorkStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWorkStop.AutoSize = true;
            this.lblWorkStop.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWorkStop.Location = new System.Drawing.Point(587, 10);
            this.lblWorkStop.Name = "lblWorkStop";
            this.lblWorkStop.Size = new System.Drawing.Size(276, 51);
            this.lblWorkStop.TabIndex = 22;
            this.lblWorkStop.Text = "작업 중지 시간";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.txtSubject);
            this.panel4.Controls.Add(this.txtWorker);
            this.panel4.Controls.Add(this.txtWO_Num);
            this.panel4.Controls.Add(this.lblWO_Num);
            this.panel4.Controls.Add(this.lblSubject);
            this.panel4.Controls.Add(this.lblWorker_Num);
            this.panel4.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel4.Location = new System.Drawing.Point(4, 137);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(833, 237);
            this.panel4.TabIndex = 4;
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSubject.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSubject.Location = new System.Drawing.Point(319, 162);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(486, 57);
            this.txtSubject.TabIndex = 18;
            // 
            // txtWorker
            // 
            this.txtWorker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWorker.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorker.Location = new System.Drawing.Point(319, 87);
            this.txtWorker.Name = "txtWorker";
            this.txtWorker.Size = new System.Drawing.Size(486, 57);
            this.txtWorker.TabIndex = 17;
            // 
            // txtWO_Num
            // 
            this.txtWO_Num.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWO_Num.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWO_Num.Location = new System.Drawing.Point(319, 14);
            this.txtWO_Num.Name = "txtWO_Num";
            this.txtWO_Num.Size = new System.Drawing.Size(486, 57);
            this.txtWO_Num.TabIndex = 16;
            // 
            // lblWO_Num
            // 
            this.lblWO_Num.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWO_Num.AutoSize = true;
            this.lblWO_Num.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWO_Num.Location = new System.Drawing.Point(24, 14);
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
            this.lblSubject.Location = new System.Drawing.Point(24, 150);
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
            this.lblWorker_Num.Location = new System.Drawing.Point(24, 82);
            this.lblWorker_Num.Name = "lblWorker_Num";
            this.lblWorker_Num.Size = new System.Drawing.Size(136, 51);
            this.lblWorker_Num.TabIndex = 14;
            this.lblWorker_Num.Text = "작업자";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.cboWorkPlace);
            this.panel3.Controls.Add(this.lblWorkPlace);
            this.panel3.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel3.Location = new System.Drawing.Point(4, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(833, 79);
            this.panel3.TabIndex = 0;
            // 
            // cboWorkPlace
            // 
            this.cboWorkPlace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboWorkPlace.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboWorkPlace.FormattingEnabled = true;
            this.cboWorkPlace.Location = new System.Drawing.Point(321, 10);
            this.cboWorkPlace.Name = "cboWorkPlace";
            this.cboWorkPlace.Size = new System.Drawing.Size(486, 58);
            this.cboWorkPlace.TabIndex = 3;
            this.cboWorkPlace.SelectedIndexChanged += new System.EventHandler(this.cboWorkPlace_SelectedIndexChanged);
            // 
            // lblWorkPlace
            // 
            this.lblWorkPlace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWorkPlace.AutoSize = true;
            this.lblWorkPlace.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWorkPlace.Location = new System.Drawing.Point(26, 4);
            this.lblWorkPlace.Name = "lblWorkPlace";
            this.lblWorkPlace.Size = new System.Drawing.Size(136, 51);
            this.lblWorkPlace.TabIndex = 2;
            this.lblWorkPlace.Text = "작업장";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.lblTotalOrderCnt);
            this.panel5.Controls.Add(this.lblTotCnt);
            this.panel5.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel5.Location = new System.Drawing.Point(843, 54);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(412, 320);
            this.panel5.TabIndex = 5;
            // 
            // lblTotalOrderCnt
            // 
            this.lblTotalOrderCnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalOrderCnt.AutoSize = true;
            this.lblTotalOrderCnt.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalOrderCnt.Font = new System.Drawing.Font("맑은 고딕", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotalOrderCnt.ForeColor = System.Drawing.Color.Lime;
            this.lblTotalOrderCnt.Location = new System.Drawing.Point(30, 97);
            this.lblTotalOrderCnt.Name = "lblTotalOrderCnt";
            this.lblTotalOrderCnt.Size = new System.Drawing.Size(0, 159);
            this.lblTotalOrderCnt.TabIndex = 2;
            // 
            // lblTotCnt
            // 
            this.lblTotCnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotCnt.AutoSize = true;
            this.lblTotCnt.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotCnt.Location = new System.Drawing.Point(3, 6);
            this.lblTotCnt.Name = "lblTotCnt";
            this.lblTotCnt.Size = new System.Drawing.Size(187, 51);
            this.lblTotCnt.TabIndex = 1;
            this.lblTotCnt.Text = "총 오더량";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(4, 384);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1246, 240);
            this.panel1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.lblTotalProductCnt);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(11, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "총 작업량";
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
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.lblErrorCnt);
            this.groupBox4.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.Location = new System.Drawing.Point(869, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(280, 185);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "불량 수량";
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
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.lblOkayProductCnt);
            this.groupBox3.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(583, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 185);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "양품 수량";
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
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.lblOrderLeftCnt);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(297, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "오더 잔량";
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
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            // 
            // frmPlaning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 54F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1282, 982);
            this.ControlBox = false;
            this.Controls.Add(this.pnlDrillMain);
            this.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.Name = "frmPlaning";
            this.Load += new System.EventHandler(this.frmPlaning_Load);
            this.pnlDrillMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDrillMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddCnt;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnWS;
        private System.Windows.Forms.Button btnWA;
        private System.Windows.Forms.Button btnWStop;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblWorkStopTime;
        private System.Windows.Forms.Label lblWorkDuration;
        private System.Windows.Forms.Label lblWorkTime;
        private System.Windows.Forms.Label lblWorkStop;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtWorker;
        private System.Windows.Forms.TextBox txtWO_Num;
        private System.Windows.Forms.Label lblWO_Num;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblWorker_Num;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cboWorkPlace;
        private System.Windows.Forms.Label lblWorkPlace;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTotalOrderCnt;
        private System.Windows.Forms.Label lblTotCnt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalProductCnt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblErrorCnt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblOkayProductCnt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblOrderLeftCnt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}