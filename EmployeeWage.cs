using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    class EmployeeWage: IComputeEmpWage
    {
        public const int PartTime = 1;
        public const int FullTime = 2;
        public int NumofCompany = 0;
        public CompanyEmpWage[] CompanyWageArray;
        private Dictionary<string, CompanyEmpWage> CompanytoEmpWageMap;

        public EmployeeWage()
        {
            this.CompanytoEmpWageMap = new Dictionary<string, CompanyEmpWage>();
            this.CompanyWageArray = new CompanyEmpWage[5];
        }

        public void AddCompanyWage(string Company, int WagePerHour, int WorkDay, int WorkHrs)
        {
            CompanyWageArray[NumofCompany] = new CompanyEmpWage(Company, WagePerHour, WorkDay, WorkHrs);
            CompanyEmpWage CompanyEmpWage =new CompanyEmpWage(Company, WagePerHour, WorkDay, WorkHrs);
            CompanytoEmpWageMap.Add(Company, CompanyEmpWage);
            NumofCompany++;
        }

        public void ComputeWages()
        {
            for (int i = 0; i < NumofCompany; i++)
            {
                CompanyWageArray[i].TotalWage(this.ComputeWage(this.CompanyWageArray[i]));
                Console.WriteLine(this.CompanyWageArray[i].toString());
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
            CompanyEmpWage.DailyWage = Wage * CompanyEmpWage.WagePerHour;
            CompanyEmpWage.TotalWageWithDailyWage = Wage * CompanyEmpWage.WagePerHour+CompanyEmpWage.DailyWage;

            return TotalHrs * CompanyEmpWage.WagePerHour;
        }

        public int getTotalWage(string company)
        {
            return this.CompanytoEmpWageMap[company].Salary;
        }
    }
}