using Employees_and_Salaries.BusinessLogic;
using Employees_and_Salaries.models;
using Employees_and_Salaries.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees_and_Salaries
{
    public partial class btnReportByMonth : Form
    {
        Enterprise enterprise = new Enterprise();
        public btnReportByMonth()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridView.DataSource = enterprise.Reports;
            enterprise.Employees.ForEach(employee => cbEmployees.Items.Add($"{employee.Id} * {employee.Name}"));
            cbMonths.DataSource = new List<Months> {
                Months.January,
                Months.February,
                Months.March,
                Months.April,
                Months.May,
                Months.June,
                Months.July,
                Months.August,
                Months.September,
                Months.October,
                Months.November,
                Months.December
            };
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if(!tbHourlyWage.Text.Trim().Equals("") && !tbName.Text.Trim().Equals(""))
            {
                var employee = enterprise.AddEmployee(
                    new Employee (
                        this.tbName.Text,
                        Double.Parse(this.tbHourlyWage.Text)
                        )
                    );
                tbName.Text = "";
                tbHourlyWage.Text = "";
                enterprise.MakeReports();
                this.dataGridView.DataSource = enterprise.Reports;
                enterprise.Employees.ForEach(employee0 => cbEmployees.Items.Add($"{employee0.Id} * {employee0.Name}"));
            }

        }

        private void cbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetLabelsEmployeeInfo(getSelectedReport());
        }

        private void SetLabelsEmployeeInfo(Report report)
        {
            lbEmployeeName.Text = report.EmployeeName;
            lbEmployeeNumber.Text = report.EmployeeId;
            lbSalary.Text = report.Salary.ToString();
        }

        private Report getSelectedReport()
        {
            var dataFromComboBox = cbEmployees.SelectedItem.ToString().Split('*');
            var a = dataFromComboBox.First();
            dataFromComboBox.ToList().ForEach(text => text.Trim());
            return enterprise.GetReport(dataFromComboBox.First().Trim());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = from data in enterprise.ReportsByMonth() select new {  };
        }

        private void btnEmployeeReport_Click(object sender, EventArgs e)
        {
            this.dataGridView.DataSource = enterprise.Reports;
        }

        private void btnReportByMonth_FormClosing(object sender, FormClosingEventArgs e)
        {
            enterprise.SaveAll();
        }

        private void btnAddSalary_Click(object sender, EventArgs e)
        {
            if ( !tbHoursWorked.Text.Equals("") && cbMonths != null )
            {
                enterprise.AddSalary( new Salary (
                    this.getSelectedReport().EmployeeId,
                    int.Parse(tbHoursWorked.Text),
                    (Months) cbMonths.SelectedIndex + 1
                    ));
                tbHoursWorked.Text = "";
                cbMonths.SelectedIndex = 0;
                enterprise.MakeReports();
                this.dataGridView.DataSource = enterprise.Reports;
            }
        }

        private void lbSalary_Click(object sender, EventArgs e)
        {

        }
    }
}
