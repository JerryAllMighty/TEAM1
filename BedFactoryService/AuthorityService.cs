using BedFactoryDAC;
using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryService
{
    public class AuthorityService
    {
        /// <summary>
        /// 모든 권한에 관한 정보를 가져온다
        /// </summary>
        /// <returns></returns>
        public List<AuthorityVO> GetAuthorityInfo()
        {
            AuthorityDAC dac = new AuthorityDAC();
            return dac.GetAuthorityInfo();
        }

        public List<AuthorityVO> GetAuthorityInfoByGroupName(string GroupName)
        {
            AuthorityDAC dac = new AuthorityDAC();
            return dac.GetAuthorityInfoByGroupList(GroupName);
        }

    }
}
