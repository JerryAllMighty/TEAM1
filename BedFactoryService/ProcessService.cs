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
        public List<ProcessDetailVO> GetProcessDetailInfo(string procCate, string procdNum)
        {
            ProcessDAC dac = new ProcessDAC();
            return dac.GetProcessDetailInfo(procCate, procdNum);
        }
    }
}
