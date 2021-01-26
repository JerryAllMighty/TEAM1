﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BedFactoryVO;

namespace BedFactory.Util
{
    public static class CommonUtil
    {
        /// <summary>
        /// 데이터그리드뷰
        /// </summary>
        /// <param name="dgv"></param>
        public static void SetInitGridView(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public static void AddGridTextColumn(
                            DataGridView dgv,
                            string headerText,
                            string dataPropertyName,
                            int colWidth = 100,
                            bool visibility = true,
                            DataGridViewContentAlignment textAlign = DataGridViewContentAlignment.MiddleLeft)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.Name = dataPropertyName;
            col.HeaderText = headerText;
            col.DataPropertyName = dataPropertyName;
            col.Width = colWidth;
            col.DefaultCellStyle.Alignment = textAlign;
            col.Visible = visibility;
            col.ReadOnly = true;

            dgv.Columns.Add(col);
        }

        /// <summary>
        /// 콤보박스 바인딩
        /// </summary>
        /// <param name="cbo">콤보박스</param>
        /// <param name="list">ComboItemVO(Code, CodeName, Gubun)</param>
        /// <param name="category">항목</param>
        /// <param name="blankItem">Default유무</param>
        /// <param name="blankText">Default값</param>
        public static void ComboBinding(ComboBox cbo, List<CommonCodedVO> list, string category, bool blankItem = true, string blankText = "")
        {
            var codeList = (from item in list
                            where item.Category.Equals(category)
                            select item).ToList();

            if (blankItem)
            {
                CommonCodedVO blank = new CommonCodedVO
                { Code_Num = blankText, Code_Name = blankText };
                codeList.Insert(0, blank);
            }
            cbo.DisplayMember = "CodeName";
            cbo.ValueMember = "Code";
            cbo.DataSource = codeList;
        }

        /// <summary>
        /// 공통코드 콤보박스 바인딩
        /// </summary>
        /// <param name="cbo">콤보박스</param>
        /// <param name="codeList">공통코드 리스트</param>
        /// <param name="category">카테고리</param>
        /// <param name="blankText">0 Index Text</param>
        public static void CommonCodeBindig(ComboBox cbo, List<CommonCodedVO> codeList, string category, string blankText)
        {
            var codeName = (from common in codeList
                            where common.Category.Contains(category)
                            select common).ToList();

            ComboBinding(cbo, codeName, category, blankText: blankText);
        }

        /// <summary>
        /// 트리노드 바인딩
        /// </summary>
        /// <param name="node">부모노드</param>
        /// <param name="list">바인딩 리스트</param>
        /// <param name="category">카테고리</param>
        /// <param name="blankItem">첫항목코드</param>
        /// <param name="blankText">첫항목이름</param>
        public static void AddTreeNode(TreeNode node, List<CommonCodedVO> list, string category, bool blankItem = true, string blankText = "")
        {
            var codeList = (from item in list
                            where item.Category.Equals(category)
                            select item).ToList();

            if (blankItem)
            {
                CommonCodedVO blank = new CommonCodedVO
                { Code_Name = blankText };
                codeList.Insert(0, blank);
            }

            for (int i = 0; i < codeList.Count; i++)
            {
                node.Nodes.Add(codeList[i].Code_Num, codeList[i].Code_Name);
            }
        }
    }
}
