using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BedFactory
{
    public partial class LabelComboText : UserControl
    {
        public enum Kind { combo, text };
        public Kind BoxKind { get; set; }
        public bool MultiLine { get; set; }
        public int MultiLineCnt { get; set; }
        public bool Important { get; set; }
        public string Header { get; set; }
        public object ComboData { get; set; }
        public ComboBoxStyle DropDownStyle { get; set; }

        public ComboBox cbo;
        public TextBox text;

        public LabelComboText()
        {
            InitializeComponent();
        }

        private void LabelComboText_Load(object sender, EventArgs e)
        {
            label1.Text = "* " + Header;

            if(BoxKind == Kind.combo)
            {
                cbo = new ComboBox();
                cbo.Location = new Point(label1.Location.X + label1.Size.Width + 30, 6);
                cbo.Size = new Size(this.Size.Width - cbo.Location.X - 5, 25);
                cbo.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;
                cbo.DataSource = ComboData;
                cbo.DropDownStyle = DropDownStyle;
                this.Controls.Add(cbo);
            }
            else if(BoxKind == Kind.text)
            {
                text = new TextBox();
                text.Location = new Point(label1.Location.X + label1.Size.Width + 30, 6);
                text.Multiline = MultiLine;

                if (MultiLine && MultiLineCnt > 1)
                {
                    text.Size = new Size(this.Size.Width - text.Location.X - 5, 25 * MultiLineCnt);
                    text.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
                }
                else
                {
                    text.Size = new Size(this.Size.Width - text.Location.X - 5, 25);
                    text.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;
                }

                this.Controls.Add(text);
            }

            if(Important)
            {
                label1.ForeColor = Color.Crimson;
            }
        }
    }
}
