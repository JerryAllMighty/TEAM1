using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BedFactoryVO;
using BedFactoryDAC;

namespace BedFactoryService
{
    public class BOMService
    {
        public List<BOMVO> GetBOM(string mat_Num)
        {
            BOMDAC dac = new BOMDAC();
            return dac.GetBOM(mat_Num);
        }
    }
}
