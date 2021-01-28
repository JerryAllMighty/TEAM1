using BedFactoryDAC;
using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryService
{
    public class CommonCodeService
    {
        /// <summary>
        /// 공통코드 정보를 모두 가져옴
        /// </summary>
        /// <returns></returns>
        public List<CommonCodeVO> GetCommonCodeInfo()
        {
            CommonCodeDAC dac = new CommonCodeDAC();
            return dac.GetCommonCodeInfo();
        }

        public bool InsertCommonCode(CommonCodeVO commoncodeinfo)
        {
            CommonCodeDAC dac = new CommonCodeDAC();
            return dac.InsertCommonCode(commoncodeinfo);
        }

        public bool UpdateCommonCode(CommonCodeVO commoncodeinfo, string currentCodeNum)
        {
            CommonCodeDAC dac = new CommonCodeDAC();
            return dac.UpdateCommonCode(commoncodeinfo, currentCodeNum);
        }

        public bool DeleteCommonCode(CommonCodeVO commoncodeinfo)
        {
            CommonCodeDAC dac = new CommonCodeDAC();
            return dac.DeleteCommonCode(commoncodeinfo);
        }

    }
}
