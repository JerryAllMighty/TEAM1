using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryVO
{
    public class BORVO
    {
        public int Process_Num { get; set; }
        public int WP_Num { get; set; }
        public string Mat_Num { get; set; }
        public int BOR_Num { get; set; }
        public string Process_Name_D { get; set; }
        public string WP_Name { get; set; }
        public string Mat_Category { get; set; }
        public string Mat_Name { get; set; }
        public int Tact_Time { get; set; }
        public string IsUse { get; set; }
        public string BOR_Comment { get; set; }
        public int Lastman { get; set; }
        public DateTime Lastdate { get; set; }
        public int Firstman { get; set; }
        public DateTime Firstdate { get; set; }
    }
}
