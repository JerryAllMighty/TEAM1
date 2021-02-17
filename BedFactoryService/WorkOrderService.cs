using BedFactoryDAC;
using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryService
{
    public class WorkOrderService
    {
        /// <summary>
        /// 공정 번호로 작업 지시 가져오기
        /// </summary>
        /// <param name="ProcessCode"></param>
        /// <returns></returns>
        public List<WorkOrderVO> GetWorkOrder(string ProcessCode)
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.GetWorkOrder(ProcessCode);
        }

        /// <summary>
        /// 작업 지시에 작업자 새롭게 할당
        /// </summary>
        /// <returns></returns>
        public bool UpdateWorkOrder(List<WorkOrderVO> WOList, List<EmployeeVO> EmpList)
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.UpdateWorkOrder(WOList, EmpList);
        }

        /// <summary>
        /// 작업 지시 상태를 작업마감으로 변경
        /// </summary>
        /// <returns></returns>
        public bool FinishWorkOrder(string WO_Num)
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.FinishWorkOrder(WO_Num);
        }

        /// <summary>
        /// 작업지시정보조회
        /// </summary>
        /// <param name="wpNum"></param>
        /// <param name="matNum"></param>
        /// <param name="wsNum"></param>
        /// <param name="dtFrom"></param>
        /// <param name="dtTo"></param>
        /// <returns></returns>
        public List<WorkOrderVO> GetWorkOrdersInfo(int wpNum, string matNum, int wsNum, string dtFrom, string dtTo)
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.GetWorkOrdersInfo(wpNum, matNum, wsNum, dtFrom, dtTo);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public bool DeleteWorkOrdersInfo(List<int> nums)
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.DeleteWorkOrdersInfo(nums);
        }

        /// <summary>
        /// 작업지시상태 업데이트
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public bool UpdateStatusWorkOrdersInfo(List<int> nums)
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.UpdateStatusWorkOrdersInfo(nums);
        }


        //자재코드정보조회
        public List<WorkOrderVO> GetMatCodeInfo(string matNum)
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.GetMatCodeInfo(matNum);
        }

        //작업지시확성 일자 등록
        public bool UpdateWorkOrderDate(List<int> vo)
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.UpdateWorkOrderDate(vo);
        }


        // 작업지시현황조회
        public List<WorkOrderStatusVO> GetWorkOrdersStatusInfo(int wpNum, string matNum, int wsNum, string dtFrom, string dtTo)
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.GetWorkOrdersStatusInfo(wpNum, matNum, wsNum, dtFrom, dtTo);
        }
    }
}
