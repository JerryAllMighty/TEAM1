using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BedFactory.Controls
{
    public partial class OnlyNumberTextBox : TextBox
    {
        public bool Decimal { get; set; }

        public OnlyNumberTextBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Decimal)
            {
                if (e.KeyChar != '\b' && e.KeyChar != '.' && !char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (e.KeyChar != '\b' && !char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
