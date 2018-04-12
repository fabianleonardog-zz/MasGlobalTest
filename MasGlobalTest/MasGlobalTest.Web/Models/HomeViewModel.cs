using MasGlobalTest.Business.Provider;
using MasGlobalTest.Models;
using MasGlobalTest.RestServiceClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MasGlobalTest.Web.Models
{
    public class HomeViewModel
    {
        private IEmployeeProvider provider = new EmployeeProvider();
        private ServiceClient service;
        public List<Employee> EmployeeList { get; set; }
        public int? id { get; set; }

        public HomeViewModel()
        {
            this.EmployeeList = new List<Employee>();
            service = new ServiceClient(ConfigurationManager.AppSettings["MasGlobalTestService"]);
        }

        public void GetAllEmployee()
        {
            this.EmployeeList = JasonUitls<List<Employee>>.GetObjectResponse(service.ExcuteGetMethod(ConfigurationManager.AppSettings["MasGlobalTestEmployeeAction"] + (this.id.HasValue ? "?id=" + this.id.Value.ToString() : "")));
        }
    }
}