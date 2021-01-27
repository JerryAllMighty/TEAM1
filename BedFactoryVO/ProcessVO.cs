using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryVO
{
    public class ProcessVO
    {
        public int Process_Num { get; set; }
        public string Process_Category { get; set; }
        public string Process_Category_Name { get; set; }
        public string Process_Name { get; set; }
        public string Process_Condition { get; set; }
        public int Firstman { get; set; }
        public DateTime Firstdate { get; set; }
        public int Lastman { get; set; }
        public DateTime Lastdate { get; set; }
        public string IsDeleted { get; set; }
    }
}

