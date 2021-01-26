using BedFactoryDAC;
using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryService
{
    public class ShiftsService
    {
        public List<ShiftVO> ShiftsSelect()
        {
            ShiftsDAC dac = new ShiftsDAC();
            return dac.ShiftsSelect();
        }

        public int ShiftInsert(ShiftVO shift)
        {
            ShiftsDAC dac = new ShiftsDAC();
            return dac.ShiftInsert(shift);
        }

        public int ShiftUpdate(ShiftVO shift)
        {
            ShiftsDAC dac = new ShiftsDAC();
            return dac.ShiftUpdate(shift);
        }        

        public bool ShiftDelete(int num)
        {
            ShiftsDAC dac = new ShiftsDAC();
            return dac.ShiftDelete(num);
        }

        public List<ShiftVO> ShiftChangeSelect()
        {
            ShiftsDAC dac = new ShiftsDAC();
            return dac.ShiftChangeSelect();
        }

        public int ShiftChangeIandU(ShiftVO shift)
        {
            ShiftsDAC dac = new ShiftsDAC();
            return dac.ShiftChangeIandU(shift);
        }

    }
}
