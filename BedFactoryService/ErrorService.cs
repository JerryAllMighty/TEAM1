using BedFactoryDAC;
using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryService
{
    public class ErrorService
    {
        public List<ErrorHistoryVO> GetErrorHistory()
        {
            ErrorDAC dac = new ErrorDAC();
            return dac.GetErrorHistory();
        }
    }
}
