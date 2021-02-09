
namespace BedFactory
{
    partial class frmMenuManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMenuBigCategory = new BedFactory.DatagridviewControl();
            this.trvMenu = new System.Windows.Forms.TreeView();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblMenuTree = new System.Windows.Forms.Label();
            this.pnlMenuBigCategory = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.dgvMenu = new BedFactory.DatagridviewControl();
            this.pnlDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuBigCategory)).BeginInit();
            this.pnlMenuBigCategory.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(1616, 13);
            this.btn2.Size = new System.Drawing.Size(100, 25);
            this.btn2.Text = "메뉴 추가";
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(1545, 13);
            this.btn3.Visible = false;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(1308, 13);
            this.btn5.Visible = false;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.Text = "메뉴 대분류";
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.pnlMenu);
            this.pnlDgv.Controls.Add(this.pnlMenuBigCategory);
            this.pnlDgv.Controls.Add(this.lblMenu);
            this.pnlDgv.Controls.Add(this.trvMenu);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(1439, 13);
            this.btn4.Visible = false;
            // 
            // dgvMenuBigCategory
            // 
            this.dgvMenuBigCategory.AllowUserToAddRows = false;
            this.dgvMenuBigCategory.AllowUserToResizeRows = false;
            this.dgvMenuBigCategory.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvMenuBigCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMenuBigCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuBigCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenuBigCategory.Location = new System.Drawing.Point(0, 0);
            this.dgvMenuBigCategory.Name = "dgvMenuBigCategory";
            this.dgvMenuBigCategory.RowHeadersVisible = false;
            this.dgvMenuBigCategory.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvMenuBigCategory.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMenuBigCategory.RowTemplate.Height = 27;
            this.dgvMenuBigCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenuBigCategory.Size = new System.Drawing.Size(904, 481);
            this.dgvMenuBigCategory.TabIndex = 2;
            this.dgvMenuBigCategory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenuBigCategory_CellDoubleClick);
            // 
            // trvMenu
            // 
            this.trvMenu.BackColor = System.Drawing.Color.Azure;
            this.trvMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.trvMenu.Location = new System.Drawing.Point(1084, 0);
            this.trvMenu.Name = "trvMenu";
            this.trvMenu.Size = new System.Drawing.Size(620, 1000);
            this.trvMenu.TabIndex = 3;
            // 
            // lblMenu
            // 
            this.lblMenu.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMenu.Location = new System.Drawing.Point(4, 515);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(192, 35);
            this.lblMenu.TabIndex = 13;
            this.lblMenu.Text = "메뉴 소분류";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMenuTree
            // 
            this.lblMenuTree.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMenuTree.Location = new System.Drawing.Point(1091, 7);
            this.lblMenuTree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenuTree.Name = "lblMenuTree";
            this.lblMenuTree.Size = new System.Drawing.Size(192, 35);
            this.lblMenuTree.TabIndex = 18;
            this.lblMenuTree.Text = "메뉴 트리";
            this.lblMenuTree.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMenuBigCategory
            // 
            this.pnlMenuBigCategory.Controls.Add(this.dgvMenuBigCategory);
            this.pnlMenuBigCategory.Location = new System.Drawing.Point(3, 3);
            this.pnlMenuBigCategory.Name = "pnlMenuBigCategory";
            this.pnlMenuBigCategory.Size = new System.Drawing.Size(904, 481);
            this.pnlMenuBigCategory.TabIndex = 14;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.dgvMenu);
            this.pnlMenu.Location = new System.Drawing.Point(3, 553);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(904, 444);
            this.pnlMenu.TabIndex = 15;
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToResizeRows = false;
            this.dgvMenu.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenu.Location = new System.Drawing.Point(0, 0);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowHeadersVisible = false;
            this.dgvMenu.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvMenu.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMenu.RowTemplate.Height = 27;
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.Size = new System.Drawing.Size(904, 444);
            this.dgvMenu.TabIndex = 2;
            // 
            // frmMenuManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1728, 1055);
            this.Controls.Add(this.lblMenuTree);
            this.Name = "frmMenuManagement";
            this.Text = "메뉴 관리";
            this.Load += new System.EventHandler(this.frmMenuManagement2_Load);
            this.Controls.SetChildIndex(this.btn4, 0);
            this.Controls.SetChildIndex(this.pnlDgv, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btn5, 0);
            this.Controls.SetChildIndex(this.btn3, 0);
            this.Controls.SetChildIndex(this.btn2, 0);
            this.Controls.SetChildIndex(this.lblMenuTree, 0);
            this.pnlDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuBigCategory)).EndInit();
            this.pnlMenuBigCategory.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DatagridviewControl dgvMenuBigCategory;
        private System.Windows.Forms.TreeView trvMenu;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblMenuTree;
        private System.Windows.Forms.Panel pnlMenuBigCategory;
        private System.Windows.Forms.Panel pnlMenu;
        private DatagridviewControl dgvMenu;
    }
}
