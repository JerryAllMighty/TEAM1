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
    public partial class DatagridviewControl : DataGridView
    {
        public DatagridviewControl()
        {
            InitializeComponent();
            
            this.BackgroundColor = Color.White;
            this.Dock = DockStyle.Fill;

            DataGridViewCellStyle dgvRowsFont = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvColumsFont = new DataGridViewCellStyle();
            FontStyle font1 = FontStyle.Regular;
            FontStyle font2 = FontStyle.Bold;

            this.AutoGenerateColumns = false;
            this.AllowUserToAddRows = false;
            this.RowHeadersVisible = false;
            this.AllowUserToResizeRows = false;
            //dgv.MultiSelect = false;
            dgvRowsFont.Font = new Font("맑은 고딕", 10F, font1);
            this.RowsDefaultCellStyle = dgvRowsFont;
            dgvColumsFont.Font = new Font("맑은 고딕", 10F, font2);
            this.ColumnHeadersDefaultCellStyle = dgvColumsFont;

            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public  void SetGridViewColumn(
           string headerText,
           string dataPropertyName,
           int colWidth = 100,
           int fillWidth = 100,
           bool visibility = true,
           DataGridViewContentAlignment textAlign = DataGridViewContentAlignment.MiddleLeft)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.Name = dataPropertyName;
            col.HeaderText = headerText;
            col.DataPropertyName = dataPropertyName;
            col.Width = colWidth;
            col.FillWeight = fillWidth;
            col.DefaultCellStyle.Alignment = textAlign;
            col.Visible = visibility;
            col.ReadOnly = true;

            this.Columns.Add(col);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
