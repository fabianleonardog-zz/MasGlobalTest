using MasGlobalTest.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobalTest.Models
{
    public static class EmployeesFactory
    {
        public static Employee GetEmployeeInstance(ContractTypeEnum contractType)
        {
            switch(contractType)
            {
                case ContractTypeEnum.HourlySalary:
                    return new HourlyEmployee();
                case ContractTypeEnum.MonthlySalary:
                    return new MonthlyEmployee();
                default:
                    return null;
            }
        }
    }
}
