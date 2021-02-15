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

        public List<BalzooVO> BalzooAndM_Use(int dNum)
        {
            BalzooDAC dac = new BalzooDAC();
            return dac.BalzooAndM_Use(dNum);
        }

        public List<BalzooVO> SearchPlanNum()
        {
            BalzooDAC dac = new BalzooDAC();
            return dac.SearchPlanNum();
        }

        public List<BalzooVO> BalzooCompany()
        {
            BalzooDAC dac = new BalzooDAC();
            return dac.BalzooCompany();
        }

        public bool BalzooInsert(List<BalzooVO> list, int comNum, int id)
        {
            BalzooDAC dac = new BalzooDAC();
            return dac.BalzooInsert(list, comNum, id);
        }

        public bool BalzooDateUpdate(List<string> list, DateTime date)
        {
            BalzooDAC dac = new BalzooDAC();
            return dac.BalzooDateUpdate(list, date);
        }

        public bool BalzooCancel(List<string> list)
        {
            BalzooDAC dac = new BalzooDAC();
            return dac.BalzooCancel(list);
        }
    }
}
