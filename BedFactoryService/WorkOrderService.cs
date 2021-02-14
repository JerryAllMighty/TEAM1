using BedFactoryDAC;
using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryService
{
    public class WorkOrderService
    {
        public List<WorkOrderVO> GetWorkOrder(string ProcessCode)
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.GetWorkOrder(ProcessCode);
        }

    }
}
