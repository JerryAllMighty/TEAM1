using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedFactoryVO
{
    public class EmployeeVO
    {
        public int Emp_Num { get; set; }
        public string Emp_Category { get; set; }
        public string Emp_Name { get; set; }
        public string Emp_Department { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string Emp_ID { get; set; }
        public string Emp_Pwd { get; set; }
        public string Emp_Phone { get; set; }
        public DateTime Emp_Birth { get; set; }
        public string Emp_Email { get; set; }
        public string Emp_Addr { get; set; }
        public int ListNum { get; set; }
        public int FirstMan { get; set; }
        public DateTime FirstDate { get; set; }
        public int LastMan { get; set; }
        public DateTime LastDate { get; set; }
        public string IsDeleted { get; set; }
    }
}
