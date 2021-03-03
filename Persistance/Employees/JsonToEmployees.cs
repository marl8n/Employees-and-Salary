using Employees_and_Salaries.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_and_Salaries.Persistance.Employees
{
    class JsonToEmployees
    {
        public static IEnumerable<Employee> LoadFromFileOrNewList (string fileName)
        {
            List<Employee> employees = new List<Employee>();
            if (File.Exists(fileName))
            {
                string jsonList = "";
                using (StreamReader sr = new StreamReader(fileName))
                {
                    jsonList = sr.ReadToEnd();
                }
                if (!(jsonList.Equals("")))
                {
                    employees = JsonConvert.DeserializeObject<List<Employee>>(jsonList);
                }
            }
            return employees;
        }
    }
}
