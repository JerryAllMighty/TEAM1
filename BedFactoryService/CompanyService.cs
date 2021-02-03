using BedFactoryDAC;
using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryService
{
    public class CompanyService
    {
        public List<CompanyVO> GetCompanyInfo(string comNum, string comName, string comType)
        {
            CompanyDAC dac = new CompanyDAC();
            return GetCompanyInfo(comNum, comName, comType);
        }
        /// <summary>
        /// 모든 회사 정보를 가져오는 함수
        /// </summary>
        /// <param name="comNum"></param>
        /// <param name="comName"></param>
        /// <param name="comType"></param>
        /// <returns></returns>
        public List<CompanyVO> GetEveryCompanyName()
        {
            CompanyDAC dac = new CompanyDAC();
            return dac.GetEveryCompanyName();
        }
    }
}
