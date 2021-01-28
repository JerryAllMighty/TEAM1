﻿using BedFactory.Util;
using BedFactoryService;
using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BedFactory
{
    public partial class frmProcessManagement : BedFactory.BaseForms.BaseForm2
    { 
        public frmProcessManagement()
        {
            InitializeComponent();
        }

        private void frmFacilitiesManagement_Load(object sender, EventArgs e)
        {
            //컬럼추가
            //그리드뷰 바인딩
  
            dgvProcessInfo.SetGridViewColumn("공정번호", "Process_Num");
            dgvProcessInfo.SetGridViewColumn("공정분류", "Process_Category_Name");
            dgvProcessInfo.SetGridViewColumn("공정명", "Process_Name");
            dgvProcessInfo.SetGridViewColumn("공정조건", "Process_Condition");
            dgvProcessInfo.SetGridViewColumn("정보삭제여부", "IsDeleted");
            dgvProcessInfo.SetGridViewColumn("최초등록자", "Firstman");
            dgvProcessInfo.SetGridViewColumn("최초등록일", "Firstdate");
            dgvProcessInfo.SetGridViewColumn("최종등록자", "Lastman");
            dgvProcessInfo.SetGridViewColumn("최종수정일", "Lastdate");
            dgvProcessInfo.SetGridViewColumn("공정분류ID", "Process_Category", visibility: false);

            //콤보박스 바인딩(공통코드)  : 예시
            if (frmCommonCode.commonList == null) // 항상 널 체크
                frmCommonCode.CheckCommonInfo();  // 널일때만 갖다오기

            CommonUtil.CommonCodeBindig(cboCategory, frmCommonCode.commonList, "공정", "");
        }


    //조회버튼
    public void btnSelect_Click(object sender, EventArgs e)
        {
            string prcCategory = cboCategory.SelectedValue.ToString();
            string prcName = txtName.Text.Trim();

            ProcessService service = new ProcessService();
            List<ProcessVO> list = service.GetProcessInfo(prcCategory, prcName);
            dgvProcessInfo.DataSource = list;
        }


        // 등록버튼
        public override void btn3_Click(object sender, EventArgs e)
        {
            //팝업호출
            frmProcessReg frm = new frmProcessReg();
            frm.ShowDialog();
        }


        // 수정버튼
        public override void btn2_Click(object sender, EventArgs e)
        {
            //팝업호출
            if (dgvProcessInfo.SelectedRows.Count < 1) return;

            var item = dgvProcessInfo.SelectedRows[0];

            ProcessVO vo = new ProcessVO
            {
                Process_Num = Convert.ToInt32(item.Cells["Process_Num"].Value),
                Process_Category = item.Cells["Process_Category"].Value.ToString(),
                Process_Name = item.Cells["Process_Name"].Value.ToString(),
                Process_Condition = item.Cells["Process_Condition"].Value.ToString(),
                IsDeleted = item.Cells["IsDeleted"].Value.ToString()
            };

            frmProcessReg frm = new frmProcessReg();
            frm.EditProcess = vo;
            frm.IsEditMode = true;
            frm.ShowDialog();
        }


        // 삭제버튼
        public override void btn1_Click(object sender, EventArgs e)
        {

        }

    }
}
