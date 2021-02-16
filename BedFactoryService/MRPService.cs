using BedFactoryDAC;
using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryService
{
    public class MRPService
    {
        public List<BOMVO> GetBOMInfo(DemandVO demandinfo)
        {
            MRPDAC dac = new MRPDAC();
            return dac.GetBOMInfo(demandinfo);
        }

        /// <summary>
        /// 자재 소요 계획 생성 함수
        /// </summary>
        /// <param name="demandnum"></param>
        /// <param name="Use_Resource_Num"></param>
        /// <param name="Resource_Cnt"></param>
        /// <returns></returns>
         public bool InsertMaterialUsePlan(string demandnum, string Use_Resource_Num, int Resource_Cnt)
        {
            MRPDAC dac = new MRPDAC();
            return dac.InsertMaterialUsePlan(demandnum, Use_Resource_Num, Resource_Cnt);
        }
    }
}
