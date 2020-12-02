using System;
namespace EmployeeWage
{
    class Program
    {
        const int FullTime = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("************Welcome To Employee Wages Problem***************");
            Random Number = new Random();
            int Num = Number.Next(0, 2);
            if (Num == FullTime)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee Not Present");
            }
        }
    }
}