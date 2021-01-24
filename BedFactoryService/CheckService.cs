using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BedFactoryVO;
using BedFactoryDAC;

namespace BedFactoryService
{
    public class CheckService
    {
        public bool InsertCheckInfo(CheckInfoVO vo)
        {
            CheckDAC dac = new CheckDAC();
            return dac.InsertCheckInfo(vo);
        }

        public bool UpdateCheckInfo(CheckInfoVO vo)
        {
            CheckDAC dac = new CheckDAC();
            return dac.UpdateCheckInfo(vo);
        }
    }
}
