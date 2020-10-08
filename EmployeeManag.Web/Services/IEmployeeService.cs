using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManag.Models;

namespace EmployeeManag.Web.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int id);
        Task<Employee> updateEmployee(Employee updatedEmployee);
        Task<Employee> createEmployee(Employee employee);
        Task deleteEmployee(int id);
    }
}