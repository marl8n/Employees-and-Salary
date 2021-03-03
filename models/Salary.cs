using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_and_Salaries.models
{
    class Salary
    {
        public string EmployeeId { get; set; }
        public int HoursAtMonth { get; set; }
        public Months Month { get; set; }

        public Salary()
        {

        }

        public Salary(string EmpoyeeId, int HoursAtMonth, Months Month)
        {
            this.EmployeeId = EmpoyeeId;
            this.HoursAtMonth = HoursAtMonth;
            this.Month = Month;
        }
    }
}
