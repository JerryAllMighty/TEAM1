
namespace BedFactory
{
    partial class frmFactoryAdmin
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
            this.datagridviewControl1 = new BedFactory.DatagridviewControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.datagridviewControl1);
            // 
            // datagridviewControl1
            // 
            this.datagridviewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridviewControl1.Location = new System.Drawing.Point(0, 0);
            this.datagridviewControl1.Name = "datagridviewControl1";
            this.datagridviewControl1.Size = new System.Drawing.Size(1282, 451);
            this.datagridviewControl1.TabIndex = 0;
            this.datagridviewControl1.Text = "datagridviewControl1";
            // 
            // frmFactoryAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Name = "frmFactoryAdmin";
            this.Text = "공정관리";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatagridviewControl datagridviewControl1;
    }
}
