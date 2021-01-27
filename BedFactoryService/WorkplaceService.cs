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
        public List<WorkplaceVO> GetWorkplaceInfo(string prcName, string wpName)
        {
            WorkplaceDAC dac = new WorkplaceDAC();
            return dac.GetWorkplaceInfo(prcName, wpName);
        }

        public bool InsertWorkplaceInfo(WorkplaceVO vo)
        {
            WorkplaceDAC dac = new WorkplaceDAC();
            return dac.InsertWorkplaceInfo(vo);
        }
    }
}
