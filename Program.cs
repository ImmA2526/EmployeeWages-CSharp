using System;

namespace EmployeeWage
{
    class Program
    {
        const int PartTime = 1;
        const int FullTime = 2;
        const int WagePerHour = 20;
        public static int WorkDay = 20;
        static void Main(string[] args)
        {
            Console.WriteLine("************Welcome To Employee Wages Problem***************");
            int Salary = 0, Wage = 0, TotalWage = 0;

            for (WorkDay = 0; WorkDay <= 20; WorkDay++)
            {
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
                Salary = Wage * WagePerHour;
                TotalWage += Salary;
                Console.WriteLine("Salary: " + Salary);
            }
            Console.WriteLine("Employee is Present and Salary is: " + TotalWage);
        }
    }
}