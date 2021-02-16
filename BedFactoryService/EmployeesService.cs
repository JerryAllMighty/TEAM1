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

        public List<EmployeeVO> Login(string id, string pw)
        {
            EmployeeDAC dac = new EmployeeDAC();
            return dac.Login(id, pw);
        }
        /// <summary>
        /// 직원 이름으로 검색해온다
        /// </summary>
        /// <param name="WPNum"></param>
        /// <returns></returns>
        public List<EmployeeVO> GetEmployeeListByEmpName(string EmpName)
        {
            EmployeeDAC dac = new EmployeeDAC();
            return dac.GetEmployeeListByEmpName(EmpName);
        }

        public List<EmployeeVO> GetMembersofGroup(string GroupName)
        {
            EmployeeDAC dac = new EmployeeDAC();
            return dac.GetMembersofGroup(GroupName);
        }

    }
}
