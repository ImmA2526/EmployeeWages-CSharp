using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    class EmployeeWage : IComputeEmpWage
    {
        public const int PartTime = 1;
        public const int FullTime = 2;
        private LinkedList <CompanyEmpWage> CompanyEmpWageList;
        private Dictionary<string, CompanyEmpWage> CompanytoEmpWageMap;

        public EmployeeWage()
        {
            this.CompanytoEmpWageMap = new Dictionary<string, CompanyEmpWage>();
            this.CompanyEmpWageList = new LinkedList<CompanyEmpWage>();
        }

        public void AddCompanyWage(string Company, int WagePerHour, int WorkDay, int WorkHrs)
        {
            CompanyEmpWage CompanyEmpWage = new CompanyEmpWage(Company, WagePerHour, WorkDay, WorkHrs);
            this.CompanytoEmpWageMap.Add(Company, CompanyEmpWage);
            this.CompanyEmpWageList.AddLast(CompanyEmpWage);
        }
      public void ComputeWages()
        {
            foreach (CompanyEmpWage companyEmpWage in this.CompanyEmpWageList)
            {
                companyEmpWage.TotalWage(this.ComputeWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());
            }
        }
      
        private int ComputeWage(CompanyEmpWage CompanyEmpWage)
        {
            int Wage = 0, TotalHrs = 0, TotalDay = 0;
            while (TotalHrs <= CompanyEmpWage.WorkHrs && TotalDay < CompanyEmpWage.WorkDay)
            {
                TotalDay++;
                Random Number = new Random();
                int Num = Number.Next(0, 3);
                switch (Num)
                {
                    case FullTime:
                        Wage = 8;
                        break;
                    case PartTime:
                        Wage = 4;
                        break;
                    default:
                        Wage = 0;
                        break;
                }
                TotalHrs += Wage;
                Console.WriteLine("Day:  " + TotalDay + "  Emp Hrs: " + Wage);
            }
            return TotalHrs * CompanyEmpWage.WagePerHour;
        }
        public int getTotalWage(string company)
        {
            return this.CompanytoEmpWageMap[company].Salary;
        }
    }
}
