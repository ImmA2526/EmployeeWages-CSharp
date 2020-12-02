using System;

namespace EmployeeWage
{
    class Program
    {
        const int PartTime = 1;
        const int FullTime = 2;
        const int WagePerHour = 20;
        public static int WorkDay = 20;
        public static int WorkHrs = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("************Welcome To Employee Wages Problem***************");
            int Salary = 0, Wage = 0, TotalWage = 0;
            int TotalHrs = 0, TotalDay = 0;

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
            Salary = TotalHrs * WagePerHour;
            Console.WriteLine("Employee is Present and Salary is: " + Salary);
        }
    }
}