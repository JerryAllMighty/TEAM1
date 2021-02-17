
namespace BedFactory
{
    partial class frmMaterialRequirementPlanning
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
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.cboDemandPlan = new System.Windows.Forms.ComboBox();
            this.searchLocationControl1 = new BedFactory.Controls.SearchLocationControl();
            this.lblDemandPlan = new System.Windows.Forms.Label();
            this.dtpDeadLine = new System.Windows.Forms.DateTimePicker();
            this.cboSubjectName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.dgvMRP = new BedFactory.DatagridviewControl();
            this.pnlDgv.SuspendLayout();
            this.pnlSelect.SuspendLayout();
            this.searchLocationControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMRP)).BeginInit();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(1014, 99);
            this.btn2.Visible = false;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(943, 99);
            this.btn3.Visible = false;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(706, 99);
            this.btn5.Visible = false;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.Text = "자재소요계획";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(1085, 99);
            this.btn1.Visible = false;
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.dgvMRP);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(837, 99);
            this.btn4.Visible = false;
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.searchLocationControl1);
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.Location = new System.Drawing.Point(880, 22);
            this.lblSubjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(51, 19);
            this.lblSubjectName.TabIndex = 8;
            this.lblSubjectName.Text = "품목명";
            // 
            // cboDemandPlan
            // 
            this.cboDemandPlan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboDemandPlan.FormattingEnabled = true;
            this.cboDemandPlan.Location = new System.Drawing.Point(139, 21);
            this.cboDemandPlan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDemandPlan.Name = "cboDemandPlan";
            this.cboDemandPlan.Size = new System.Drawing.Size(236, 27);
            this.cboDemandPlan.TabIndex = 1;
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
            this.searchLocationControl1.Controls.Add(this.lblDemandPlan, 0, 0);
            this.searchLocationControl1.Controls.Add(this.cboDemandPlan, 1, 0);
            this.searchLocationControl1.Controls.Add(this.dtpDeadLine, 4, 0);
            this.searchLocationControl1.Controls.Add(this.cboSubjectName, 7, 0);
            this.searchLocationControl1.Controls.Add(this.label3, 3, 0);
            this.searchLocationControl1.Controls.Add(this.lblSubjectName, 6, 0);
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
            this.lblDemandPlan.Location = new System.Drawing.Point(16, 22);
            this.lblDemandPlan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDemandPlan.Name = "lblDemandPlan";
            this.lblDemandPlan.Size = new System.Drawing.Size(103, 19);
            this.lblDemandPlan.TabIndex = 1;
            this.lblDemandPlan.Text = "수요 계획 번호";
            // 
            // dtpDeadLine
            // 
            this.dtpDeadLine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDeadLine.Location = new System.Drawing.Point(558, 18);
            this.dtpDeadLine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDeadLine.Name = "dtpDeadLine";
            this.dtpDeadLine.Size = new System.Drawing.Size(236, 26);
            this.dtpDeadLine.TabIndex = 11;
            // 
            // cboSubjectName
            // 
            this.cboSubjectName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboSubjectName.FormattingEnabled = true;
            this.cboSubjectName.Location = new System.Drawing.Point(977, 21);
            this.cboSubjectName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSubjectName.Name = "cboSubjectName";
            this.cboSubjectName.Size = new System.Drawing.Size(236, 27);
            this.cboSubjectName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "납기 기한";
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelect.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSelect.Location = new System.Drawing.Point(1271, 16);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(70, 30);
            this.btnSelect.TabIndex = 50;
            this.btnSelect.Text = "조회";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // dgvMRP
            // 
            this.dgvMRP.AllowUserToAddRows = false;
            this.dgvMRP.AllowUserToResizeRows = false;
            this.dgvMRP.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvMRP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMRP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMRP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMRP.Location = new System.Drawing.Point(0, 0);
            this.dgvMRP.Name = "dgvMRP";
            this.dgvMRP.RowHeadersVisible = false;
            this.dgvMRP.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvMRP.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMRP.RowTemplate.Height = 27;
            this.dgvMRP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMRP.Size = new System.Drawing.Size(1358, 711);
            this.dgvMRP.TabIndex = 0;
            // 
            // frmMaterialRequirementPlanning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "frmMaterialRequirementPlanning";
            this.Text = "자재소요계획";
            this.Load += new System.EventHandler(this.frmMaterialRequirementPlanning_Load);
            this.pnlDgv.ResumeLayout(false);
            this.pnlSelect.ResumeLayout(false);
            this.searchLocationControl1.ResumeLayout(false);
            this.searchLocationControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMRP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.ComboBox cboDemandPlan;
        private Controls.SearchLocationControl searchLocationControl1;
        private System.Windows.Forms.Label lblDemandPlan;
        private System.Windows.Forms.Button btnSelect;
        private DatagridviewControl dgvMRP;
        private System.Windows.Forms.DateTimePicker dtpDeadLine;
        private System.Windows.Forms.ComboBox cboSubjectName;
        private System.Windows.Forms.Label label3;
    }
}