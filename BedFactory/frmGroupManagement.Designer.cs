
namespace BedFactory
{
    partial class frmGroupManagement
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblGroupModify = new System.Windows.Forms.Label();
            this.lblAddGroup = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.txtGroupCode = new System.Windows.Forms.TextBox();
            this.lblGroupCode = new System.Windows.Forms.Label();
            this.txtGroupName2 = new System.Windows.Forms.TextBox();
            this.txtGroupCode2 = new System.Windows.Forms.TextBox();
            this.lblGroupName2 = new System.Windows.Forms.Label();
            this.lblGroupCode2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlGroupList = new System.Windows.Forms.Panel();
            this.dgvGroupList = new BedFactory.DatagridviewControl();
            this.pnlDgv.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlGroupList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(1164, 99);
            this.btn2.Size = new System.Drawing.Size(100, 25);
            this.btn2.Text = "그룹 수정";
            this.btn2.Click += new System.EventHandler(this.btn2_Click_1);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(1093, 99);
            this.btn3.Visible = false;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(856, 99);
            this.btn5.Visible = false;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.Text = "그룹 목록";
            this.label1.Visible = false;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(1270, 100);
            this.btn1.Size = new System.Drawing.Size(100, 25);
            this.btn1.Text = "그룹 추가";
            this.btn1.Click += new System.EventHandler(this.btn1_Click_1);
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.tableLayoutPanel2);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(987, 99);
            this.btn4.Visible = false;
            // 
            // pnlSelect
            // 
            this.pnlSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSelect.Visible = false;
            // 
            // lblGroupModify
            // 
            this.lblGroupModify.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGroupModify.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblGroupModify.Location = new System.Drawing.Point(36, 104);
            this.lblGroupModify.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGroupModify.Name = "lblGroupModify";
            this.lblGroupModify.Size = new System.Drawing.Size(95, 25);
            this.lblGroupModify.TabIndex = 17;
            this.lblGroupModify.Text = "그룹 수정";
            this.lblGroupModify.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddGroup
            // 
            this.lblAddGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddGroup.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAddGroup.Location = new System.Drawing.Point(372, 104);
            this.lblAddGroup.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAddGroup.Name = "lblAddGroup";
            this.lblAddGroup.Size = new System.Drawing.Size(95, 25);
            this.lblAddGroup.TabIndex = 18;
            this.lblAddGroup.Text = "그룹 추가";
            this.lblAddGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGroupName
            // 
            this.txtGroupName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGroupName.Location = new System.Drawing.Point(172, 572);
            this.txtGroupName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(160, 30);
            this.txtGroupName.TabIndex = 8;
            // 
            // lblGroupName
            // 
            this.lblGroupName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblGroupName.Location = new System.Drawing.Point(49, 575);
            this.lblGroupName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(69, 25);
            this.lblGroupName.TabIndex = 7;
            this.lblGroupName.Text = "그룹명";
            // 
            // txtGroupCode
            // 
            this.txtGroupCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGroupCode.Location = new System.Drawing.Point(172, 337);
            this.txtGroupCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGroupCode.Name = "txtGroupCode";
            this.txtGroupCode.Size = new System.Drawing.Size(160, 30);
            this.txtGroupCode.TabIndex = 6;
            // 
            // lblGroupCode
            // 
            this.lblGroupCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGroupCode.AutoSize = true;
            this.lblGroupCode.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblGroupCode.Location = new System.Drawing.Point(40, 340);
            this.lblGroupCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupCode.Name = "lblGroupCode";
            this.lblGroupCode.Size = new System.Drawing.Size(88, 25);
            this.lblGroupCode.TabIndex = 5;
            this.lblGroupCode.Text = "그룹코드";
            // 
            // txtGroupName2
            // 
            this.txtGroupName2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGroupName2.Location = new System.Drawing.Point(508, 572);
            this.txtGroupName2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGroupName2.Name = "txtGroupName2";
            this.txtGroupName2.Size = new System.Drawing.Size(161, 30);
            this.txtGroupName2.TabIndex = 12;
            // 
            // txtGroupCode2
            // 
            this.txtGroupCode2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGroupCode2.Location = new System.Drawing.Point(508, 337);
            this.txtGroupCode2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGroupCode2.Name = "txtGroupCode2";
            this.txtGroupCode2.Size = new System.Drawing.Size(161, 30);
            this.txtGroupCode2.TabIndex = 10;
            // 
            // lblGroupName2
            // 
            this.lblGroupName2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGroupName2.AutoSize = true;
            this.lblGroupName2.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblGroupName2.ForeColor = System.Drawing.Color.Red;
            this.lblGroupName2.Location = new System.Drawing.Point(381, 575);
            this.lblGroupName2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupName2.Name = "lblGroupName2";
            this.lblGroupName2.Size = new System.Drawing.Size(78, 25);
            this.lblGroupName2.TabIndex = 11;
            this.lblGroupName2.Text = "*그룹명";
            // 
            // lblGroupCode2
            // 
            this.lblGroupCode2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGroupCode2.AutoSize = true;
            this.lblGroupCode2.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblGroupCode2.ForeColor = System.Drawing.Color.Red;
            this.lblGroupCode2.Location = new System.Drawing.Point(371, 340);
            this.lblGroupCode2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupCode2.Name = "lblGroupCode2";
            this.lblGroupCode2.Size = new System.Drawing.Size(97, 25);
            this.lblGroupCode2.TabIndex = 9;
            this.lblGroupCode2.Text = "*그룹코드";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lblAddGroup, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtGroupName2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblGroupCode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtGroupCode2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblGroupName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtGroupName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblGroupName2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtGroupCode, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblGroupCode2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblGroupModify, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(682, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(673, 705);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pnlGroupList, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 711F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1358, 711);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // pnlGroupList
            // 
            this.pnlGroupList.Controls.Add(this.dgvGroupList);
            this.pnlGroupList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGroupList.Location = new System.Drawing.Point(4, 5);
            this.pnlGroupList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlGroupList.Name = "pnlGroupList";
            this.pnlGroupList.Size = new System.Drawing.Size(671, 701);
            this.pnlGroupList.TabIndex = 21;
            // 
            // dgvGroupList
            // 
            this.dgvGroupList.AllowUserToAddRows = false;
            this.dgvGroupList.AllowUserToResizeRows = false;
            this.dgvGroupList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvGroupList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGroupList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGroupList.Location = new System.Drawing.Point(0, 0);
            this.dgvGroupList.Name = "dgvGroupList";
            this.dgvGroupList.RowHeadersVisible = false;
            this.dgvGroupList.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvGroupList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGroupList.RowTemplate.Height = 27;
            this.dgvGroupList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroupList.Size = new System.Drawing.Size(671, 701);
            this.dgvGroupList.TabIndex = 0;
            // 
            // frmGroupManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Name = "frmGroupManagement";
            this.Text = "그룹 관리";
            this.Load += new System.EventHandler(this.frmGroupManagement2_Load);
            this.pnlDgv.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlGroupList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGroupModify;
        private System.Windows.Forms.Label lblAddGroup;
        private System.Windows.Forms.TextBox txtGroupName2;
        private System.Windows.Forms.TextBox txtGroupCode2;
        private System.Windows.Forms.Label lblGroupName2;
        private System.Windows.Forms.Label lblGroupCode2;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.TextBox txtGroupCode;
        private System.Windows.Forms.Label lblGroupCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlGroupList;
        private DatagridviewControl dgvGroupList;
    }
}
