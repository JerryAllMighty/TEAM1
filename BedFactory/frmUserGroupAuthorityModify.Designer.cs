
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblGroupNameBinding = new System.Windows.Forms.Label();
            this.lblGroupCodeBinding = new System.Windows.Forms.Label();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.lblGroupCode = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datagridviewControl2 = new BedFactory.DatagridviewControl();
            this.datagridviewControl1 = new BedFactory.DatagridviewControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datagridviewControl1);
            this.panel1.Location = new System.Drawing.Point(30, 301);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 740);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.datagridviewControl2);
            this.panel2.Location = new System.Drawing.Point(581, 301);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1009, 740);
            this.panel2.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1414, 211);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 38);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "저장";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1502, 211);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 38);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblGroupNameBinding);
            this.panel3.Controls.Add(this.lblGroupCodeBinding);
            this.panel3.Controls.Add(this.lblGroupName);
            this.panel3.Controls.Add(this.lblGroupCode);
            this.panel3.Location = new System.Drawing.Point(28, 20);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1560, 153);
            this.panel3.TabIndex = 4;
            // 
            // lblGroupNameBinding
            // 
            this.lblGroupNameBinding.Location = new System.Drawing.Point(960, 60);
            this.lblGroupNameBinding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupNameBinding.Name = "lblGroupNameBinding";
            this.lblGroupNameBinding.Size = new System.Drawing.Size(125, 35);
            this.lblGroupNameBinding.TabIndex = 3;
            this.lblGroupNameBinding.Text = "여기에 그룹명";
            this.lblGroupNameBinding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGroupCodeBinding
            // 
            this.lblGroupCodeBinding.Location = new System.Drawing.Point(419, 51);
            this.lblGroupCodeBinding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupCodeBinding.Name = "lblGroupCodeBinding";
            this.lblGroupCodeBinding.Size = new System.Drawing.Size(125, 35);
            this.lblGroupCodeBinding.TabIndex = 2;
            this.lblGroupCodeBinding.Text = "여기에 그룹코드";
            this.lblGroupCodeBinding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGroupName
            // 
            this.lblGroupName.Location = new System.Drawing.Point(716, 51);
            this.lblGroupName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(125, 35);
            this.lblGroupName.TabIndex = 1;
            this.lblGroupName.Text = "그룹명";
            this.lblGroupName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGroupCode
            // 
            this.lblGroupCode.Location = new System.Drawing.Point(61, 51);
            this.lblGroupCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupCode.Name = "lblGroupCode";
            this.lblGroupCode.Size = new System.Drawing.Size(125, 35);
            this.lblGroupCode.TabIndex = 0;
            this.lblGroupCode.Text = "그룹코드";
            this.lblGroupCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(25, 261);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 35);
            this.label5.TabIndex = 10;
            this.label5.Text = "전체 화면 목록";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(576, 261);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 35);
            this.label6.TabIndex = 11;
            this.label6.Text = "추가할 권한";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // datagridviewControl2
            // 
            this.datagridviewControl2.AllowUserToAddRows = false;
            this.datagridviewControl2.AllowUserToResizeRows = false;
            this.datagridviewControl2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.datagridviewControl2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagridviewControl2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridviewControl2.Location = new System.Drawing.Point(0, 0);
            this.datagridviewControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datagridviewControl2.Name = "datagridviewControl2";
            this.datagridviewControl2.RowHeadersVisible = false;
            this.datagridviewControl2.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.datagridviewControl2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridviewControl2.RowTemplate.Height = 27;
            this.datagridviewControl2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewControl2.Size = new System.Drawing.Size(1009, 740);
            this.datagridviewControl2.TabIndex = 0;
            // 
            // datagridviewControl1
            // 
            this.datagridviewControl1.AllowUserToAddRows = false;
            this.datagridviewControl1.AllowUserToResizeRows = false;
            this.datagridviewControl1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.datagridviewControl1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridviewControl1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridviewControl1.Location = new System.Drawing.Point(0, 0);
            this.datagridviewControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datagridviewControl1.Name = "datagridviewControl1";
            this.datagridviewControl1.RowHeadersVisible = false;
            this.datagridviewControl1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.datagridviewControl1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridviewControl1.RowTemplate.Height = 27;
            this.datagridviewControl1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewControl1.Size = new System.Drawing.Size(544, 740);
            this.datagridviewControl1.TabIndex = 0;
            // 
            // frmUserGroupAuthorityModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1602, 1055);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUserGroupAuthorityModify";
            this.Text = "그룹별 권한 수정";
            this.Load += new System.EventHandler(this.frmUserGroupAuthorityModify_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblGroupCode;
        private System.Windows.Forms.Label lblGroupNameBinding;
        private System.Windows.Forms.Label lblGroupCodeBinding;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DatagridviewControl datagridviewControl1;
        private DatagridviewControl datagridviewControl2;
    }
}