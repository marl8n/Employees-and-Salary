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
    class JsonToReports
    {
        public static IEnumerable<Report> LoadFromFileOrNewList(string fileName)
        {
            List<Report> reports = new List<Report>();
            if ( File.Exists( fileName ) )
            {
                using ( StreamReader sr = new StreamReader(fileName) )
                {
                    string json = sr.ReadToEnd();
                    reports = JsonConvert.DeserializeObject<List<Report>>(json);
                }
            }
            return reports;
        }
    }
}
