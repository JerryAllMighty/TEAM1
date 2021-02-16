
namespace BedFactory.Pop_up
{
    partial class frmShipmentOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboKind = new System.Windows.Forms.ComboBox();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboWearHouse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nmrCnt = new System.Windows.Forms.NumericUpDown();
            this.dgvShipmentList = new BedFactory.DatagridviewControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipmentList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnInsert.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsert.Location = new System.Drawing.Point(532, 388);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(125, 50);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "등 록";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(663, 388);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 50);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "취 소";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvShipmentList);
            this.panel1.Location = new System.Drawing.Point(424, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 370);
            this.panel1.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(293, 388);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 50);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "추 가";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "* 자재종류";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "* 자재명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "* 출하개수";
            // 
            // cboKind
            // 
            this.cboKind.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKind.FormattingEnabled = true;
            this.cboKind.Location = new System.Drawing.Point(135, 32);
            this.cboKind.Name = "cboKind";
            this.cboKind.Size = new System.Drawing.Size(231, 25);
            this.cboKind.TabIndex = 18;
            this.cboKind.SelectedIndexChanged += new System.EventHandler(this.cbbKind_SelectedIndexChanged);
            // 
            // cboName
            // 
            this.cboName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboName.FormattingEnabled = true;
            this.cboName.Location = new System.Drawing.Point(135, 124);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(231, 25);
            this.cboName.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboWearHouse);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.nmrCnt);
            this.panel2.Controls.Add(this.cboName);
            this.panel2.Controls.Add(this.cboKind);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 370);
            this.panel2.TabIndex = 16;
            // 
            // cboWearHouse
            // 
            this.cboWearHouse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboWearHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWearHouse.FormattingEnabled = true;
            this.cboWearHouse.Location = new System.Drawing.Point(135, 216);
            this.cboWearHouse.Name = "cboWearHouse";
            this.cboWearHouse.Size = new System.Drawing.Size(231, 25);
            this.cboWearHouse.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "* 창고";
            // 
            // nmrCnt
            // 
            this.nmrCnt.Location = new System.Drawing.Point(135, 309);
            this.nmrCnt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrCnt.Name = "nmrCnt";
            this.nmrCnt.Size = new System.Drawing.Size(73, 25);
            this.nmrCnt.TabIndex = 20;
            // 
            // dgvShipmentList
            // 
            this.dgvShipmentList.AllowUserToAddRows = false;
            this.dgvShipmentList.AllowUserToResizeRows = false;
            this.dgvShipmentList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvShipmentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShipmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShipmentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShipmentList.Location = new System.Drawing.Point(0, 0);
            this.dgvShipmentList.Name = "dgvShipmentList";
            this.dgvShipmentList.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvShipmentList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvShipmentList.RowTemplate.Height = 23;
            this.dgvShipmentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShipmentList.Size = new System.Drawing.Size(364, 370);
            this.dgvShipmentList.TabIndex = 0;
            this.dgvShipmentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShipmentList_CellContentClick);
            // 
            // frmShipmentOrders
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "frmShipmentOrders";
            this.Text = "출하지시";
            this.Load += new System.EventHandler(this.frmShipmentOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipmentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboKind;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboWearHouse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmrCnt;
        private DatagridviewControl dgvShipmentList;
    }
}