
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
            this.labelComboText2 = new BedFactory.LabelComboText();
            this.button1 = new System.Windows.Forms.Button();
            this.labelComboText1 = new BedFactory.LabelComboText();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelComboText2
            // 
            this.labelComboText2.BackColor = System.Drawing.Color.Transparent;
            this.labelComboText2.BoxKind = BedFactory.LabelComboText.Kind.text;
            this.labelComboText2.ComboData = null;
            this.labelComboText2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.labelComboText2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.labelComboText2.Header = "검사내용";
            this.labelComboText2.Important = true;
            this.labelComboText2.Location = new System.Drawing.Point(44, 93);
            this.labelComboText2.MultiLine = true;
            this.labelComboText2.MultiLineCnt = 5;
            this.labelComboText2.Name = "labelComboText2";
            this.labelComboText2.Size = new System.Drawing.Size(485, 139);
            this.labelComboText2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(353, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "등 록";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // labelComboText1
            // 
            this.labelComboText1.BackColor = System.Drawing.Color.Transparent;
            this.labelComboText1.BoxKind = BedFactory.LabelComboText.Kind.combo;
            this.labelComboText1.ComboData = null;
            this.labelComboText1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.labelComboText1.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.labelComboText1.Header = "검사종류";
            this.labelComboText1.Important = true;
            this.labelComboText1.Location = new System.Drawing.Point(44, 33);
            this.labelComboText1.MultiLine = false;
            this.labelComboText1.MultiLineCnt = 0;
            this.labelComboText1.Name = "labelComboText1";
            this.labelComboText1.Size = new System.Drawing.Size(485, 38);
            this.labelComboText1.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(444, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 41);
            this.button2.TabIndex = 14;
            this.button2.Text = "취 소";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // frmCheckInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(578, 321);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelComboText1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelComboText2);
            this.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.Name = "frmCheckInfo";
            this.Text = "검사항목 설정";
            this.ResumeLayout(false);

        }

        #endregion

        private LabelComboText labelComboText2;
        private System.Windows.Forms.Button button1;
        private LabelComboText labelComboText1;
        private System.Windows.Forms.Button button2;
    }
}