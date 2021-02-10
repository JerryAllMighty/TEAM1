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
        public List<ProcessVO> GetProcessInfo(string prcCode, string prcName)
        {
            ProcessDAC dac = new ProcessDAC();
            return dac.GetProcessInfo(prcCode, prcName);
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

        public bool DeleteProcessInfo(int num)
        {
            ProcessDAC dac = new ProcessDAC();
            return dac.DeleteProcessInfo(num);
        }


        // 상세공정명 데이터를 콤보박스에 가져오기
        public List<CommonCodeVO> GetProcessCombo()
        {
            ProcessDAC dac = new ProcessDAC();
            return dac.GetProcessCombo();
        }
    }
}
