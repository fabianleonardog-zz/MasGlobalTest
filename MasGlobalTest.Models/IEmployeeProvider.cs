using MasGlobalTest.Models;
using System.Collections.Generic;

namespace MasGlobalTest.Models
{
    public interface IEmployeeProvider
    {
        List<Employee> GetAllEmployees(int? id);
    }
}
