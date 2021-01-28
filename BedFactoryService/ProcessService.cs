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
        public List<ProcessVO> GetProcessInfo(string prcCategory, string prcName)
        {
            ProcessDAC dac = new ProcessDAC();
            return dac.GetProcessInfo(prcCategory, prcName);
        }

        public bool InsertProcessInfo(ProcessVO vo)
        {
            ProcessDAC dac = new ProcessDAC();
            return dac.InsertProcessInfo(vo);
        }

        public bool UpdateProcessInfo(ProcessVO vo)
        {
            ProcessDAC dac = new ProcessDAC();
            return dac.UpdateProcessInfo(vo);
        }

        /// <summary>
        /// 공정명조회
        /// </summary>
        /// <returns></returns>
        public List<CommonCodedVO> GetProcessCombo()
        {
            ProcessDAC dac = new ProcessDAC();
            return dac.GetProcessCombo();
        }
    }
}
