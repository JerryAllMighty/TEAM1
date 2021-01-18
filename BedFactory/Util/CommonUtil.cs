using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BedFactory.Util
{
    public class CommonUtil
    {
        public static void InItGridView(DataGridView dgv )
        {
            DataGridViewCellStyle dgvRowsFont = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvColumsFont = new DataGridViewCellStyle();
            FontStyle font1 = FontStyle.Regular;
            FontStyle font2 = FontStyle.Bold;

            dgv.AutoGenerateColumns = false;
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToResizeRows = false;
            //dgv.MultiSelect = false;
            dgvRowsFont.Font = new Font("맑은 고딕", 10F, font1);
            dgv.RowsDefaultCellStyle = dgvRowsFont;
            dgvColumsFont.Font = new Font("맑은 고딕", 10F, font2);
            dgv.ColumnHeadersDefaultCellStyle = dgvColumsFont;
            
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        public static void SetGridViewColumn(DataGridView dgv,
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

            dgv.Columns.Add(col);
        }
    }
}
