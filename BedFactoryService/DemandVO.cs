using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryVO
{
    public class DemandVO
    {
        public string Demand_Plan_Num { get; set; }
        public string Order_Num { get; set; }
        public string SalesMaster_Num { get; set; }
        public string FirstMan { get; set; }
        public string FirstDate { get; set; }
        public string LastMan { get; set; }
        public string LastDate { get; set; }
        //수요계획 검색 조건에 활용되는 프로퍼티
        public string Com_Name { get; set; }
        public string Mat_Name { get; set; }


    }
}
