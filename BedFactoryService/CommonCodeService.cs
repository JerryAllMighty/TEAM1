using BedFactoryDAC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryService
{
    public class CommonCodeService
    {
        public DataTable GetCommonCodeInfo()
        {
            CommonCodeDAC dac = new CommonCodeDAC();
            return dac.GetCommonCodeInfo();
        }

    }
}
