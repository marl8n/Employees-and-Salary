using Employees_and_Salaries.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_and_Salaries.Reports.Utils
{
    class ReportUtils
    {
        public static double CalculateSalary (double HourlyWage, int HoursWorked)
        {
            return Math.Round(HoursWorked * HourlyWage, 2);
        }


        public static double CalculateAverageSalary (double Salary, int Months)
        {
            return Math.Round(Salary / Months, 2);
        }


        public static double CalculateSalary (IEnumerable<Salary> salaries, Employee employee)
        {
            return Math.Round(salaries.ToList().Sum(salary => salary.HoursAtMonth * employee.HourlyWage), 2);
        }
    }
}
