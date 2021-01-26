
namespace BedFactory.Controls
{
    partial class MaterialsCheckList
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelComboText1 = new BedFactory.LabelComboText();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelComboText1
            // 
            this.labelComboText1.BackColor = System.Drawing.Color.Transparent;
            this.labelComboText1.BoxKind = BedFactory.LabelComboText.Kind.combo;
            this.labelComboText1.ComboData = null;
            this.labelComboText1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.labelComboText1.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.labelComboText1.Header = "종류";
            this.labelComboText1.Important = true;
            this.labelComboText1.Location = new System.Drawing.Point(3, 3);
            this.labelComboText1.MultiLine = false;
            this.labelComboText1.MultiLineCnt = 0;
            this.labelComboText1.Name = "labelComboText1";
            this.labelComboText1.Size = new System.Drawing.Size(417, 33);
            this.labelComboText1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(426, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "삭 제";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MaterialsCheckList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelComboText1);
            this.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MaterialsCheckList";
            this.Size = new System.Drawing.Size(490, 39);
            this.ResumeLayout(false);

        }

        #endregion

        private LabelComboText labelComboText1;
        private System.Windows.Forms.Button button2;
    }
}
