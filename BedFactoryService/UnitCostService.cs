using BedFactoryDAC;
using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryService
{
    public class UnitCostService
    {
        public List<UnitCostVO> UnitCostSelect(string category, DateTime date)
        {
            UnitCostDAC dac = new UnitCostDAC();
            return dac.UnitCostSelect(category, date);
        }

        public int UnitCostInsert(UnitCostVO vo)
        {
            UnitCostDAC dac = new UnitCostDAC();
            return dac.UnitCostInsert(vo);
        }

        public int UnitCostUpdate(UnitCostVO vo)
        {
            UnitCostDAC dac = new UnitCostDAC();
            return dac.UnitCostUpdate(vo);
        }

        public List<CommonCodeVO> UnitCostCombo(string category)
        {
            UnitCostDAC dac = new UnitCostDAC();
            return dac.UnitCostCombo(category);
        }

        public bool UnitCostDelete(int num)
        {
            UnitCostDAC dac = new UnitCostDAC();
            return dac.UnitCostDelete(num);
        }
    }
}
