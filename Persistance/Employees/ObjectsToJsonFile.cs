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
    class ObjectsToJsonFile
    {
        public static void Save(IEnumerable<Employee> employees, string fileName)
        {
            string json = JsonConvert.SerializeObject(employees);
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
                writeJson(json, fileName);
            }
            else
            {
                writeJson(json, fileName);
            }
        }

        private static void writeJson(string json, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteAsync(json);
            }
        }
    }
}
