using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobalTest.Models
{
    public class MonthlyEmployee : Employee, IEmployee
    {
        public override void CalculateSalary()
        {
            this.Salary = this.MonthlySalary * 12;
        }
    }
}
