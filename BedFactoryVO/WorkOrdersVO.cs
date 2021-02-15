using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryVO
{
    public class WorkOrdersVO
    {
        public int WO_Num { get; set; }
        public int Process_Name_D { get; set; }
        public int WP_Name { get; set; }
        public string Mat_Name { get; set; }
        public string WO_Status { get; set; }
        public int WO_Plan_Cnt { get; set; }
        public int WO_Order_Cnt { get; set; }
        public string WO_Detail { get; set; }
        public string IsShip { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime DeadLine { get; set; }
    }
}
