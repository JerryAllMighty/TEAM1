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
    }
}
