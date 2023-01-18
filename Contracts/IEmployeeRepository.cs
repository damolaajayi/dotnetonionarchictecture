using Entities.Models;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetEmployee(Guid companyId, Guid id, bool trackChanges);
        Task<PagedList<Employee>> GetEmployees(Guid companyId, EmployeeParameters employeeParameters, bool trackChanges);
        Task CreateEmployeeForCompany(Guid companyId, Employee employee);
        Task DeleteEmployee(Employee employee);
    }
}
