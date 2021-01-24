using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryVO
{
    
    public class CheckInfoVO
    {
        public int Check_Info_Num { get; set; }
        public string CheckKind { get; set; }
        public string Check_Detail { get; set; }
        public int Firstman { get; set; }
        public DateTime Firstdate { get; set; }
        public int Lastman { get; set; }
        public DateTime Lastdate { get; set; }
    }
}
