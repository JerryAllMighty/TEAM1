using BedFactoryDAC;
using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryService
{
    public class WorkOrdersService
    {
        public WorkOrdersVO GetWorkOrdersInfo(DateTime dtFrom, DateTime dtTo, int wpName, string matName, string woStatus)
        {
            WorkOrdersDAC dac = new WorkOrdersDAC();
            return dac.GetWorkOrdersInfo(dtFrom, dtTo, wpName, matName, woStatus);
        }
    }
}
