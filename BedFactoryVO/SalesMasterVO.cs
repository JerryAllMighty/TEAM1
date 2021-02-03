using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryVO
{
    public class SalesMasterVO
    {
        public int SalesMaster_Num { get; set; }
        public int MasterVersion_Num { get; set; }
        public int WO_Num { get; set; }
        public int Com_Num { get; set; }
        public string Mat_Name { get; set; }
        public int TotalCnt { get; set; }
        public int Ship_Cnt { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime UploadDate { get; set; }
        public int Firstman { get; set; }
        public DateTime FirstDate { get; set; }
        public int Lastman { get; set; }
        public DateTime LastDate { get; set; }


    }
}
