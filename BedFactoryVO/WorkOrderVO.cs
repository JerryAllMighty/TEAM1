using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryVO
{
    public class WorkOrderVO
    {
        public string WO_Num { get; set; }
        public string ProductionPlan_D_Num { get; set; }
        public string Process_Num { get; set; }
        public string WP_Num { get; set; }
        public string Mat_Num { get; set; }
        public string SalesMaster_Num { get; set; }
        public string WO_Status { get; set; }
        public string WO_Plan_Cnt { get; set; }
        public string WO_Order_Cnt { get; set; }
        public string WO_Detail { get; set; }
        public string IsShip { get; set; }
        public string WO_D_Emp_Num { get; set; }
        //작업 지시 테이블에는 존재하지 않지만 데이터를 활용하기 위해서 추가한 프로퍼티
        public string WorkCnt { get; set; }
        public string Error_Cnt { get; set; }

    }
}
