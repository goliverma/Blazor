using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManag.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManag.Api.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext context;

        public DepartmentRepository(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<Department> GetDepartment(int departmentId)
        {
            return await context.Departments.FirstOrDefaultAsync(x => x.DepartmentId == departmentId);
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await context.Departments.ToListAsync();
        }
    }
}