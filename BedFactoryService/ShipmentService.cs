using BedFactoryDAC;
using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryService
{
    public class ShipmentService
    {
        public List<ShipmentVO> AutoShipLoad(DateTime fromDate, DateTime toDate)
        {
            ShipmentDAC dac = new ShipmentDAC();
            return dac.AutoShipLoad(fromDate, toDate);
        }
    }
}
