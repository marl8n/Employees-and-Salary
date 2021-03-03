using Employees_and_Salaries.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_and_Salaries.Persistance.Salaries
{
    class JsonToSalaries
    {
        public static IEnumerable<Salary> LoadFromFileOrNewList(string fileName)
        {
            List<Salary> salaries = new List<Salary>();

            if (File.Exists(fileName))
            {
                string json = "";
                using (StreamReader sr = new StreamReader(fileName))
                {
                    json = sr.ReadToEnd();
                    salaries = JsonConvert.DeserializeObject<List<Salary>>(json);
                }
            }

            return salaries;
        }
    }
}
