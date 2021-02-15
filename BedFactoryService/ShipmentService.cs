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

        public List<ShipmentVO> WorkOrdersLoad(DateTime fromDate, DateTime toDate)
        {
            ShipmentDAC dac = new ShipmentDAC();
            return dac.WorkOrdersLoad(fromDate, toDate);
        }

        public List<ShipmentVO> WorkOrdersByShip(int woNum)
        {
            ShipmentDAC dac = new ShipmentDAC();
            return dac.WorkOrdersByShip(woNum);
        }

        public bool InsertShipment(ShipmentVO vo, int id)
        {
            ShipmentDAC dac = new ShipmentDAC();
            return dac.InsertShipment(vo, id);
        }

        public bool ShipmentFinish(string num)
        {
            ShipmentDAC dac = new ShipmentDAC();
            return dac.ShipmentFinish(num);
        }
    }
}
