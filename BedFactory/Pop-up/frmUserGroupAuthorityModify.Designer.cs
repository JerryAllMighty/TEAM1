
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblGroupNameBinding = new System.Windows.Forms.Label();
            this.lblGroupCodeBinding = new System.Windows.Forms.Label();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.lblGroupCode = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvAddAuthority = new BedFactory.DatagridviewControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvEveryScreen = new BedFactory.DatagridviewControl();
            this.pnlDgv.SuspendLayout();
            this.pnlSelect.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddAuthority)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEveryScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn2.Location = new System.Drawing.Point(565, 131);
            this.btn2.Visible = false;
            // 
            // btn3
            // 
            this.btn3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn3.Location = new System.Drawing.Point(494, 131);
            this.btn3.Visible = false;
            // 
            // btn5
            // 
            this.btn5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn5.Location = new System.Drawing.Point(388, 99);
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
            this.btn1.Location = new System.Drawing.Point(1207, 140);
            this.btn1.Text = "저장";
            this.btn1.Click += new System.EventHandler(this.btn1_Click_1);
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.tableLayoutPanel1);
            this.pnlDgv.Location = new System.Drawing.Point(12, 177);
            this.pnlDgv.Size = new System.Drawing.Size(1261, 664);
            // 
            // btn4
            // 
            this.btn4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn4.Location = new System.Drawing.Point(388, 130);
            this.btn4.Visible = false;
            // 
            // pnlSelect
            // 
            this.pnlSelect.Controls.Add(this.panel3);
            this.pnlSelect.Location = new System.Drawing.Point(19, 12);
            this.pnlSelect.Size = new System.Drawing.Size(1254, 67);
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
            this.panel3.Size = new System.Drawing.Size(1252, 65);
            this.panel3.TabIndex = 4;
            // 
            // lblGroupNameBinding
            // 
            this.lblGroupNameBinding.Location = new System.Drawing.Point(760, 16);
            this.lblGroupNameBinding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupNameBinding.Name = "lblGroupNameBinding";
            this.lblGroupNameBinding.Size = new System.Drawing.Size(125, 35);
            this.lblGroupNameBinding.TabIndex = 3;
            this.lblGroupNameBinding.Text = "여기에 그룹명";
            this.lblGroupNameBinding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGroupCodeBinding
            // 
            this.lblGroupCodeBinding.Location = new System.Drawing.Point(258, 16);
            this.lblGroupCodeBinding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupCodeBinding.Name = "lblGroupCodeBinding";
            this.lblGroupCodeBinding.Size = new System.Drawing.Size(137, 35);
            this.lblGroupCodeBinding.TabIndex = 2;
            this.lblGroupCodeBinding.Text = "여기에 그룹코드";
            this.lblGroupCodeBinding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGroupName
            // 
            this.lblGroupName.Location = new System.Drawing.Point(588, 16);
            this.lblGroupName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(125, 35);
            this.lblGroupName.TabIndex = 1;
            this.lblGroupName.Text = "그룹명";
            this.lblGroupName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGroupCode
            // 
            this.lblGroupCode.Location = new System.Drawing.Point(86, 16);
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
            this.label6.Location = new System.Drawing.Point(919, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 35);
            this.label6.TabIndex = 11;
            this.label6.Text = "추가할 권한";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1261, 664);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvAddAuthority);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(634, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 654);
            this.panel2.TabIndex = 2;
            // 
            // dgvAddAuthority
            // 
            this.dgvAddAuthority.AllowUserToAddRows = false;
            this.dgvAddAuthority.AllowUserToResizeRows = false;
            this.dgvAddAuthority.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvAddAuthority.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAddAuthority.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddAuthority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAddAuthority.Location = new System.Drawing.Point(0, 0);
            this.dgvAddAuthority.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAddAuthority.Name = "dgvAddAuthority";
            this.dgvAddAuthority.RowHeadersVisible = false;
            this.dgvAddAuthority.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvAddAuthority.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAddAuthority.RowTemplate.Height = 27;
            this.dgvAddAuthority.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddAuthority.Size = new System.Drawing.Size(623, 654);
            this.dgvAddAuthority.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvEveryScreen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 654);
            this.panel1.TabIndex = 1;
            // 
            // dgvEveryScreen
            // 
            this.dgvEveryScreen.AllowUserToAddRows = false;
            this.dgvEveryScreen.AllowUserToResizeRows = false;
            this.dgvEveryScreen.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvEveryScreen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEveryScreen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEveryScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEveryScreen.Location = new System.Drawing.Point(0, 0);
            this.dgvEveryScreen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvEveryScreen.Name = "dgvEveryScreen";
            this.dgvEveryScreen.RowHeadersVisible = false;
            this.dgvEveryScreen.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvEveryScreen.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEveryScreen.RowTemplate.Height = 27;
            this.dgvEveryScreen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEveryScreen.Size = new System.Drawing.Size(622, 654);
            this.dgvEveryScreen.TabIndex = 0;
            // 
            // frmUserGroupAuthorityModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1285, 853);
            this.Controls.Add(this.label6);
            this.Name = "frmUserGroupAuthorityModify";
            this.Text = "그룹별 권한 수정";
            this.Load += new System.EventHandler(this.frmUserGroupAuthorityModify_Load);
            this.Controls.SetChildIndex(this.pnlDgv, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.pnlSelect, 0);
            this.Controls.SetChildIndex(this.btn4, 0);
            this.Controls.SetChildIndex(this.btn1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btn5, 0);
            this.Controls.SetChildIndex(this.btn3, 0);
            this.Controls.SetChildIndex(this.btn2, 0);
            this.pnlDgv.ResumeLayout(false);
            this.pnlSelect.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddAuthority)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEveryScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblGroupCode;
        private System.Windows.Forms.Label lblGroupNameBinding;
        private System.Windows.Forms.Label lblGroupCodeBinding;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private DatagridviewControl dgvAddAuthority;
        private System.Windows.Forms.Panel panel1;
        private DatagridviewControl dgvEveryScreen;
    }
}