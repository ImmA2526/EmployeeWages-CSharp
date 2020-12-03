using System;

namespace EmployeeWages
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************Welcome To Employee Wages Problem***************");
            EmployeeWage Result = new EmployeeWage();
            Result.AddCompanyWage("Telegram", 12, 3, 10);
            Result.AddCompanyWage("Jio", 14, 4, 18);
            Result.ComputeWages();
            
        }
    }
}