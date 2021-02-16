using BedFactoryDAC;
using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryService
{
    public class WorkHistoryService
    {
        public bool UpdateWorkHistoryCnt(WorkHistoryVO workhistoryinfo, string ErrorKind, int ErrorCnt)
        {
            WorkHistoryDAC dac = new WorkHistoryDAC();
            return dac.UpdateWorkHistoryCnt(workhistoryinfo, ErrorKind, ErrorCnt);
        }
    }
}
