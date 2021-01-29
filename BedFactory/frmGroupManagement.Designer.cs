
namespace BedFactory
{
    partial class frmGroupManagement
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
            this.pnlGroupList = new System.Windows.Forms.Panel();
            this.pnlAddGroup = new System.Windows.Forms.Panel();
            this.txtGroupName2 = new System.Windows.Forms.TextBox();
            this.lblGroupName2 = new System.Windows.Forms.Label();
            this.txtGroupCode2 = new System.Windows.Forms.TextBox();
            this.lblGroupCode2 = new System.Windows.Forms.Label();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.lblGroupList = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.pnlGroupModify = new System.Windows.Forms.Panel();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.txtGroupCode = new System.Windows.Forms.TextBox();
            this.lblGroupCode = new System.Windows.Forms.Label();
            this.lblGroupModify = new System.Windows.Forms.Label();
            this.lblAddGroup = new System.Windows.Forms.Label();
            this.dgvGroupList = new BedFactory.DatagridviewControl();
            this.pnlGroupList.SuspendLayout();
            this.pnlAddGroup.SuspendLayout();
            this.pnlGroupModify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGroupList
            // 
            this.pnlGroupList.Controls.Add(this.dgvGroupList);
            this.pnlGroupList.Location = new System.Drawing.Point(15, 77);
            this.pnlGroupList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlGroupList.Name = "pnlGroupList";
            this.pnlGroupList.Size = new System.Drawing.Size(477, 964);
            this.pnlGroupList.TabIndex = 1;
            // 
            // pnlAddGroup
            // 
            this.pnlAddGroup.Controls.Add(this.txtGroupName2);
            this.pnlAddGroup.Controls.Add(this.lblGroupName2);
            this.pnlAddGroup.Controls.Add(this.txtGroupCode2);
            this.pnlAddGroup.Controls.Add(this.lblGroupCode2);
            this.pnlAddGroup.Controls.Add(this.btnAddGroup);
            this.pnlAddGroup.Location = new System.Drawing.Point(990, 77);
            this.pnlAddGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAddGroup.Name = "pnlAddGroup";
            this.pnlAddGroup.Size = new System.Drawing.Size(599, 964);
            this.pnlAddGroup.TabIndex = 2;
            // 
            // txtGroupName2
            // 
            this.txtGroupName2.Location = new System.Drawing.Point(264, 238);
            this.txtGroupName2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGroupName2.Name = "txtGroupName2";
            this.txtGroupName2.Size = new System.Drawing.Size(235, 30);
            this.txtGroupName2.TabIndex = 8;
            this.txtGroupName2.TextChanged += new System.EventHandler(this.txtGroupName2_TextChanged);
            // 
            // lblGroupName2
            // 
            this.lblGroupName2.AutoSize = true;
            this.lblGroupName2.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblGroupName2.ForeColor = System.Drawing.Color.Red;
            this.lblGroupName2.Location = new System.Drawing.Point(128, 239);
            this.lblGroupName2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupName2.Name = "lblGroupName2";
            this.lblGroupName2.Size = new System.Drawing.Size(78, 25);
            this.lblGroupName2.TabIndex = 7;
            this.lblGroupName2.Text = "*그룹명";
            // 
            // txtGroupCode2
            // 
            this.txtGroupCode2.Location = new System.Drawing.Point(264, 157);
            this.txtGroupCode2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGroupCode2.Name = "txtGroupCode2";
            this.txtGroupCode2.Size = new System.Drawing.Size(235, 30);
            this.txtGroupCode2.TabIndex = 6;
            this.txtGroupCode2.TextChanged += new System.EventHandler(this.txtGroupCode2_TextChanged);
            // 
            // lblGroupCode2
            // 
            this.lblGroupCode2.AutoSize = true;
            this.lblGroupCode2.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblGroupCode2.ForeColor = System.Drawing.Color.Red;
            this.lblGroupCode2.Location = new System.Drawing.Point(128, 162);
            this.lblGroupCode2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupCode2.Name = "lblGroupCode2";
            this.lblGroupCode2.Size = new System.Drawing.Size(97, 25);
            this.lblGroupCode2.TabIndex = 5;
            this.lblGroupCode2.Text = "*그룹코드";
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Location = new System.Drawing.Point(379, 381);
            this.btnAddGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(120, 50);
            this.btnAddGroup.TabIndex = 0;
            this.btnAddGroup.Text = "그룹 추가";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // lblGroupList
            // 
            this.lblGroupList.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblGroupList.Location = new System.Drawing.Point(16, 18);
            this.lblGroupList.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGroupList.Name = "lblGroupList";
            this.lblGroupList.Size = new System.Drawing.Size(240, 54);
            this.lblGroupList.TabIndex = 11;
            this.lblGroupList.Text = "그룹 목록";
            this.lblGroupList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(299, 381);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(120, 50);
            this.btnModify.TabIndex = 0;
            this.btnModify.Text = "수정";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // pnlGroupModify
            // 
            this.pnlGroupModify.Controls.Add(this.txtGroupName);
            this.pnlGroupModify.Controls.Add(this.lblGroupName);
            this.pnlGroupModify.Controls.Add(this.txtGroupCode);
            this.pnlGroupModify.Controls.Add(this.lblGroupCode);
            this.pnlGroupModify.Controls.Add(this.btnModify);
            this.pnlGroupModify.Location = new System.Drawing.Point(500, 77);
            this.pnlGroupModify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlGroupModify.Name = "pnlGroupModify";
            this.pnlGroupModify.Size = new System.Drawing.Size(482, 964);
            this.pnlGroupModify.TabIndex = 2;
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(184, 243);
            this.txtGroupName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(235, 30);
            this.txtGroupName.TabIndex = 4;
            this.txtGroupName.TextChanged += new System.EventHandler(this.txtGroupName_TextChanged);
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblGroupName.Location = new System.Drawing.Point(48, 244);
            this.lblGroupName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(69, 25);
            this.lblGroupName.TabIndex = 3;
            this.lblGroupName.Text = "그룹명";
            // 
            // txtGroupCode
            // 
            this.txtGroupCode.Location = new System.Drawing.Point(184, 162);
            this.txtGroupCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGroupCode.Name = "txtGroupCode";
            this.txtGroupCode.Size = new System.Drawing.Size(235, 30);
            this.txtGroupCode.TabIndex = 2;
            this.txtGroupCode.TextChanged += new System.EventHandler(this.txtGroupCode_TextChanged);
            // 
            // lblGroupCode
            // 
            this.lblGroupCode.AutoSize = true;
            this.lblGroupCode.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblGroupCode.Location = new System.Drawing.Point(48, 167);
            this.lblGroupCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupCode.Name = "lblGroupCode";
            this.lblGroupCode.Size = new System.Drawing.Size(88, 25);
            this.lblGroupCode.TabIndex = 1;
            this.lblGroupCode.Text = "그룹코드";
            // 
            // lblGroupModify
            // 
            this.lblGroupModify.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblGroupModify.Location = new System.Drawing.Point(495, 18);
            this.lblGroupModify.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGroupModify.Name = "lblGroupModify";
            this.lblGroupModify.Size = new System.Drawing.Size(240, 54);
            this.lblGroupModify.TabIndex = 12;
            this.lblGroupModify.Text = "그룹 수정";
            this.lblGroupModify.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddGroup
            // 
            this.lblAddGroup.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAddGroup.Location = new System.Drawing.Point(985, 9);
            this.lblAddGroup.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAddGroup.Name = "lblAddGroup";
            this.lblAddGroup.Size = new System.Drawing.Size(240, 54);
            this.lblAddGroup.TabIndex = 13;
            this.lblAddGroup.Text = "그룹 추가";
            this.lblAddGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvGroupList
            // 
            this.dgvGroupList.AllowUserToAddRows = false;
            this.dgvGroupList.AllowUserToResizeRows = false;
            this.dgvGroupList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvGroupList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGroupList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGroupList.Location = new System.Drawing.Point(0, 0);
            this.dgvGroupList.Name = "dgvGroupList";
            this.dgvGroupList.RowHeadersVisible = false;
            this.dgvGroupList.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvGroupList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGroupList.RowTemplate.Height = 27;
            this.dgvGroupList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroupList.Size = new System.Drawing.Size(477, 964);
            this.dgvGroupList.TabIndex = 0;
            this.dgvGroupList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroupList_CellDoubleClick);
            // 
            // frmGroupManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1602, 1055);
            this.Controls.Add(this.lblAddGroup);
            this.Controls.Add(this.pnlAddGroup);
            this.Controls.Add(this.lblGroupModify);
            this.Controls.Add(this.lblGroupList);
            this.Controls.Add(this.pnlGroupModify);
            this.Controls.Add(this.pnlGroupList);
            this.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGroupManagement";
            this.Text = "그룹관리";
            this.Load += new System.EventHandler(this.frmGroupManagement_Load);
            this.pnlGroupList.ResumeLayout(false);
            this.pnlAddGroup.ResumeLayout(false);
            this.pnlAddGroup.PerformLayout();
            this.pnlGroupModify.ResumeLayout(false);
            this.pnlGroupModify.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGroupList;
        private System.Windows.Forms.Panel pnlAddGroup;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.Label lblGroupList;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Panel pnlGroupModify;
        private System.Windows.Forms.Label lblGroupModify;
        private System.Windows.Forms.TextBox txtGroupCode;
        private System.Windows.Forms.Label lblGroupCode;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.TextBox txtGroupName2;
        private System.Windows.Forms.Label lblGroupName2;
        private System.Windows.Forms.TextBox txtGroupCode2;
        private System.Windows.Forms.Label lblGroupCode2;
        private System.Windows.Forms.Label lblAddGroup;
        private DatagridviewControl dgvGroupList;
    }
}