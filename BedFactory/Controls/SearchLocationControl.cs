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
                base.Size = new Size(1400, 65);

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
                base.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3));
                base.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7));
                
                //Button btn = new Button();
                //btn.Name = "btnSearch";
                //btn.Text = "조회";
                //btn.Size = new Size(70, 30);
                //btn.BackColor = Color.LightSteelBlue;
                //btn.FlatStyle = FlatStyle.Popup;
                //btn.Anchor = AnchorStyles.None;                
                //this.Controls.Add(btn, 9, RowCount);
            }

            //if(RowCount == 1 && GetControlFromPosition(9, 0) != null)
            //{
            //    Control ctrl = GetControlFromPosition(9, 0);
            //    SetRow(ctrl, 1);
            //}

            //if (RowCount == 2 && GetControlFromPosition(9, 1) != null)
            //{
            //    Control ctrl = GetControlFromPosition(9, 1);
            //    SetRow(ctrl, 2);
            //}
        }
    }
}
