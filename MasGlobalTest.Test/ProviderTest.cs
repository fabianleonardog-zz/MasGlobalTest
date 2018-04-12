using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MasGlobalTest.Business.Provider;
using System.Collections.Generic;
using MasGlobalTest.Models;
using System.Linq;

namespace MasGlobalTest.Test
{
    [TestClass]
    public class ProviderTest
    {
        [TestMethod]
        public void GetAllEmployees()
        {
            RepositoryMock respository = new RepositoryMock();
            EmployeeProvider provider = new EmployeeProvider(respository);

            List<Employee> employeeList = provider.GetAllEmployees(null);

            Assert.IsTrue(employeeList.Count > 0);
            Assert.IsTrue(employeeList.Count == 3);
        }

        [TestMethod]
        public void GetAllEmployeesValidateMonthlySalary()
        {
            RepositoryMock respository = new RepositoryMock();
            EmployeeProvider provider = new EmployeeProvider(respository);

            //id 1 is an employee with this salary type
            List<Employee> employeeList = provider.GetAllEmployees(1);

            Assert.IsTrue(employeeList.Count > 0);
            Assert.IsTrue(employeeList.Count == 1);
            Assert.IsTrue(employeeList.First().Salary == 36000);
        }

        [TestMethod]
        public void GetAllEmployeesValidateHourlySalary()
        {
            RepositoryMock respository = new RepositoryMock();
            EmployeeProvider provider = new EmployeeProvider(respository);

            //id 2 is an employee with this salary type
            List<Employee> employeeList = provider.GetAllEmployees(2);

            Assert.IsTrue(employeeList.Count > 0);
            Assert.IsTrue(employeeList.Count == 1);
            Assert.IsTrue(employeeList.First().Salary == 64800);
        }
    }
}
