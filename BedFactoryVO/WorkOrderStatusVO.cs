using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryVO
{
    public class WorkOrderStatusVO
    {
        public DateTime WO_Date { get; set; }
        public string WP_Name { get; set; }
        public string Mat_Num { get; set; }
        public string Mat_Name { get; set; }
        public string WO_Status { get; set; }
        public string Str_Kind { get; set; }
        public int WO_Order_Cnt { get; set; }
        public int ErrorCnt { get; set; }
        public int GoodsCnt { get; set; }
    }
}
