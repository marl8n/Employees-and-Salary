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
    class SalariesToJsonFile
    {
        public static void Save(IEnumerable<Salary> salaries, string fileName)
        {
            string json = JsonConvert.SerializeObject(salaries);
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
                writeJson(json, fileName);
            }
        }

        private static void writeJson(string json, string fileName)
        {
            using (StreamWriter sr = new StreamWriter(fileName))
            {
                sr.WriteAsync(json);
            }
        }
    }
}
