using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryVO
{
    public class OrderVO
    {
        public int Order_Num { get; set; }
        public DateTime Order_Date { get; set; }
        public string Order_Status { get; set; }
        public int Com_Num { get; set; }
        public string IsCanceled { get; set; }
        public int FirstMan { get; set; }
        public DateTime FirstDate { get; set; }
        public int LastMan { get; set; }
        public DateTime LastDate { get; set; }

        public string Com_Name { get; set; }
    }
}
