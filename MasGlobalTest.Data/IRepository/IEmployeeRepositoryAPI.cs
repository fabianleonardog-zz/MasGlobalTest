using MasGlobalTest.Models;
using System.Collections.Generic;

namespace MasGlobalTest.Data.IRepository
{
    public interface IEmployeeRepositoryAPI
    {
        List<EmployeeResponse> GetAllEmployees(int? id);
    }
}
