
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMenuTree = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.trvMenu = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMenu = new BedFactory.DatagridviewControl();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pnlMenuBigCategory = new System.Windows.Forms.Panel();
            this.dgvMenuBigCategory = new BedFactory.DatagridviewControl();
            this.pnlDgv.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlMenuBigCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuBigCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn2.Location = new System.Drawing.Point(1616, 13);
            this.btn2.Size = new System.Drawing.Size(100, 25);
            this.btn2.Text = "메뉴 추가";
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn3.Location = new System.Drawing.Point(1545, 13);
            this.btn3.Visible = false;
            // 
            // btn5
            // 
            this.btn5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.pnlDgv.Controls.Add(this.tableLayoutPanel2);
            // 
            // btn4
            // 
            this.btn4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn4.Location = new System.Drawing.Point(1439, 13);
            this.btn4.Visible = false;
            // 
            // lblMenuTree
            // 
            this.lblMenuTree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMenuTree.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMenuTree.Location = new System.Drawing.Point(862, 5);
            this.lblMenuTree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenuTree.Name = "lblMenuTree";
            this.lblMenuTree.Size = new System.Drawing.Size(192, 35);
            this.lblMenuTree.TabIndex = 18;
            this.lblMenuTree.Text = "메뉴 트리";
            this.lblMenuTree.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.trvMenu, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1000F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1704, 1000);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // trvMenu
            // 
            this.trvMenu.BackColor = System.Drawing.Color.Azure;
            this.trvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvMenu.Location = new System.Drawing.Point(855, 3);
            this.trvMenu.Name = "trvMenu";
            this.trvMenu.Size = new System.Drawing.Size(846, 994);
            this.trvMenu.TabIndex = 19;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvMenu, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pnlMenu, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlMenuBigCategory, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(846, 994);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToResizeRows = false;
            this.dgvMenu.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenu.Location = new System.Drawing.Point(3, 519);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowHeadersVisible = false;
            this.dgvMenu.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvMenu.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMenu.RowTemplate.Height = 27;
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.Size = new System.Drawing.Size(840, 472);
            this.dgvMenu.TabIndex = 17;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.lblMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(3, 480);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(840, 33);
            this.pnlMenu.TabIndex = 16;
            // 
            // lblMenu
            // 
            this.lblMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMenu.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMenu.Location = new System.Drawing.Point(0, 0);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(192, 33);
            this.lblMenu.TabIndex = 23;
            this.lblMenu.Text = "메뉴 소분류";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMenuBigCategory
            // 
            this.pnlMenuBigCategory.Controls.Add(this.dgvMenuBigCategory);
            this.pnlMenuBigCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenuBigCategory.Location = new System.Drawing.Point(3, 3);
            this.pnlMenuBigCategory.Name = "pnlMenuBigCategory";
            this.pnlMenuBigCategory.Size = new System.Drawing.Size(840, 471);
            this.pnlMenuBigCategory.TabIndex = 15;
            // 
            // dgvMenuBigCategory
            // 
            this.dgvMenuBigCategory.AllowUserToAddRows = false;
            this.dgvMenuBigCategory.AllowUserToResizeRows = false;
            this.dgvMenuBigCategory.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dgvMenuBigCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvMenuBigCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuBigCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenuBigCategory.Location = new System.Drawing.Point(0, 0);
            this.dgvMenuBigCategory.Name = "dgvMenuBigCategory";
            this.dgvMenuBigCategory.RowHeadersVisible = false;
            this.dgvMenuBigCategory.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dgvMenuBigCategory.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMenuBigCategory.RowTemplate.Height = 27;
            this.dgvMenuBigCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenuBigCategory.Size = new System.Drawing.Size(840, 471);
            this.dgvMenuBigCategory.TabIndex = 2;
            this.dgvMenuBigCategory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenuBigCategory_CellDoubleClick_1);
            // 
            // frmMenuManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1728, 1055);
            this.Controls.Add(this.lblMenuTree);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmMenuManagement";
            this.Text = "메뉴 관리";
            this.Load += new System.EventHandler(this.frmMenuManagement2_Load);
            this.Controls.SetChildIndex(this.lblMenuTree, 0);
            this.Controls.SetChildIndex(this.btn4, 0);
            this.Controls.SetChildIndex(this.pnlDgv, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btn5, 0);
            this.Controls.SetChildIndex(this.btn3, 0);
            this.Controls.SetChildIndex(this.btn2, 0);
            this.pnlDgv.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenuBigCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuBigCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMenuTree;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TreeView trvMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlMenuBigCategory;
        private DatagridviewControl dgvMenuBigCategory;
        private System.Windows.Forms.Label lblMenu;
        private DatagridviewControl dgvMenu;
    }
}
