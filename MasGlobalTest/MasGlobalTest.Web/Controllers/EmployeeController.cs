using MasGlobalTest.Business.Provider;
using MasGlobalTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MasGlobalTest.Web.Controllers
{
    public class EmployeeController : ApiController
    {
        private IEmployeeProvider provider = new EmployeeProvider();

        [HttpGet]
        public List<Employee> GetEmployees(int? id)
        {
            var employeesList = provider.GetAllEmployees(id);
            return employeesList;
        }
    }
}
