
namespace BedFactory
{
    partial class frmUserGroupAuthorityModify
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvEveryScreen = new BedFactory.DatagridviewControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvAddAuthority = new BedFactory.DatagridviewControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblGroupNameBinding = new System.Windows.Forms.Label();
            this.lblGroupCodeBinding = new System.Windows.Forms.Label();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.lblGroupCode = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlDgv.SuspendLayout();
            this.pnlSelect.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEveryScreen)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddAuthority)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(1234, 149);
            this.btn2.Visible = false;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(1163, 149);
            this.btn3.Visible = false;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(926, 149);
            this.btn5.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 138);
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.Text = "전체 화면 목록";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(1305, 149);
            this.btn1.Text = "저장";
            this.btn1.Click += new System.EventHandler(this.btn1_Click_1);
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.panel1);
            this.pnlDgv.Controls.Add(this.panel2);
            this.pnlDgv.Location = new System.Drawing.Point(12, 177);
            this.pnlDgv.Size = new System.Drawing.Size(1358, 664);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(1057, 149);
            this.btn4.Visible = false;
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.panel3);
            this.pnlSelect.Location = new System.Drawing.Point(19, 12);
            this.pnlSelect.Size = new System.Drawing.Size(1358, 67);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvEveryScreen);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 856);
            this.panel1.TabIndex = 0;
            // 
            // dgvEveryScreen
            // 
            this.dgvEveryScreen.AllowUserToAddRows = false;
            this.dgvEveryScreen.AllowUserToResizeRows = false;
            this.dgvEveryScreen.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvEveryScreen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEveryScreen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEveryScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEveryScreen.Location = new System.Drawing.Point(0, 0);
            this.dgvEveryScreen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvEveryScreen.Name = "dgvEveryScreen";
            this.dgvEveryScreen.RowHeadersVisible = false;
            this.dgvEveryScreen.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvEveryScreen.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEveryScreen.RowTemplate.Height = 27;
            this.dgvEveryScreen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEveryScreen.Size = new System.Drawing.Size(578, 856);
            this.dgvEveryScreen.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvAddAuthority);
            this.panel2.Location = new System.Drawing.Point(590, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1009, 856);
            this.panel2.TabIndex = 1;
            // 
            // dgvAddAuthority
            // 
            this.dgvAddAuthority.AllowUserToAddRows = false;
            this.dgvAddAuthority.AllowUserToResizeRows = false;
            this.dgvAddAuthority.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvAddAuthority.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAddAuthority.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddAuthority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAddAuthority.Location = new System.Drawing.Point(0, 0);
            this.dgvAddAuthority.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAddAuthority.Name = "dgvAddAuthority";
            this.dgvAddAuthority.RowHeadersVisible = false;
            this.dgvAddAuthority.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvAddAuthority.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAddAuthority.RowTemplate.Height = 27;
            this.dgvAddAuthority.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddAuthority.Size = new System.Drawing.Size(1009, 856);
            this.dgvAddAuthority.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblGroupNameBinding);
            this.panel3.Controls.Add(this.lblGroupCodeBinding);
            this.panel3.Controls.Add(this.lblGroupName);
            this.panel3.Controls.Add(this.lblGroupCode);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1356, 65);
            this.panel3.TabIndex = 4;
            // 
            // lblGroupNameBinding
            // 
            this.lblGroupNameBinding.Location = new System.Drawing.Point(953, 27);
            this.lblGroupNameBinding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupNameBinding.Name = "lblGroupNameBinding";
            this.lblGroupNameBinding.Size = new System.Drawing.Size(125, 35);
            this.lblGroupNameBinding.TabIndex = 3;
            this.lblGroupNameBinding.Text = "여기에 그룹명";
            this.lblGroupNameBinding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGroupCodeBinding
            // 
            this.lblGroupCodeBinding.Location = new System.Drawing.Point(355, 27);
            this.lblGroupCodeBinding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupCodeBinding.Name = "lblGroupCodeBinding";
            this.lblGroupCodeBinding.Size = new System.Drawing.Size(125, 35);
            this.lblGroupCodeBinding.TabIndex = 2;
            this.lblGroupCodeBinding.Text = "여기에 그룹코드";
            this.lblGroupCodeBinding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGroupName
            // 
            this.lblGroupName.Location = new System.Drawing.Point(654, 27);
            this.lblGroupName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(125, 35);
            this.lblGroupName.TabIndex = 1;
            this.lblGroupName.Text = "그룹명";
            this.lblGroupName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGroupCode
            // 
            this.lblGroupCode.Location = new System.Drawing.Point(56, 27);
            this.lblGroupCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupCode.Name = "lblGroupCode";
            this.lblGroupCode.Size = new System.Drawing.Size(125, 35);
            this.lblGroupCode.TabIndex = 0;
            this.lblGroupCode.Text = "그룹코드";
            this.lblGroupCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(597, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 35);
            this.label6.TabIndex = 11;
            this.label6.Text = "추가할 권한";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmUserGroupAuthorityModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Controls.Add(this.label6);
            this.Name = "frmUserGroupAuthorityModify";
            this.Text = "그룹별 권한 수정";
            this.Load += new System.EventHandler(this.frmUserGroupAuthorityModify_Load);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.pnlSelect, 0);
            this.Controls.SetChildIndex(this.btn4, 0);
            this.Controls.SetChildIndex(this.pnlDgv, 0);
            this.Controls.SetChildIndex(this.btn1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btn5, 0);
            this.Controls.SetChildIndex(this.btn3, 0);
            this.Controls.SetChildIndex(this.btn2, 0);
            this.pnlDgv.ResumeLayout(false);
            this.pnlSelect.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEveryScreen)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddAuthority)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblGroupCode;
        private System.Windows.Forms.Label lblGroupNameBinding;
        private System.Windows.Forms.Label lblGroupCodeBinding;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.Label label6;
        private DatagridviewControl dgvEveryScreen;
        private DatagridviewControl dgvAddAuthority;
    }
}