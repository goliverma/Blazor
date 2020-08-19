using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManag.Models;

namespace EmployeeManag.Web.Services
{
    public interface IDepartmentService
    {
        public Task<IEnumerable<Department>> GetDepartments();
        public Task<Department> GetDepartment(int id);
    }
}