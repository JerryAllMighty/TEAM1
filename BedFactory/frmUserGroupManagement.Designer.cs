
namespace BedFactory
{
    partial class frmUserGroupManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.lblUserGroupList = new System.Windows.Forms.Label();
            this.lblGroupEmpList = new System.Windows.Forms.Label();
            this.lblUserList = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvUserList = new BedFactory.DatagridviewControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvUserGroupList = new BedFactory.DatagridviewControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvGroupEmpList = new BedFactory.DatagridviewControl();
            this.searchLocationControl1 = new BedFactory.Controls.SearchLocationControl();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pnlDgv.SuspendLayout();
            this.pnlSelect.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserGroupList)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupEmpList)).BeginInit();
            this.searchLocationControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Visible = false;
            // 
            // btn1
            // 
            this.btn1.Text = "저장";
            this.btn1.Click += new System.EventHandler(this.btn1_Click_1);
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.lblUserGroupList);
            this.pnlDgv.Controls.Add(this.lblUserList);
            this.pnlDgv.Controls.Add(this.lblGroupEmpList);
            this.pnlDgv.Size = new System.Drawing.Size(1458, 704);
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.searchLocationControl1);
            this.pnlSelect.Size = new System.Drawing.Size(1358, 58);
            // 
            // txtEmpName
            // 
            this.txtEmpName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmpName.Location = new System.Drawing.Point(139, 13);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(236, 30);
            this.txtEmpName.TabIndex = 1;
            // 
            // lblUserGroupList
            // 
            this.lblUserGroupList.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUserGroupList.Location = new System.Drawing.Point(415, 47);
            this.lblUserGroupList.Name = "lblUserGroupList";
            this.lblUserGroupList.Size = new System.Drawing.Size(182, 23);
            this.lblUserGroupList.TabIndex = 8;
            this.lblUserGroupList.Text = "사용자 그룹 목록";
            this.lblUserGroupList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGroupEmpList
            // 
            this.lblGroupEmpList.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblGroupEmpList.Location = new System.Drawing.Point(847, 47);
            this.lblGroupEmpList.Name = "lblGroupEmpList";
            this.lblGroupEmpList.Size = new System.Drawing.Size(185, 23);
            this.lblGroupEmpList.TabIndex = 9;
            this.lblGroupEmpList.Text = "그룹별 직원 리스트";
            this.lblGroupEmpList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserList
            // 
            this.lblUserList.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUserList.Location = new System.Drawing.Point(4, 47);
            this.lblUserList.Name = "lblUserList";
            this.lblUserList.Size = new System.Drawing.Size(132, 23);
            this.lblUserList.TabIndex = 7;
            this.lblUserList.Text = "사용자목록";
            this.lblUserList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvUserList);
            this.panel2.Location = new System.Drawing.Point(17, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 573);
            this.panel2.TabIndex = 11;
            // 
            // dgvUserList
            // 
            this.dgvUserList.AllowUserToAddRows = false;
            this.dgvUserList.AllowUserToResizeRows = false;
            this.dgvUserList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvUserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserList.Location = new System.Drawing.Point(0, 0);
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.RowHeadersVisible = false;
            this.dgvUserList.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvUserList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUserList.RowTemplate.Height = 27;
            this.dgvUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserList.Size = new System.Drawing.Size(408, 573);
            this.dgvUserList.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvUserGroupList);
            this.panel3.Location = new System.Drawing.Point(432, 235);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 573);
            this.panel3.TabIndex = 12;
            // 
            // dgvUserGroupList
            // 
            this.dgvUserGroupList.AllowUserToAddRows = false;
            this.dgvUserGroupList.AllowUserToResizeRows = false;
            this.dgvUserGroupList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvUserGroupList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUserGroupList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserGroupList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserGroupList.Location = new System.Drawing.Point(0, 0);
            this.dgvUserGroupList.Name = "dgvUserGroupList";
            this.dgvUserGroupList.RowHeadersVisible = false;
            this.dgvUserGroupList.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvUserGroupList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUserGroupList.RowTemplate.Height = 27;
            this.dgvUserGroupList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserGroupList.Size = new System.Drawing.Size(425, 573);
            this.dgvUserGroupList.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvGroupEmpList);
            this.panel4.Location = new System.Drawing.Point(864, 235);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(405, 573);
            this.panel4.TabIndex = 12;
            // 
            // dgvGroupEmpList
            // 
            this.dgvGroupEmpList.AllowUserToAddRows = false;
            this.dgvGroupEmpList.AllowUserToResizeRows = false;
            this.dgvGroupEmpList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvGroupEmpList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGroupEmpList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupEmpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGroupEmpList.Location = new System.Drawing.Point(0, 0);
            this.dgvGroupEmpList.Name = "dgvGroupEmpList";
            this.dgvGroupEmpList.RowHeadersVisible = false;
            this.dgvGroupEmpList.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvGroupEmpList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvGroupEmpList.RowTemplate.Height = 27;
            this.dgvGroupEmpList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroupEmpList.Size = new System.Drawing.Size(405, 573);
            this.dgvGroupEmpList.TabIndex = 0;
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
            this.searchLocationControl1.Controls.Add(this.lblEmployeeName, 0, 0);
            this.searchLocationControl1.Controls.Add(this.txtEmpName, 1, 0);
            this.searchLocationControl1.Controls.Add(this.btnSelect, 9, 0);
            this.searchLocationControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchLocationControl1.Location = new System.Drawing.Point(0, 0);
            this.searchLocationControl1.Name = "searchLocationControl1";
            this.searchLocationControl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchLocationControl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchLocationControl1.Size = new System.Drawing.Size(1356, 56);
            this.searchLocationControl1.TabIndex = 0;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.Location = new System.Drawing.Point(4, 0);
            this.lblEmployeeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(127, 56);
            this.lblEmployeeName.TabIndex = 1;
            this.lblEmployeeName.Text = "직원명";
            this.lblEmployeeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelect.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSelect.Location = new System.Drawing.Point(1271, 13);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(70, 30);
            this.btnSelect.TabIndex = 49;
            this.btnSelect.Text = "조회";
            this.btnSelect.UseVisualStyleBackColor = false;
            // 
            // frmUserGroupManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "frmUserGroupManagement";
            this.Text = "사용자 그룹 관리";
            this.Load += new System.EventHandler(this.frmUserGroupManagement_Load);
            this.Controls.SetChildIndex(this.pnlDgv, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.pnlSelect, 0);
            this.Controls.SetChildIndex(this.btn4, 0);
            this.Controls.SetChildIndex(this.btn1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btn5, 0);
            this.Controls.SetChildIndex(this.btn3, 0);
            this.Controls.SetChildIndex(this.btn2, 0);
            this.pnlDgv.ResumeLayout(false);
            this.pnlSelect.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserGroupList)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupEmpList)).EndInit();
            this.searchLocationControl1.ResumeLayout(false);
            this.searchLocationControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label lblUserGroupList;
        private System.Windows.Forms.Label lblGroupEmpList;
        private System.Windows.Forms.Label lblUserList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Controls.SearchLocationControl searchLocationControl1;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Button btnSelect;
        private DatagridviewControl dgvUserList;
        private DatagridviewControl dgvUserGroupList;
        private DatagridviewControl dgvGroupEmpList;
    }
}