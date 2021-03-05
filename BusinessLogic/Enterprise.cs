using Employees_and_Salaries.models;
using Employees_and_Salaries.Persistance.Employees;
using Employees_and_Salaries.Persistance.ReportsPersistance;
using Employees_and_Salaries.Persistance.Salaries;
using Employees_and_Salaries.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_and_Salaries.BusinessLogic
{
    class Enterprise
    {
        public List<Employee> Employees { get; set; }
        public List<Salary> Salaries { get; set; }
        public List<Report> Reports { get; set; }

        public Enterprise(string employeesFile = "employees.json", string salariesFile = "salaries.json", string reportsFile = "reports.json")
        {
            this.Employees = JsonToEmployees.LoadFromFileOrNewList(employeesFile).ToList();
            this.Salaries = JsonToSalaries.LoadFromFileOrNewList(salariesFile).ToList();
            this.Reports = JsonToReports.LoadFromFileOrNewList(reportsFile).ToList();
        }

        public Employee AddEmployee(Employee employee)
        {
            this.Employees.Add(employee);
            return employee;
        }

        public Employee GetEmployee(string Id)
        {
            return Employees.Where(Employee => Employee.Id == Id).First();
        }

        public Salary AddSalary(Salary salary)
        {
            this.Salaries.Add(salary);
            return salary;
        }

        public Report GetReport(string id)
        {
            try
            {

                return Reports.Where(report => report.EmployeeId == id).First();
            } 
            catch
            {
                return new Report(id, "Not founded", 0.0, 0, 0.0, 0.0);
            }
        }

        public List<Report> MakeReports ()
        {
            Reports.Clear();
            Reports = Reporter.MakeReport(Employees, Salaries).ToList();
            return this.Reports;
        }

        public IEnumerable<Dictionary<string, string>> ReportsByMonth()
        {
            return Reporter.MakeReportByMonth(this.Employees, this.Salaries);
        }

        public void SaveEmployees(string fileName = "employees.json")
        {
            ObjectsToJsonFile.Save(Employees, fileName);
        }

        public void SaveSalaries(string fileName = "salaries.json")
        {
            SalariesToJsonFile.Save(Salaries, fileName);
        }

        public void SaveReports(string fileName = "reports.json")
        {
            ReportsToJsonFile.Save(Reports, fileName);
        }

        public void SaveAll(string employeesFile = "employees.json", string salariesFile = "salaries.json", string reportsFile = "reports.json")
        {
            MakeReports();
            SaveEmployees(employeesFile);
            SaveSalaries(salariesFile);
            SaveReports(reportsFile);
        }
    }
}
