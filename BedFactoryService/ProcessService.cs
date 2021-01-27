using BedFactoryDAC;
using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryService
{
    public class ProcessService
    {
        public List<ProcessDetailVO> GetProcessDetailInfo(string prcName, string prcName_D)
        {
            ProcessDAC dac = new ProcessDAC();
            return dac.GetProcessDetailInfo(prcName, prcName_D);
        }
    }
}
