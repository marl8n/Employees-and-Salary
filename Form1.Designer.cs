
namespace Employees_and_Salaries
{
    partial class btnReportByMonth
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbHourlyWage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.cbEmployees = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbEmployeeNumber = new System.Windows.Forms.Label();
            this.lbEmployeeName = new System.Windows.Forms.Label();
            this.lbSalary = new System.Windows.Forms.Label();
            this.btnEmployeeReport = new System.Windows.Forms.Button();
            this.tbHoursWorked = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMonths = new System.Windows.Forms.ComboBox();
            this.btnAddSalary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 50);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(514, 479);
            this.dataGridView.TabIndex = 0;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(568, 74);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(203, 22);
            this.tbName.TabIndex = 1;
            // 
            // tbHourlyWage
            // 
            this.tbHourlyWage.Location = new System.Drawing.Point(797, 74);
            this.tbHourlyWage.Name = "tbHourlyWage";
            this.tbHourlyWage.Size = new System.Drawing.Size(203, 22);
            this.tbHourlyWage.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(565, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(568, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(797, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hourly wage";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(726, 120);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(120, 23);
            this.btnAddEmployee.TabIndex = 6;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // cbEmployees
            // 
            this.cbEmployees.FormattingEnabled = true;
            this.cbEmployees.Location = new System.Drawing.Point(568, 212);
            this.cbEmployees.Name = "cbEmployees";
            this.cbEmployees.Size = new System.Drawing.Size(432, 24);
            this.cbEmployees.TabIndex = 7;
            this.cbEmployees.SelectedIndexChanged += new System.EventHandler(this.cbEmployees_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(567, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Reports";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(867, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Select an Employee";
            // 
            // lbEmployeeNumber
            // 
            this.lbEmployeeNumber.AutoSize = true;
            this.lbEmployeeNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbEmployeeNumber.Location = new System.Drawing.Point(568, 257);
            this.lbEmployeeNumber.Name = "lbEmployeeNumber";
            this.lbEmployeeNumber.Size = new System.Drawing.Size(0, 17);
            this.lbEmployeeNumber.TabIndex = 11;
            // 
            // lbEmployeeName
            // 
            this.lbEmployeeName.AutoSize = true;
            this.lbEmployeeName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbEmployeeName.Location = new System.Drawing.Point(568, 284);
            this.lbEmployeeName.Name = "lbEmployeeName";
            this.lbEmployeeName.Size = new System.Drawing.Size(0, 17);
            this.lbEmployeeName.TabIndex = 12;
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbSalary.Location = new System.Drawing.Point(954, 284);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(0, 17);
            this.lbSalary.TabIndex = 14;
            this.lbSalary.Click += new System.EventHandler(this.lbSalary_Click);
            // 
            // btnEmployeeReport
            // 
            this.btnEmployeeReport.Location = new System.Drawing.Point(221, 21);
            this.btnEmployeeReport.Name = "btnEmployeeReport";
            this.btnEmployeeReport.Size = new System.Drawing.Size(103, 23);
            this.btnEmployeeReport.TabIndex = 15;
            this.btnEmployeeReport.Text = "Employees";
            this.btnEmployeeReport.UseVisualStyleBackColor = true;
            this.btnEmployeeReport.Click += new System.EventHandler(this.btnEmployeeReport_Click);
            // 
            // tbHoursWorked
            // 
            this.tbHoursWorked.Location = new System.Drawing.Point(571, 345);
            this.tbHoursWorked.Name = "tbHoursWorked";
            this.tbHoursWorked.Size = new System.Drawing.Size(171, 22);
            this.tbHoursWorked.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(568, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Hours worked";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(818, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Month";
            // 
            // cbMonths
            // 
            this.cbMonths.FormattingEnabled = true;
            this.cbMonths.Location = new System.Drawing.Point(821, 345);
            this.cbMonths.Name = "cbMonths";
            this.cbMonths.Size = new System.Drawing.Size(121, 24);
            this.cbMonths.TabIndex = 20;
            // 
            // btnAddSalary
            // 
            this.btnAddSalary.Location = new System.Drawing.Point(726, 403);
            this.btnAddSalary.Name = "btnAddSalary";
            this.btnAddSalary.Size = new System.Drawing.Size(108, 23);
            this.btnAddSalary.TabIndex = 21;
            this.btnAddSalary.Text = "Add Salary";
            this.btnAddSalary.UseVisualStyleBackColor = true;
            this.btnAddSalary.Click += new System.EventHandler(this.btnAddSalary_Click);
            // 
            // btnReportByMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 541);
            this.Controls.Add(this.btnAddSalary);
            this.Controls.Add(this.cbMonths);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbHoursWorked);
            this.Controls.Add(this.btnEmployeeReport);
            this.Controls.Add(this.lbSalary);
            this.Controls.Add(this.lbEmployeeName);
            this.Controls.Add(this.lbEmployeeNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbEmployees);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHourlyWage);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.dataGridView);
            this.Name = "btnReportByMonth";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.btnReportByMonth_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbHourlyWage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.ComboBox cbEmployees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbEmployeeNumber;
        private System.Windows.Forms.Label lbEmployeeName;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.Button btnEmployeeReport;
        private System.Windows.Forms.TextBox tbHoursWorked;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMonths;
        private System.Windows.Forms.Button btnAddSalary;
    }
}

