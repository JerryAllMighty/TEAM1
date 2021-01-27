using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryVO
{
    public class WorkplaceVO
    {
        public int WP_Num { get; set; }
        public int Process_Num { get; set; }
        public string WP_Name { get; set; }
        public string IsDeleted { get; set; }
        public string WP_Note { get; set; }
        public string WP_Other { get; set; }
        public int Firstman { get; set; }
        public DateTime Firstdate { get; set; }
        public int Lastman { get; set; }
        public DateTime Lastdate { get; set; }
   
    }
}
