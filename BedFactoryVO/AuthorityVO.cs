using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryVO
{
    public class AuthorityVO
    {
        public int ListNum { get; set; }
        public string Auth_Department { get; set; }
        public int Auth_Num { get; set; }
        public string Auth_Name { get; set; }
        public int FirstMan { get; set; }
        public DateTime FirstDate { get; set; }
        public int LastMan { get; set; }
        public DateTime LastDate { get; set; }
        public string IsDeleted { get; set; }

    }
}
