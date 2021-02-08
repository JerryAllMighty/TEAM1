using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryVO
{
    public class SalesMasterVO
    {
        public string SalesMaster_Num { get; set; }
        public string Order_Num { get; set; }
        public string TotalCnt { get; set; }
        public string Deadline { get; set; }
        public string UploadDate { get; set; }
        public string Firstman { get; set; }
        public string FirstDate { get; set; }
        public string Lastman { get; set; }
        public string LastDate { get; set; }
        //검색 조건에 활용하기 위한 프로퍼티
        public string Com_Name { get; set; }
        public string Mat_Name { get; set; }
        //검색 창에 보여주기 위해 사용되는 프로퍼티
        public string Com_Num { get; set; }
        public string Mat_Num { get; set; }
        public string Product_Cnt { get; set; }



    }
}
