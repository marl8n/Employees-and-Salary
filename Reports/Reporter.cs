using Employees_and_Salaries.models;
using Employees_and_Salaries.Reports.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_and_Salaries.Reports
{
    class Reporter
    {
        public static IEnumerable<Report> MakeReport(IEnumerable<Employee> employees, IEnumerable<Salary> salaries)
        {
            // initialize reports list
            List<Report> reports = new List<Report>();

            // look for all the months that the employee works and add reports
            foreach (var employee in employees)
            {
                //list of all salaries where the Employee.Id is equal to the salary.EmployeeId
                List<Salary> employeeSalaries = salaries.ToList().Where(salary => salary.EmployeeId == employee.Id).ToList();

                //total of hours worked all months
                int hoursWorked = employeeSalaries.Sum(salary => salary.HoursAtMonth);

                // sum of all salaries for the employee
                double employeeSalary = ReportUtils.CalculateSalary(employee.HourlyWage, hoursWorked);

                // months that the employee worked
                int monthsWorked = employeeSalaries.Count;

                // creates and add a new report to the report's list
                reports.Add(
                    // string EmployeeId, string EmployeeName, double HourlyWage,
                    // int HoursWorked, double Salary,double AverageSalary
                    new Report(
                        employee.Id,
                        employee.Name,
                        employee.HourlyWage,
                        hoursWorked,
                        employeeSalary,
                        ReportUtils.CalculateAverageSalary(employeeSalary, monthsWorked)
                        )
                    );
            }

            // return the list with all the reports
            return reports;
        }
    }
}
