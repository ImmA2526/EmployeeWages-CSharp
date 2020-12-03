using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    class CompanyEmpWage
    {
        public int WagePerHour;
        public int WorkDay;
        public int WorkHrs;
        public string Company;
        public int Salary;
        public int TotalWageWithDailyWage;
        public int DailyWage;
        public CompanyEmpWage(string Company, int WagePerHour, int WorkDay, int WorkHrs)
        {
            this.Company = Company;
            this.WorkDay = WorkDay;
            this.WagePerHour = WagePerHour;
            this.WorkHrs = WorkHrs;
        }

        public void TotalWage(int Salary)
        {
            this.Salary = Salary;
        }

        public string toString()
        {
            return "Total Emplyee wages for compny :" + this.Company + "is : " + this.Salary+ "\n Daily Wage For Company" +this.Company+ "is: " +this.DailyWage+ "\n Total Employee Wage Along With Daily Wage:" +this.TotalWageWithDailyWage;
        }
    }
}