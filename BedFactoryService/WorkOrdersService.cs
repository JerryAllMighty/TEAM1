using BedFactoryDAC;
using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryService
{
    public class WorkOrdersService
    {
        public List<WorkOrdersVO> GetWorkOrdersInfo(int wpNum, string matNum, int wsNum, DateTime dtFrom, DateTime dtTo)
        {
            WorkOrdersDAC dac = new WorkOrdersDAC();
            return dac.GetWorkOrdersInfo(wpNum, matNum, wsNum, dtFrom, dtTo);
        }

        public bool DeleteWorkOrdersInfo(int num)
        {
            WorkOrdersDAC dac = new WorkOrdersDAC();
            return dac.DeleteWorkOrdersInfo(num);
        }

        /// <summary>
        /// 작업지시상태 업데이트
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public bool UpdateStatusWorkOrdersInfo(List<int> nums)
        {
            WorkOrdersDAC dac = new WorkOrdersDAC();
            return dac.UpdateStatusWorkOrdersInfo(nums);
        }
    }
}
