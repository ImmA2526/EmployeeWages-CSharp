using System;

namespace EmployeeWage
{
    class Program
    {
        const int PartTime = 1;
        const int FullTime = 2;
        const int WagePerHour = 20;
        static void Main(string[] args)
        {
            Console.WriteLine("************Welcome To Employee Wages Problem***************");
            int Salary = 0;
            int Wage = 0;
            Random Number = new Random();
            int Num = Number.Next(0, 3);
            if (Num == FullTime)
            {
                Wage = 8;
            }
            else if (Num == PartTime)
            {
                Wage = 4;
            }
            else
            {
                Console.WriteLine("The Employee is absent ");
            }
            Salary = Wage * WagePerHour; 
            Console.WriteLine("Salary is :" + Salary);
        }
    }
}