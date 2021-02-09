
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
            this.pnlGroupList = new System.Windows.Forms.Panel();
            this.dgvGroupList = new BedFactory.DatagridviewControl();
            this.lblGroupModify = new System.Windows.Forms.Label();
            this.pnlGroupModify = new System.Windows.Forms.Panel();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.txtGroupCode = new System.Windows.Forms.TextBox();
            this.lblGroupCode = new System.Windows.Forms.Label();
            this.lblAddGroup = new System.Windows.Forms.Label();
            this.txtGroupName2 = new System.Windows.Forms.TextBox();
            this.lblGroupName2 = new System.Windows.Forms.Label();
            this.txtGroupCode2 = new System.Windows.Forms.TextBox();
            this.lblGroupCode2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDgv.SuspendLayout();
            this.pnlGroupList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupList)).BeginInit();
            this.pnlGroupModify.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.btn3.Location = new System.Drawing.Point(967, 100);
            this.btn3.Visible = false;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(707, 99);
            this.btn5.Visible = false;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.Text = "그룹 목록";
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
            this.pnlDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlDgv.Controls.Add(this.panel1);
            this.pnlDgv.Controls.Add(this.pnlGroupModify);
            this.pnlDgv.Controls.Add(this.pnlGroupList);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(838, 99);
            this.btn4.Visible = false;
            // 
            // pnlSelect
            // 
            this.pnlSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSelect.Visible = false;
            // 
            // pnlGroupList
            // 
            this.pnlGroupList.Controls.Add(this.dgvGroupList);
            this.pnlGroupList.Location = new System.Drawing.Point(4, 5);
            this.pnlGroupList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlGroupList.Name = "pnlGroupList";
            this.pnlGroupList.Size = new System.Drawing.Size(477, 701);
            this.pnlGroupList.TabIndex = 2;
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
            this.dgvGroupList.Size = new System.Drawing.Size(477, 701);
            this.dgvGroupList.TabIndex = 0;
            this.dgvGroupList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroupList_CellDoubleClick);
            // 
            // lblGroupModify
            // 
            this.lblGroupModify.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblGroupModify.Location = new System.Drawing.Point(496, 89);
            this.lblGroupModify.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGroupModify.Name = "lblGroupModify";
            this.lblGroupModify.Size = new System.Drawing.Size(240, 43);
            this.lblGroupModify.TabIndex = 17;
            this.lblGroupModify.Text = "그룹 수정";
            this.lblGroupModify.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlGroupModify
            // 
            this.pnlGroupModify.Controls.Add(this.txtGroupName);
            this.pnlGroupModify.Controls.Add(this.lblGroupName);
            this.pnlGroupModify.Controls.Add(this.txtGroupCode);
            this.pnlGroupModify.Controls.Add(this.lblGroupCode);
            this.pnlGroupModify.Location = new System.Drawing.Point(489, 7);
            this.pnlGroupModify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlGroupModify.Name = "pnlGroupModify";
            this.pnlGroupModify.Size = new System.Drawing.Size(437, 699);
            this.pnlGroupModify.TabIndex = 3;
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
            // lblAddGroup
            // 
            this.lblAddGroup.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAddGroup.Location = new System.Drawing.Point(940, 92);
            this.lblAddGroup.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAddGroup.Name = "lblAddGroup";
            this.lblAddGroup.Size = new System.Drawing.Size(110, 36);
            this.lblAddGroup.TabIndex = 18;
            this.lblAddGroup.Text = "그룹 추가";
            this.lblAddGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGroupName2
            // 
            this.txtGroupName2.Location = new System.Drawing.Point(163, 243);
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
            this.lblGroupName2.Location = new System.Drawing.Point(27, 244);
            this.lblGroupName2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupName2.Name = "lblGroupName2";
            this.lblGroupName2.Size = new System.Drawing.Size(78, 25);
            this.lblGroupName2.TabIndex = 7;
            this.lblGroupName2.Text = "*그룹명";
            // 
            // txtGroupCode2
            // 
            this.txtGroupCode2.Location = new System.Drawing.Point(163, 162);
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
            this.lblGroupCode2.Location = new System.Drawing.Point(27, 167);
            this.lblGroupCode2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupCode2.Name = "lblGroupCode2";
            this.lblGroupCode2.Size = new System.Drawing.Size(97, 25);
            this.lblGroupCode2.TabIndex = 5;
            this.lblGroupCode2.Text = "*그룹코드";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtGroupName2);
            this.panel1.Controls.Add(this.txtGroupCode2);
            this.panel1.Controls.Add(this.lblGroupName2);
            this.panel1.Controls.Add(this.lblGroupCode2);
            this.panel1.Location = new System.Drawing.Point(933, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 699);
            this.panel1.TabIndex = 4;
            // 
            // frmGroupManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Controls.Add(this.lblAddGroup);
            this.Controls.Add(this.lblGroupModify);
            this.Name = "frmGroupManagement";
            this.Text = "그룹 관리";
            this.Load += new System.EventHandler(this.frmGroupManagement2_Load);
            this.Controls.SetChildIndex(this.pnlSelect, 0);
            this.Controls.SetChildIndex(this.btn4, 0);
            this.Controls.SetChildIndex(this.btn1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btn5, 0);
            this.Controls.SetChildIndex(this.btn3, 0);
            this.Controls.SetChildIndex(this.btn2, 0);
            this.Controls.SetChildIndex(this.lblGroupModify, 0);
            this.Controls.SetChildIndex(this.lblAddGroup, 0);
            this.Controls.SetChildIndex(this.pnlDgv, 0);
            this.pnlDgv.ResumeLayout(false);
            this.pnlGroupList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupList)).EndInit();
            this.pnlGroupModify.ResumeLayout(false);
            this.pnlGroupModify.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGroupList;
        private DatagridviewControl dgvGroupList;
        private System.Windows.Forms.Label lblGroupModify;
        private System.Windows.Forms.Panel pnlGroupModify;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.TextBox txtGroupCode;
        private System.Windows.Forms.Label lblGroupCode;
        private System.Windows.Forms.Label lblAddGroup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtGroupName2;
        private System.Windows.Forms.TextBox txtGroupCode2;
        private System.Windows.Forms.Label lblGroupName2;
        private System.Windows.Forms.Label lblGroupCode2;
    }
}
