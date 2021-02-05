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
        //회사정보조회
        public List<CompanyVO> GetCompanyInfo(string comCode, string comName)
        {
            CompanyDAC dac = new CompanyDAC();
            return dac.GetCompanyInfo(comCode, comName);
        }

        //회사정보등록
        public bool InsertCompnayInfo(CompanyVO vo)
        {
            CompanyDAC dac = new CompanyDAC();
            return dac.InsertCompnayInfo(vo);
        }

        //회사정보수정
        public bool UpdateCompnayInfo(CompanyVO vo)
        {
            CompanyDAC dac = new CompanyDAC();
            return dac.UpdateCompnayInfo(vo);
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
