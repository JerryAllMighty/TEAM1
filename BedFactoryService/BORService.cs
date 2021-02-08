using BedFactoryDAC;
using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryService
{
    public class BORService
    {
        //전체정보
        public List<BORVO> GetBORAllInfo()
        {
            BORDAC dac = new BORDAC();
            return dac.GetBORAllInfo();
        }

        //조회
        public List<BORVO> GetBorInfo(int prcNum, int wpNum, string matName)
        {
            BORDAC dac = new BORDAC();
            return dac.GetBorInfo(prcNum, wpNum, matName);
        }

        //등록
        public bool InsertBORInfo(BORVO vo)
        {
            BORDAC dac = new BORDAC();
            return dac.InsertBORInfo(vo);
        }

        //수정
        public bool UpdateBORInfo(BORVO vo)
        {
            BORDAC dac = new BORDAC();
            return dac.UpdateBORInfo(vo);
        }

        //삭제
        public bool DeleteBORInfo(int num)
        {
            BORDAC dac = new BORDAC();
            return dac.DeleteBORInfo(num);
        }
    }
}


