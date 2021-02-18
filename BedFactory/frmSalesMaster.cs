using BedFactory.Pop_up;
using BedFactoryService;
using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BedFactory
{
    public partial class frmSalesMaster : BedFactory.BaseForms.BaseForm2
    {
        /// <summary>
        /// 영업마스터를 조회할 때 정보를 한 번에 넘겨주기 위한 프로퍼티
        /// </summary>
        public SalesMasterVO salesmasterinfo
        {
            get
            {
                return new SalesMasterVO
                {
                    Deadline = dtpDeadline.Value.ToString("yyyy-MM-dd"),
                    UploadDate = dtpUploadDate.Value.ToString("yyyy-MM-dd"),
                    Order_Num = txtOrder_Num.Text,
                    Com_Name = cboCompany.Text,
                    Mat_Name = txtSubject_Name.Text
                };
            }
        }

        /// <summary>
        /// 수요 계획을 생성할 때 정보를 넘겨주기 위한 프로퍼티
        /// </summary>
        public DemandVO demandinfo
        {
            get
            {
                return new DemandVO
                {
                    Order_Num = dgvSalesMaster.CurrentRow.Cells[1].Value.ToString(),
                    SalesMaster_Num = dgvSalesMaster.CurrentRow.Cells[0].Value.ToString(),
                    FirstMan = dgvSalesMaster.CurrentRow.Cells[9].Value.ToString(),
                    LastMan = dgvSalesMaster.CurrentRow.Cells[11].Value.ToString(),
                    UploadDate = dgvSalesMaster.CurrentRow.Cells[8].Value.ToString()
                }
                ;
            }
        }

        public frmSalesMaster()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 데이터 그리드 뷰 컬럼 세팅
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesMaster_Load(object sender, EventArgs e)
        {
            dgvSalesMaster.SetGridViewColumn("영업마스터 번호", "SalesMaster_Num");
            dgvSalesMaster.SetGridViewColumn("주문 번호", "Order_Num");
            dgvSalesMaster.SetGridViewColumn("업체 번호", "Com_Num");
            dgvSalesMaster.SetGridViewColumn("업체 명", "Com_Name");
            dgvSalesMaster.SetGridViewColumn("품목 번호", "Mat_Num");
            dgvSalesMaster.SetGridViewColumn("품목명", "Mat_Name");
            dgvSalesMaster.SetGridViewColumn("수량", "Product_Cnt");
            dgvSalesMaster.SetGridViewColumn("납기일", "Deadline");
            dgvSalesMaster.SetGridViewColumn("업로드 날짜", "UploadDate");
            dgvSalesMaster.SetGridViewColumn("최초 등록자", "Firstman");
            dgvSalesMaster.SetGridViewColumn("최초 등록일", "FirstDate");
            dgvSalesMaster.SetGridViewColumn("최종 등록자", "Lastman");
            dgvSalesMaster.SetGridViewColumn("최종 등록일", "LastDate");
        }


        /// <summary>
        /// 컨트롤 포커스 받을시 콤보 박스 바인딩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboCompany_Enter(object sender, EventArgs e)
        {
            CompanyService service = new CompanyService();
            List<CompanyVO> companyList = service.GetEveryCompanyName();
            if (companyList != null)
            {

                //companyList.Insert(0, new CompanyVO {Com_Num = 0, Com_Name = "" });
                companyList.ForEach(p => cboCompany.ValueMember = p.Com_Num.ToString());
                companyList.ForEach(p => cboCompany.DisplayMember = p.Com_Name.ToString());
            }
        }

       


        /// <summary>
        /// 수요계획 생성 후 생산 계획과 자재 소요계획 자동으로 생성
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn3_Click_1(object sender, EventArgs e)
        {
            DemandPlanService service = new DemandPlanService();
            //수요 계획 생성
            if (!service.InsertDemandPlan(demandinfo))
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.InsertFail);
                //MessageBox.Show(BedFactory.Properties.Settings.Default.InsertSuccess);
            }
            //생성된 수요계획 PK
            string demandnum = service.getdemandNum();



            ProductionPlanService service2 = new ProductionPlanService();
            //마스터 생산 계획 생성
            if (!service2.InsertMasterProductionPlan(demandinfo, demandnum))
            {
                MessageBox.Show(BedFactory.Properties.Settings.Default.InsertFail);
            }
           
            //생성된 마스터 생산계획 PK
            int ProductionPlanNum = service2.GetPlanNum();

            MRPService service3 = new MRPService();
            List<BOMVO> list2 = service3.GetBOMInfo(demandinfo);
            bool BalzooFlag = false;
            int CurrentStock = Convert.ToInt32(list2[0].CurrentResourceStock);
            if (list2 != null)
            {
                for (int i=0;i<list2.Count; i++)
                {
                    //반제품 당 필요 원자재양을 현재 재고 양과 비교한다
                    if (CurrentStock >= Convert.ToInt32(list2[i].Resource_Cnt))
                    //현재 재고> 필요 원자재 >> 필요 원자재 양만큼 생산하다
                    {
                        service2.InsertDetailProductionPlan(demandinfo, Convert.ToInt32(list2[i].Resource_Cnt), list2[i].WP_Num, list2[i].Use_Mat_Num, ProductionPlanNum, i);
                        service3.InsertMaterialUsePlan(demandnum, list2[i].Use_Resource_Num, Convert.ToInt32(list2[i].Resource_Cnt));
                        CurrentStock = CurrentStock - Convert.ToInt32(list2[i].Resource_Cnt);
                    }
                    else
                    //현재 재고< 필요 원자재 >> 남은 만큼 발주를 넣어준다
                    {
                        BalzooService service4 = new BalzooService();
                        //처음 한 번만 발주 마스터를 생성
                        if (!BalzooFlag)
                        {
                            service4.InsertMasterBalzoo(5, 1);
                            BalzooFlag = true;
                        }
                        string expecteddate = DateTime.Now.AddDays(7).ToString("yyyy-MM-dd");
                        int Bz_Num= service4.GetBalzooNum();
                        Random rnd = new Random();
                        int randomNum = rnd.Next(0,100);
                        string Bz_D_Num = "A" + "0000000" + randomNum.ToString();
                        service4.InsertDetailBalzoo(Bz_D_Num, Bz_Num, list2[i].Use_Resource_Num, Convert.ToInt32(list2[i].Resource_Cnt), "N", expecteddate, "N");

                    }
                }

            }

            MessageBox.Show(BedFactory.Properties.Settings.Default.InsertSuccess);

        }

        /// <summary>
        /// 영업마스터 수동 생성
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2_Click_1(object sender, EventArgs e)
        {
            frmSalesOrder frm = new frmSalesOrder();
            frm.Show();
            frm.Activate();
        }

        /// <summary>
        /// 조회 버튼 클릭시 원하는 내용을 그리드 뷰에 바인딩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            SalesMasterService service = new SalesMasterService();
            List<SalesMasterVO> list = service.GetSalesMaster(salesmasterinfo);
            if (list != null)
            {
                dgvSalesMaster.DataSource = list;
            }
        }


    }
}
