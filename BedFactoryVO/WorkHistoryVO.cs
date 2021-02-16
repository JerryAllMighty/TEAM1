using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryVO
{
    public class WorkHistoryVO
    {
        public string WH_Num { get; set; }
        public string WO_Num { get; set; }
        public string WorkCnt { get; set; }
        public string Firstman { get; set; }
        public string Firstdate { get; set; }
        //작업 시간도 작업지시 테이블에 함께 넘겨주기 위해 아래의 프로퍼티들을 사용한다
        public string WO_StartTime { get; set; }
        public string WO_FinishTime { get; set; }
    }
}
