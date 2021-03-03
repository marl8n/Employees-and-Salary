using Employees_and_Salaries.Reports;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_and_Salaries.Persistance.ReportsPersistance
{
    class ReportsToJsonFile
    {
        public static void Save(IEnumerable<Report> reports, string fileName)
        {
            string json = JsonConvert.SerializeObject(reports);
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
            using ( StreamWriter sw = new StreamWriter(fileName ))
            {
                sw.WriteAsync(json);
            }
        }
    }
}
