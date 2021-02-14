using BedFactoryDAC;
using BedFactoryVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryService
{
    public class EmployeesService
    {
        /// <summary>
        /// 작업장 번호를 이용하여 작업이 가능한 직원들의 리스트를 가져온다
        /// </summary>
        /// <param name="WPNum"></param>
        public List<EmployeeVO> GetEmployeeListByWPNum(string WPNum)
        {
            EmployeeDAC dac = new EmployeeDAC();
            return dac.GetEmployeeListByWPNum(WPNum);

        }

    }
}
