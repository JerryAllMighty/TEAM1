
namespace BedFactory
{
    partial class frmProductionPlanning
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboWorkPlace = new System.Windows.Forms.ComboBox();
            this.dtpUploadDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDemandPlanNum = new System.Windows.Forms.ComboBox();
            this.searchLocationControl1 = new BedFactory.Controls.SearchLocationControl();
            this.lblDemandPlan = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.dgvProductionPlan = new BedFactory.DatagridviewControl();
            this.pnlDgv.SuspendLayout();
            this.pnlSelect.SuspendLayout();
            this.searchLocationControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductionPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(1303, 99);
            this.btn2.Visible = false;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(1232, 99);
            this.btn3.Visible = false;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(995, 99);
            this.btn5.Visible = false;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.Text = "생산게획";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(1405, 99);
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.dgvProductionPlan);
            this.pnlDgv.Size = new System.Drawing.Size(1358, 811);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(1126, 99);
            this.btn4.Visible = false;
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.searchLocationControl1);
            // 
            // cboWorkPlace
            // 
            this.cboWorkPlace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboWorkPlace.FormattingEnabled = true;
            this.cboWorkPlace.Location = new System.Drawing.Point(988, 20);
            this.cboWorkPlace.Name = "cboWorkPlace";
            this.cboWorkPlace.Size = new System.Drawing.Size(213, 31);
            this.cboWorkPlace.TabIndex = 13;
            // 
            // dtpUploadDate
            // 
            this.dtpUploadDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpUploadDate.Location = new System.Drawing.Point(576, 16);
            this.dtpUploadDate.Name = "dtpUploadDate";
            this.dtpUploadDate.Size = new System.Drawing.Size(200, 30);
            this.dtpUploadDate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "납기일";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(875, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "작업장";
            // 
            // cboDemandPlanNum
            // 
            this.cboDemandPlanNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboDemandPlanNum.FormattingEnabled = true;
            this.cboDemandPlanNum.Location = new System.Drawing.Point(150, 20);
            this.cboDemandPlanNum.Name = "cboDemandPlanNum";
            this.cboDemandPlanNum.Size = new System.Drawing.Size(213, 31);
            this.cboDemandPlanNum.TabIndex = 1;
            // 
            // searchLocationControl1
            // 
            this.searchLocationControl1.ColumnCount = 10;
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.searchLocationControl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.searchLocationControl1.Controls.Add(this.cboWorkPlace, 7, 0);
            this.searchLocationControl1.Controls.Add(this.lblDemandPlan, 0, 0);
            this.searchLocationControl1.Controls.Add(this.cboDemandPlanNum, 1, 0);
            this.searchLocationControl1.Controls.Add(this.label3, 3, 0);
            this.searchLocationControl1.Controls.Add(this.dtpUploadDate, 4, 0);
            this.searchLocationControl1.Controls.Add(this.label2, 6, 0);
            this.searchLocationControl1.Controls.Add(this.btnSelect, 9, 0);
            this.searchLocationControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchLocationControl1.Location = new System.Drawing.Point(0, 0);
            this.searchLocationControl1.Name = "searchLocationControl1";
            this.searchLocationControl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchLocationControl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchLocationControl1.Size = new System.Drawing.Size(1356, 63);
            this.searchLocationControl1.TabIndex = 0;
            // 
            // lblDemandPlan
            // 
            this.lblDemandPlan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDemandPlan.AutoSize = true;
            this.lblDemandPlan.Location = new System.Drawing.Point(5, 20);
            this.lblDemandPlan.Name = "lblDemandPlan";
            this.lblDemandPlan.Size = new System.Drawing.Size(124, 23);
            this.lblDemandPlan.TabIndex = 1;
            this.lblDemandPlan.Text = "수요 계획 번호";
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelect.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSelect.Location = new System.Drawing.Point(1271, 16);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(70, 30);
            this.btnSelect.TabIndex = 49;
            this.btnSelect.Text = "조회";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // dgvProductionPlan
            // 
            this.dgvProductionPlan.AllowUserToAddRows = false;
            this.dgvProductionPlan.AllowUserToResizeRows = false;
            this.dgvProductionPlan.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvProductionPlan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductionPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductionPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductionPlan.Location = new System.Drawing.Point(0, 0);
            this.dgvProductionPlan.Name = "dgvProductionPlan";
            this.dgvProductionPlan.RowHeadersVisible = false;
            this.dgvProductionPlan.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvProductionPlan.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductionPlan.RowTemplate.Height = 27;
            this.dgvProductionPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductionPlan.Size = new System.Drawing.Size(1358, 811);
            this.dgvProductionPlan.TabIndex = 0;
            // 
            // frmProductionPlanning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Name = "frmProductionPlanning";
            this.Text = "생산계획";
            this.Load += new System.EventHandler(this.frmProductionPlanning_Load);
            this.pnlDgv.ResumeLayout(false);
            this.pnlSelect.ResumeLayout(false);
            this.searchLocationControl1.ResumeLayout(false);
            this.searchLocationControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductionPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpUploadDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDemandPlanNum;
        private System.Windows.Forms.ComboBox cboWorkPlace;
        private Controls.SearchLocationControl searchLocationControl1;
        private System.Windows.Forms.Label lblDemandPlan;
        private System.Windows.Forms.Button btnSelect;
        private DatagridviewControl dgvProductionPlan;
    }
}