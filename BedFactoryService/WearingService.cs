using BedFactoryDAC;
using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryService
{
    public class WearingService
    {
        public List<WearingVO> WarehousingState(DateTime fromDate, DateTime toDate)
        {
            WearingDAC dac = new WearingDAC();
            return WarehousingState(fromDate, toDate);
        }
        public int WarehousingCancel(int wearingNum, int cancelCnt)
        {
            WearingDAC dac = new WearingDAC();
            return WarehousingCancel(wearingNum, cancelCnt);
        }
    }
}
