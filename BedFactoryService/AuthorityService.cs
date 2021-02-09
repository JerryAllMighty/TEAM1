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

        /// <summary>
        /// 그룹이름으로 해당 그룹에 해당하는 권한 정보를 가져온다
        /// </summary>
        /// <param name="GroupName"></param>
        /// <returns></returns>
        public List<AuthorityVO> GetAuthorityInfoByGroupName(string GroupName)
        {
            AuthorityDAC dac = new AuthorityDAC();
            return dac.GetAuthorityInfoByGroupList(GroupName);
        }

        /// <summary>
        /// 추가할 권한을 DB에 저장
        /// </summary>
        /// <returns></returns>
        public bool InsertAuthority(List<AuthorityVO> list)
        {
            AuthorityDAC dac = new AuthorityDAC();
            return dac.InsertAuthority(list);
        }

        /// <summary>
        /// 그룹코드로 권한리스트 번호 가져오는 함수
        /// </summary>
        /// <param name="GroupName"></param>
        /// <returns></returns>
        public int GetAuthorityListNum(string GroupCode)
        {
            AuthorityDAC dac = new AuthorityDAC();
            return dac.GetAuthorityListNum(GroupCode);
        }
    }
}
