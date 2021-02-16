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

        public List<CheckInfoVO> GetCheckInfo()
        {
            CheckDAC dac = new CheckDAC();
            return dac.GetCheckInfo();
        }

        public List<CheckVO> GetCheck(string mat_Num)
        {
            CheckDAC dac = new CheckDAC();
            return dac.GetCheck(mat_Num);
        }

        public bool InsertCheck(string mat_Num, int check_Info_Num, int lastMan)
        {
            CheckDAC dac = new CheckDAC();
            return dac.InsertCheck(mat_Num, check_Info_Num, lastMan);
        }

        public bool DeleteCheck(string mat_Num)
        {
            CheckDAC dac = new CheckDAC();
            return dac.DeleteCheck(mat_Num);
        }

        public bool DeleteCheckInfo(int checkInfoNum)
        {
            CheckDAC dac = new CheckDAC();
            return dac.DeleteCheckInfo(checkInfoNum);
        }
    }
}
