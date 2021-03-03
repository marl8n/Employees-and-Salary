using Employees_and_Salaries.Reports.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_and_Salaries.Reports
{
    class Report
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public double HourlyWage { get; set; }
        public int HoursWorked { get; set; }
        public double Salary { get; set; }
        public double AverageSalary { get; set; }
        public Report()
        {

        }
        public Report(string EmployeeId, string EmployeeName, double HourlyWage, int HoursWorked, double Salary,double AverageSalary)
        {
            this.EmployeeId = EmployeeId;
            this.EmployeeName = EmployeeName;
            this.HourlyWage = HourlyWage;
            this.HoursWorked = HoursWorked;
            this.Salary = Salary;
            this.AverageSalary = AverageSalary;
        }
    }
}
