using BedFactoryDAC;
using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryService
{
    public class BalzooService
    {
        public List<BalzooVO> BalzooSelect(DateTime fromDate, DateTime toDate)
        {
            BalzooDAC dac = new BalzooDAC();
            return dac.BalzooSelect(fromDate, toDate);
        }

        public List<BalzooVO> WarehousingWait(DateTime fromDate, DateTime toDate)
        {
            BalzooDAC dac = new BalzooDAC();
            return dac.WarehousingWait(fromDate, toDate);
        }

        public bool StateIsWait(WearingVO vo)
        {
            BalzooDAC dac = new BalzooDAC();
            return dac.StateIsWait(vo);
        }
    }
}
