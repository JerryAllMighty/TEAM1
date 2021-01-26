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
        /// <summary>
        /// 생성자에 그리드 뷰 세팅 코딩
        /// </summary>
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

        /// <summary>
        /// 그리드뷰 컬럼 세팅
        /// </summary>
        /// <param name="dgv">그리드뷰</param>
        /// <param name="headerText">컬럼명</param>
        /// <param name="dataPropertyName">컬렁이름</param>
        /// <param name="colWidth">컬럼넓이</param>
        /// <param name="fillWidth">fill일 때 컬럼넓이</param>
        /// <param name="visibility">컬럼식별유무</param>
        /// <param name="textAlign">컬럼정렬</param>
        public void SetGridViewColumn(
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

        /// <summary>
        /// 그리드뷰 체크박스 세팅
        /// </summary>
        /// <param name="dgv">그리드뷰</param>
        /// <param name="dataPropertyName">체크박스 컬럼이름</param>
        /// <param name="headerText">체크박스 컬럼명</param>
        /// <param name="columnWidth"></param>
        public void SetGridCheckBox(string dataPropertyName, string headerText = "", int columnWidth = 30)
        {
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = headerText;
            checkBoxColumn.Name = dataPropertyName;
            checkBoxColumn.Width = columnWidth;
            checkBoxColumn.ReadOnly = false;
            this.Columns.Add(checkBoxColumn);
        }

        /// <summary>
        /// 그리드뷰 체크박스 상세설정
        /// </summary>
        /// <param name="dgv">그리드뷰</param>
        /// <param name="dgvCheckBox">체크박스</param>
        /// <param name="x">x좌표</param>
        /// <param name="y">y좌표</param>
        /// <returns></returns>
        public CheckBox AddGridCheckBox(CheckBox dgvCheckBox, int x = 12, int y = 5)
        {
            Point headerLocation = this.GetCellDisplayRectangle(0, -1, true).Location;
            dgvCheckBox.Location = new Point(headerLocation.X + x, headerLocation.Y + y);
            dgvCheckBox.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            dgvCheckBox.BackColor = Color.Transparent;
            dgvCheckBox.Size = new Size(18, 18);

            return dgvCheckBox;
        }

        /// <summary>
        /// 그리드뷰 버튼 세팅
        /// </summary>
        /// <param name="dgv">그리드뷰</param>
        /// <param name="headerText">칼럼이름</param>
        /// <param name="dataPropertyName">칼럼명</param>
        /// <param name="buttonText">버튼텍스트</param>
        /// <param name="width">버튼넓이</param>
        /// <returns></returns>
        public void AddGridButton(string headerText,
                                          string dataPropertyName, string buttonText, Padding padding, int width = 10)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = headerText;
            btn.Name = dataPropertyName;
            btn.Text = buttonText;
            btn.Width = width;
            btn.DefaultCellStyle.Padding = padding;
            btn.UseColumnTextForButtonValue = true; //버튼text 적용
            btn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Columns.Add(btn);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
