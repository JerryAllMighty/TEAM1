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
        /// <summary>
        /// 검색 조건에 따라 수요계획을 가져오는 함수
        /// </summary>
        /// <param name="demandinfo"></param>
        /// <returns></returns>
        public List<DemandVO> GetDemandPlan(DemandVO demandinfo)
        {
            DemandPlanDAC dac = new DemandPlanDAC();
            return dac.GetDemandPlan(demandinfo);
        }

        /// <summary>
        /// 영업마스터로부터 수요 계획을 생성할 때 호출
        /// </summary>
        /// <param name="demandinfo"></param>
        /// <returns></returns>
        public bool InsertDemandPlan(DemandVO demandinfo)
        {
            DemandPlanDAC dac = new DemandPlanDAC();
            return dac.InsertDemandPlan(demandinfo);
        }
    }
}
