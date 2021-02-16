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
        public bool InsertPlanService(DemandVO demandinfo, List<BOMVO> list, string demandnum, int ProductionPlanNum)
        {
            ProductionPlanDAC dac = new ProductionPlanDAC();
            return dac.InsertProductionPlan(demandinfo, list, demandnum, ProductionPlanNum);
        }

        public List<BOMVO> GetBOMInfo(DemandVO demandinfo)
        {
            ProductionPlanDAC dac = new ProductionPlanDAC();
            return dac.GetBOMInfo(demandinfo);
        }


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
