using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryVO
{
    public class BOMVO
    {
        public int BOM_Num { get; set; }
        public string Mat_Num { get; set; }
        public string Use_Mat_Num { get; set; }
        public int Cnt { get; set; }
        public int Firstman { get; set; }
        public DateTime Firstdate { get; set; }
        public int Lastman { get; set; }
        public DateTime Lastdate { get; set; }
        public string IsDeleted { get; set; }

        public string Mat_Name { get; set; }
        public string Mat_Category { get; set; }
        public string WP_Name { get; set; }
        public string WP_Num { get; set; }
        public string Use_Resource_Num { get; set; }
        public string Resource_Cnt { get; set; }
        public string CurrentResourceStock { get; set; }

    }
}
