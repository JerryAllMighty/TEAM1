
namespace BedFactory.Pop_up
{
    partial class frmCheckInfo
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
            this.lctCheckDetail = new BedFactory.LabelComboText();
            this.btnOk = new System.Windows.Forms.Button();
            this.lctCheckKind = new BedFactory.LabelComboText();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lctCheckName = new BedFactory.LabelComboText();
            this.SuspendLayout();
            // 
            // lctCheckDetail
            // 
            this.lctCheckDetail.BackColor = System.Drawing.Color.Transparent;
            this.lctCheckDetail.BoxKind = BedFactory.LabelComboText.Kind.text;
            this.lctCheckDetail.ComboData = null;
            this.lctCheckDetail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.lctCheckDetail.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lctCheckDetail.Header = "검사내용";
            this.lctCheckDetail.Important = true;
            this.lctCheckDetail.Location = new System.Drawing.Point(44, 152);
            this.lctCheckDetail.MultiLine = true;
            this.lctCheckDetail.MultiLineCnt = 5;
            this.lctCheckDetail.Name = "lctCheckDetail";
            this.lctCheckDetail.Size = new System.Drawing.Size(485, 139);
            this.lctCheckDetail.TabIndex = 10;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOk.Location = new System.Drawing.Point(273, 317);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(125, 50);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "등 록";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lctCheckKind
            // 
            this.lctCheckKind.BackColor = System.Drawing.Color.Transparent;
            this.lctCheckKind.BoxKind = BedFactory.LabelComboText.Kind.combo;
            this.lctCheckKind.ComboData = null;
            this.lctCheckKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lctCheckKind.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lctCheckKind.Header = "검사종류";
            this.lctCheckKind.Important = true;
            this.lctCheckKind.Location = new System.Drawing.Point(44, 89);
            this.lctCheckKind.MultiLine = false;
            this.lctCheckKind.MultiLineCnt = 0;
            this.lctCheckKind.Name = "lctCheckKind";
            this.lctCheckKind.Size = new System.Drawing.Size(485, 38);
            this.lctCheckKind.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(404, 317);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 50);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "취 소";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lctCheckName
            // 
            this.lctCheckName.BackColor = System.Drawing.Color.Transparent;
            this.lctCheckName.BoxKind = BedFactory.LabelComboText.Kind.text;
            this.lctCheckName.ComboData = null;
            this.lctCheckName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.lctCheckName.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lctCheckName.Header = "검사이름";
            this.lctCheckName.Important = true;
            this.lctCheckName.Location = new System.Drawing.Point(44, 30);
            this.lctCheckName.MultiLine = false;
            this.lctCheckName.MultiLineCnt = 5;
            this.lctCheckName.Name = "lctCheckName";
            this.lctCheckName.Size = new System.Drawing.Size(485, 39);
            this.lctCheckName.TabIndex = 16;
            // 
            // frmCheckInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(578, 379);
            this.Controls.Add(this.lctCheckName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lctCheckKind);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lctCheckDetail);
            this.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.Name = "frmCheckInfo";
            this.Text = "검사항목 설정";
            this.Load += new System.EventHandler(this.frmCheckInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LabelComboText lctCheckDetail;
        private System.Windows.Forms.Button btnOk;
        private LabelComboText lctCheckKind;
        private System.Windows.Forms.Button btnCancel;
        private LabelComboText lctCheckName;
    }
}