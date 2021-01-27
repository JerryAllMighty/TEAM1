using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryVO
{
    public class CompanyVO
    {
        public int Com_Num { get; set; }
        public string Com_Name { get; set; }
        public string Com_Addr { get; set; }
        public string Com_Represent { get; set; }
        public string Com_Phone { get; set; }
        public string Com_Category { get; set; }
        public int Com_Emp_Num { get; set; }
        public int FirstMan { get; set; }
        public string Com_Info { get; set; }
        public DateTime FirstDate { get; set; }
        public int LastMan { get; set; }
        public DateTime LastDate { get; set; }
    }
}
