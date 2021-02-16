using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryVO
{
    public class ErrorHistoryVO
    {
        public string WH_Num { get; set; }
        public int WO_Num { get; set; }
        public int WorkCnt { get; set; }
        public string ErrorKind { get; set; }
        public int ErrorCnt { get; set; }
        public int Firstman { get; set; }
        public DateTime Firstdate { get; set; }
        public decimal Persent { get; set; }
        public string Mat_Name { get; set; }
        public string Mat_Category { get; set; }
    }
}
