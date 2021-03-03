using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_and_Salaries.models
{
    class Employee : User
    {
        public double HourlyWage { get; set; }
        public Employee(string name, double hourlyWage)
        {
            this.Id = Guid.NewGuid().ToString();
            this.Name = name;
            this.HourlyWage = hourlyWage;
        }
        public Employee()
        {

        }
    }
}
