
namespace BedFactory
{
    partial class frmUserGroupAuthority
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datagridviewControl2 = new BedFactory.DatagridviewControl();
            this.datagridviewControl1 = new BedFactory.DatagridviewControl();
            this.pnlDgv.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.datagridviewControl1);
            this.pnlDgv.Size = new System.Drawing.Size(615, 711);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.Text = "그룹 목록";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(629, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "허용된 권한";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datagridviewControl2);
            this.panel1.Location = new System.Drawing.Point(634, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 711);
            this.panel1.TabIndex = 12;
            // 
            // datagridviewControl2
            // 
            this.datagridviewControl2.AllowUserToAddRows = false;
            this.datagridviewControl2.AllowUserToResizeRows = false;
            this.datagridviewControl2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.datagridviewControl2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.datagridviewControl2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridviewControl2.Location = new System.Drawing.Point(0, 0);
            this.datagridviewControl2.Name = "datagridviewControl2";
            this.datagridviewControl2.RowHeadersVisible = false;
            this.datagridviewControl2.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.datagridviewControl2.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.datagridviewControl2.RowTemplate.Height = 27;
            this.datagridviewControl2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewControl2.Size = new System.Drawing.Size(736, 711);
            this.datagridviewControl2.TabIndex = 0;
            // 
            // datagridviewControl1
            // 
            this.datagridviewControl1.AllowUserToAddRows = false;
            this.datagridviewControl1.AllowUserToResizeRows = false;
            this.datagridviewControl1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.datagridviewControl1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.datagridviewControl1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridviewControl1.Location = new System.Drawing.Point(0, 0);
            this.datagridviewControl1.Name = "datagridviewControl1";
            this.datagridviewControl1.RowHeadersVisible = false;
            this.datagridviewControl1.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.datagridviewControl1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.datagridviewControl1.RowTemplate.Height = 27;
            this.datagridviewControl1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewControl1.Size = new System.Drawing.Size(615, 711);
            this.datagridviewControl1.TabIndex = 0;
            // 
            // frmUserGroupAuthority
            // 
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "frmUserGroupAuthority";
            this.Text = "사용자 그룹별 권한 관리";
            this.Load += new System.EventHandler(this.frmUserGroupAuthority_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pnlSelect, 0);
            this.Controls.SetChildIndex(this.btn4, 0);
            this.Controls.SetChildIndex(this.pnlDgv, 0);
            this.Controls.SetChildIndex(this.btn1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btn5, 0);
            this.Controls.SetChildIndex(this.btn3, 0);
            this.Controls.SetChildIndex(this.btn2, 0);
            this.pnlDgv.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private DatagridviewControl datagridviewControl1;
        private DatagridviewControl datagridviewControl2;
    }
}
