using MasGlobalTest.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobalTest.Models
{
    public class Employee : BaseEmployee, IEmployee
    {
        public decimal Salary { get; set; }
        public virtual void CalculateSalary()
        {
            throw new NotImplementedException();
        }
    }
}
