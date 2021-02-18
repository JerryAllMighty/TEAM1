using BedFactoryDAC;
using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryService
{
    public class ProductionPlanService
    {

        /// <summary>
        /// 작업지시생성 전에 생산계획 상세 정보를 가져온다
        /// </summary>
        /// <param name="productionplaninfo"></param>
        /// <param name="date"></param>
        /// <returns></returns>
             public List<ProductionPlanVO> GetProductionPlanDetail(string productiondate, string productionnum)
        {
            ProductionPlanDAC dac = new ProductionPlanDAC();
            return dac.GetProductionPlanDetail(productiondate, productionnum);
        }
        /// <summary>
        /// 생산 계획 마스터 만드는 함수
        /// </summary>
        /// <param name="demandinfo"></param>
        /// <param name="demandnum"></param>
        /// <returns></returns>
        public bool InsertMasterProductionPlan(DemandVO demandinfo,string demandnum)
        {
            ProductionPlanDAC dac = new ProductionPlanDAC();
            return dac.InsertMasterProductionPlan(demandinfo,demandnum);
        }

        /// <summary>
        /// 생산 계획 상세 만드는 함수
        /// </summary>
        /// <param name="demandinfo"></param>
        /// <param name="cnt"></param>
        /// <param name="list"></param>
        /// <param name="ProductionPlanNum"></param>
        /// <returns></returns>
        public bool InsertDetailProductionPlan(DemandVO demandinfo, int cnt, string WP_num, string Mat_Num, int ProductionPlanNum, int adddays)
        {
            ProductionPlanDAC dac = new ProductionPlanDAC();
            return dac.InsertDetailProductionPlan(demandinfo, cnt, WP_num, Mat_Num, ProductionPlanNum, adddays);
        }

        //public List<BOMVO> GetBOMInfo(DemandVO demandinfo)
        //{
        //    ProductionPlanDAC dac = new ProductionPlanDAC();
        //    return dac.GetBOMInfo(demandinfo);
        //}



        public List<ProductionPlanVO> GetProductionPlanInfo(ProductionPlanVO productionplaninfo, string date)
        {
            ProductionPlanDAC dac = new ProductionPlanDAC();
            return dac.GetProductionPlanInfo(productionplaninfo, date);
        }
        public int GetPlanNum()
        {
            ProductionPlanDAC dac = new ProductionPlanDAC();
            return dac.GetPlanNum();
        }
        

    }
}
