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
    public partial class SearchLocationControl : TableLayoutPanel
    {
        public SearchLocationControl()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            if(base.ColumnCount < 3)
            {
                base.Size = new Size(1300, 65);

                base.Controls.Clear();

                base.ColumnStyles.Clear();

                base.RowCount = 0;
                base.ColumnCount = 10;
                base.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
                base.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18));
                base.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3));
                base.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
                base.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18));
                base.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3));
                base.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
                base.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18));
                base.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13));
                base.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7));
            }
        }
    }
}
