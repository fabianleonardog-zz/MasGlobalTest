using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobalTest.Models
{
    public class HourlyEmployee : Employee, IEmployee
    {
        public override void CalculateSalary()
        {
            this.Salary = 120 * this.HourlySalary * 12;
        }
    }
}
