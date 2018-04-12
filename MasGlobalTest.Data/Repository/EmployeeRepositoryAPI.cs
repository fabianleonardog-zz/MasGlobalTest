using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using MasGlobalTest.Data.IRepository;
using MasGlobalTest.Models;
using MasGlobalTest.RestServiceClient;

namespace MasGlobalTest.Data
{
    /// <summary>
    /// Class tha handle the call to the employee api
    /// </summary>
    public class EmployeeRepositoryAPI : IEmployeeRepositoryAPI
    {
        private ServiceClient service;       

        public EmployeeRepositoryAPI()
        {
            service = new ServiceClient(ConfigurationManager.AppSettings["MasGlobalEmployeService"]);
        }

        /// <summary>
        /// Get all the employess
        /// </summary>
        /// <returns></returns>
        public List<EmployeeResponse> GetAllEmployees(int? id)
        {
            List<EmployeeResponse> result = JasonUitls<List<EmployeeResponse>>.GetObjectResponse(service.ExcuteGetMethod(ConfigurationManager.AppSettings["MasGlobalEmployeAction"]));
            if (id.HasValue)
                return result.Where(x => x.Id == id.Value).ToList();
            return result;
        }
    }
}
