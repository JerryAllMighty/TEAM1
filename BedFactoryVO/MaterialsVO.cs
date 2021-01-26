using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryVO
{
    public class MaterialsVO
    {
        public string Mat_Num { get; set; }
        public string Mat_Name { get; set; }
        public string Mat_Category { get; set; }
        public string Mat_Kind { get; set; }
        public string Mat_Size { get; set; }
        public int BOM_Num { get; set; }
        public int FirstMan { get; set; }
        public DateTime FirstDate { get; set; }
        public int LastMan { get; set; }
        public DateTime LastDate { get; set; }
    }
}
