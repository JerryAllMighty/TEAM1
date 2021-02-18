using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryVO
{
    public class ProductionPlanVO
    {
        public string ProductionPlan_Num { get; set; }
        public string Demand_Plan_Num { get; set; }
        public string Firstman { get; set; }
        public string FirstDate { get; set; }
        public string LastMan { get; set; }
        public string LastDate { get; set; }
        public string ProductionPlan_D_Num { get; set; }
        public string ProductionDate { get; set; }
        public string ProductionCnt { get; set; }
        public string WP_Num { get; set; }
        public string Mat_Num { get; set; }
        public string Mat_Name { get; set; }
        public string WP_Name { get; set; }
    }
}
