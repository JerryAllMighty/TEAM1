using BedFactoryDAC;
using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryService
{
    public class DemandPlanService
    {
        public bool InsertDemandPlan(DemandVO demandinfo)
        {
            DemandPlanDAC dac = new DemandPlanDAC();
            return dac.InsertDemandPlan(demandinfo);
        }
    }
}
