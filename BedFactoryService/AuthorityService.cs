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
        public List<AuthorityVO> GetAuthorityInfo()
        {
            AuthorityDAC dac = new AuthorityDAC();
            return dac.GetAuthorityInfo();
        }

    }
}
