using MasGlobalTest.Data.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasGlobalTest.Models;
using MasGlobalTest.Models.Enums;

namespace MasGlobalTest.Test
{
    public class RepositoryMock : IEmployeeRepositoryAPI
    {
        public List<EmployeeResponse> GetAllEmployees(int? id)
        {
            List<EmployeeResponse> employeesList = new List<EmployeeResponse>();

            employeesList.Add(new EmployeeResponse()
            {
                Id = 1,
                Name = "Fabian Gonzalez",
                ContractTypeName = "MonthlySalaryEmployee",
                RoleId = ContractTypeEnum.MonthlySalary,
                RoleName = "Administrator",
                RoleDescription = null,
                HourlySalary = 32,
                MonthlySalary = 3000
            });

            employeesList.Add(new EmployeeResponse()
            {
                Id = 2,
                Name = "Pepe Perez",
                ContractTypeName = "HourlySalaryEmployee",
                RoleId = ContractTypeEnum.HourlySalary,
                RoleName = "Administrator",
                RoleDescription = null,
                HourlySalary = 45,
                MonthlySalary = 10000
            });

            employeesList.Add(new EmployeeResponse()
            {
                Id = 3,
                Name = "Daniel Moncada",
                ContractTypeName = "HourlySalaryEmployee",
                RoleId = ContractTypeEnum.HourlySalary,
                RoleName = "Administrator",
                RoleDescription = null,
                HourlySalary = 22,
                MonthlySalary = 1500
            });
            if (id.HasValue)
                return employeesList.Where(x => x.Id == id.Value).ToList();
            return employeesList;
        }
    }
}
