using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryVO
{
    public class DemandVO
    {
        public int Demand_Plan_Num { get; set; }
        public int Order_Num { get; set; }
        public string Mat_Num { get; set; }
        public int FirstMan { get; set; }
        public DateTime FirstDate { get; set; }
        public int LastMan { get; set; }
        public DateTime LastDate { get; set; }


    }
}
