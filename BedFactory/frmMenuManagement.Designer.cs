
namespace BedFactory
{
    partial class frmMenuManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trvMenu = new System.Windows.Forms.TreeView();
            this.lblMenu = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvMenuBigCategory = new BedFactory.DatagridviewControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvMenu = new BedFactory.DatagridviewControl();
            this.lblMenuTree = new System.Windows.Forms.Label();
            this.pnlDgv.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuBigCategory)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(1170, 99);
            this.btn2.Size = new System.Drawing.Size(100, 25);
            this.btn2.Text = "메뉴 추가";
            this.btn2.Click += new System.EventHandler(this.btn2_Click_1);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(1099, 99);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(862, 99);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.Text = "메뉴 대분류";
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.panel2);
            this.pnlDgv.Controls.Add(this.panel1);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(993, 99);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trvMenu);
            this.panel1.Location = new System.Drawing.Point(638, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 684);
            this.panel1.TabIndex = 0;
            // 
            // trvMenu
            // 
            this.trvMenu.BackColor = System.Drawing.Color.Azure;
            this.trvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvMenu.Location = new System.Drawing.Point(0, 0);
            this.trvMenu.Name = "trvMenu";
            this.trvMenu.Size = new System.Drawing.Size(620, 684);
            this.trvMenu.TabIndex = 0;
            // 
            // lblMenu
            // 
            this.lblMenu.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMenu.Location = new System.Drawing.Point(13, 378);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(192, 35);
            this.lblMenu.TabIndex = 12;
            this.lblMenu.Text = "메뉴 소분류";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvMenuBigCategory);
            this.panel2.Location = new System.Drawing.Point(5, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 242);
            this.panel2.TabIndex = 13;
            // 
            // dgvMenuBigCategory
            // 
            this.dgvMenuBigCategory.AllowUserToAddRows = false;
            this.dgvMenuBigCategory.AllowUserToResizeRows = false;
            this.dgvMenuBigCategory.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvMenuBigCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvMenuBigCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuBigCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenuBigCategory.Location = new System.Drawing.Point(0, 0);
            this.dgvMenuBigCategory.Name = "dgvMenuBigCategory";
            this.dgvMenuBigCategory.RowHeadersVisible = false;
            this.dgvMenuBigCategory.RowHeadersWidth = 51;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvMenuBigCategory.RowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvMenuBigCategory.RowTemplate.Height = 27;
            this.dgvMenuBigCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenuBigCategory.Size = new System.Drawing.Size(600, 242);
            this.dgvMenuBigCategory.TabIndex = 0;
            this.dgvMenuBigCategory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenuBigCategory_CellDoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvMenu);
            this.panel3.Location = new System.Drawing.Point(18, 423);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 318);
            this.panel3.TabIndex = 14;
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToResizeRows = false;
            this.dgvMenu.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenu.Location = new System.Drawing.Point(0, 0);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowHeadersVisible = false;
            this.dgvMenu.RowHeadersWidth = 51;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvMenu.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvMenu.RowTemplate.Height = 27;
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.Size = new System.Drawing.Size(600, 318);
            this.dgvMenu.TabIndex = 0;
            // 
            // lblMenuTree
            // 
            this.lblMenuTree.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMenuTree.Location = new System.Drawing.Point(645, 89);
            this.lblMenuTree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenuTree.Name = "lblMenuTree";
            this.lblMenuTree.Size = new System.Drawing.Size(192, 35);
            this.lblMenuTree.TabIndex = 17;
            this.lblMenuTree.Text = "메뉴 트리";
            this.lblMenuTree.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMenuManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.lblMenuTree);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblMenu);
            this.Name = "frmMenuManagement";
            this.Text = "메뉴 관리";
            this.Load += new System.EventHandler(this.frmMenuManagement_Load);
            this.Controls.SetChildIndex(this.pnlDgv, 0);
            this.Controls.SetChildIndex(this.pnlSelect, 0);
            this.Controls.SetChildIndex(this.lblMenu, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.lblMenuTree, 0);
            this.Controls.SetChildIndex(this.btn4, 0);
            this.Controls.SetChildIndex(this.btn1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btn5, 0);
            this.Controls.SetChildIndex(this.btn3, 0);
            this.Controls.SetChildIndex(this.btn2, 0);
            this.pnlDgv.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuBigCategory)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView trvMenu;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DatagridviewControl dgvMenuBigCategory;
        private DatagridviewControl dgvMenu;
        private System.Windows.Forms.Label lblMenuTree;
    }
}