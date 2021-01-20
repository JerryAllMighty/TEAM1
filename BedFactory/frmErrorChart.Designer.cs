
namespace BedFactory
{
    partial class frmErrorChart
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelComboText1 = new BedFactory.LabelComboText();
            this.labelComboText4 = new BedFactory.LabelComboText();
            this.labelComboText2 = new BedFactory.LabelComboText();
            this.labelComboText5 = new BedFactory.LabelComboText();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "검사품목";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "검사현황";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 550);
            this.dataGridView1.TabIndex = 2;
            // 
            // labelComboText1
            // 
            this.labelComboText1.BackColor = System.Drawing.Color.Transparent;
            this.labelComboText1.BoxKind = BedFactory.LabelComboText.Kind.combo;
            this.labelComboText1.ComboData = null;
            this.labelComboText1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.labelComboText1.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.labelComboText1.Header = "종류";
            this.labelComboText1.Important = false;
            this.labelComboText1.Location = new System.Drawing.Point(16, 32);
            this.labelComboText1.MultiLine = false;
            this.labelComboText1.MultiLineCnt = 0;
            this.labelComboText1.Name = "labelComboText1";
            this.labelComboText1.Size = new System.Drawing.Size(260, 37);
            this.labelComboText1.TabIndex = 3;
            // 
            // labelComboText4
            // 
            this.labelComboText4.BackColor = System.Drawing.Color.Transparent;
            this.labelComboText4.BoxKind = BedFactory.LabelComboText.Kind.combo;
            this.labelComboText4.ComboData = null;
            this.labelComboText4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.labelComboText4.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.labelComboText4.Header = "상태";
            this.labelComboText4.Important = false;
            this.labelComboText4.Location = new System.Drawing.Point(314, 32);
            this.labelComboText4.MultiLine = false;
            this.labelComboText4.MultiLineCnt = 0;
            this.labelComboText4.Name = "labelComboText4";
            this.labelComboText4.Size = new System.Drawing.Size(260, 37);
            this.labelComboText4.TabIndex = 6;
            // 
            // labelComboText2
            // 
            this.labelComboText2.BackColor = System.Drawing.Color.Transparent;
            this.labelComboText2.BoxKind = BedFactory.LabelComboText.Kind.combo;
            this.labelComboText2.ComboData = null;
            this.labelComboText2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.labelComboText2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.labelComboText2.Header = "결과";
            this.labelComboText2.Important = false;
            this.labelComboText2.Location = new System.Drawing.Point(612, 32);
            this.labelComboText2.MultiLine = false;
            this.labelComboText2.MultiLineCnt = 0;
            this.labelComboText2.Name = "labelComboText2";
            this.labelComboText2.Size = new System.Drawing.Size(260, 37);
            this.labelComboText2.TabIndex = 7;
            // 
            // labelComboText5
            // 
            this.labelComboText5.BackColor = System.Drawing.Color.Transparent;
            this.labelComboText5.BoxKind = BedFactory.LabelComboText.Kind.combo;
            this.labelComboText5.ComboData = null;
            this.labelComboText5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.labelComboText5.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.labelComboText5.Header = "작업장";
            this.labelComboText5.Important = false;
            this.labelComboText5.Location = new System.Drawing.Point(910, 32);
            this.labelComboText5.MultiLine = false;
            this.labelComboText5.MultiLineCnt = 0;
            this.labelComboText5.Name = "labelComboText5";
            this.labelComboText5.Size = new System.Drawing.Size(260, 37);
            this.labelComboText5.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "* 일시";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(97, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(88, 25);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // frmErrorChart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelComboText5);
            this.Controls.Add(this.labelComboText2);
            this.Controls.Add(this.labelComboText4);
            this.Controls.Add(this.labelComboText1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.Name = "frmErrorChart";
            this.Text = "frmErrorChart";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LabelComboText labelComboText1;
        private LabelComboText labelComboText4;
        private LabelComboText labelComboText2;
        private LabelComboText labelComboText5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}