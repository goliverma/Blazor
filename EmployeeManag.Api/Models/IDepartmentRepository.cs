using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManag.Models;

namespace EmployeeManag.Api.Models
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartment(int departmentId);
    }
}