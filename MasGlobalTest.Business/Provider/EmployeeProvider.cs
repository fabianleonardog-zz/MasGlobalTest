using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasGlobalTest.Models;
using MasGlobalTest.Data;
using MasGlobalTest.Data.IRepository;

namespace MasGlobalTest.Business.Provider
{
    public class EmployeeProvider : IEmployeeProvider
    {
        private IEmployeeRepositoryAPI respository;

        public EmployeeProvider()
        {
            this.respository = new EmployeeRepositoryAPI();
        }

        public EmployeeProvider(IEmployeeRepositoryAPI respository)
        {
            this.respository = respository;
        }
        public List<Employee> GetAllEmployees(int? id)
        {
            List<EmployeeResponse> requestResult = respository.GetAllEmployees(id);
            List<Employee> result = new List<Employee>();
            foreach(EmployeeResponse empRes in requestResult)
            {
                Employee emp = EmployeesFactory.GetEmployeeInstance(empRes.RoleId);
                emp.Id = empRes.Id;
                emp.Name = empRes.Name;
                emp.ContractTypeName = empRes.ContractTypeName;
                emp.RoleId = empRes.RoleId;
                emp.RoleName = empRes.RoleName;
                emp.RoleDescription = empRes.RoleDescription;
                emp.HourlySalary = empRes.HourlySalary;
                emp.MonthlySalary = empRes.MonthlySalary;
                emp.CalculateSalary();
                result.Add(emp);
            }
            return result;
        }
    }
}
