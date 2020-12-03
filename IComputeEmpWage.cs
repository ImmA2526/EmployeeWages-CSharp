using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    public interface IComputeEmpWage
    {
        public void AddCompanyWage(string Company, int WagePerHour, int WorkDay, int WorkHrs);
        public void ComputeWages();
        public int getTotalWage(string Company);
    }
}
