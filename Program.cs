using System;

namespace EmployeeWage
{
    class Program
    {
        const int PartTime = 1;
        const int FullTime = 2;
        private int WagePerHour;
        private int WorkDay;
        private int WorkHrs;
        private string Company;
        public Program(string Company, int WagePerHour, int WorkDay, int WorkHrs)
        {
            this.Company = Company;
            this.WorkDay = WorkDay;
            this.WagePerHour = WagePerHour;
            this.WorkHrs = WorkHrs;
        }
        public void ComputeWage()
        {

            int Salary = 0, Wage = 0,TotalHrs = 0, TotalDay = 0;

            while (TotalHrs <= WorkHrs && TotalDay < WorkDay)
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
                //Salary = Wage * WagePerHour;
                TotalHrs += Wage;
                Console.WriteLine("Day:  " + TotalDay + "  Emp Hrs: " + Wage);
            }
            Salary = TotalHrs * this.WagePerHour;
            Console.WriteLine("Total Employee Wage for Company:  "+Company+ "is:" +Salary);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("************Welcome To Employee Wages Problem***************");
            Program Dmart = new Program("Telco", 10, 3, 12);
            Program Wipro = new Program("Wipro", 10, 2, 12);
            Program Telegram = new Program("Telegram", 10, 2, 12);
            Dmart.ComputeWage();
            Wipro.ComputeWage();
            Telegram.ComputeWage();
        }
    }
}
