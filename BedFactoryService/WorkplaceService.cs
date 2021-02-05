using BedFactoryDAC;
using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryService
{
    public class WorkplaceService
    {
        // 조회
        public List<WorkplaceVO> GetWorkplaceInfo(int prcNum, string wpName)
        {
            WorkplaceDAC dac = new WorkplaceDAC();
            return dac.GetWorkplaceInfo(prcNum, wpName);
        }

        // 등록
        public bool InsertWorkplaceInfo(WorkplaceVO vo)
        {
            WorkplaceDAC dac = new WorkplaceDAC();
            return dac.InsertWorkplaceInfo(vo);
        }

        // 수정
        public bool UpdateWorkplaceInfo(WorkplaceVO vo)
        {
            WorkplaceDAC dac = new WorkplaceDAC();
            return dac.UpdateWorkplaceInfo(vo);
        }


        /// <summary>
        /// 작업장명을 가져옴
        /// </summary>
        /// <returns></returns>
        public List<CommonCodeVO> GetWorkplaceCombo()
        {
            WorkplaceDAC dac = new WorkplaceDAC();
            return dac.GetWorkplaceCombo();
        }
    }
}
