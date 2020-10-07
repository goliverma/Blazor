using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManag.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManag.Api.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext context;

        public EmployeeRepository(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<Employee> AddEmployee(Employee employee)
        {
            var result = await context.Employees.AddAsync(employee);
            await context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Employee> DeleteEmployee(int employee)
        {
            var result = await context.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employee);
            if(result != null)
            {
                context.Employees.Remove(result);
                await context.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<Employee> GetEmployee(int employeeId)
        {
            return await context.Employees
                .Include(d => d.Department)
                .FirstOrDefaultAsync(e => e.EmployeeId == employeeId);
        }

        public async Task<Employee> GetEmployeeEmail(string email)
        {
            return await context.Employees.FirstOrDefaultAsync(e => e.Email == email);
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await context.Employees.ToListAsync();
        }

        public async Task<IEnumerable<Employee>> Search(string name, Gender? gender)
        {
            IQueryable<Employee> query = context.Employees;
            if(!string.IsNullOrEmpty(name))
            {
                query = query.Where(e => e.FirstName.Contains(name) || e.LastName.Contains(name));
            }
            if(gender != null)
            {
                query = query.Where(e => e.Gender == gender);
            }
            return await query.ToListAsync();
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            // var emp = context.Employees.Attach(employee);
            var emp = await GetEmployee(employee.EmployeeId);
            if(emp != null)
            {
                // await Task.Run(async () => {
                //     emp.State = EntityState.Modified;
                //     await context.SaveChangesAsync();
                // });
                emp.FirstName = employee.FirstName;
                emp.LastName = employee.LastName;
                emp.Email = employee.Email;
                emp.Gender = employee.Gender;
                emp.DateOfBirth = employee.DateOfBirth;
                emp.DepartmentId = employee.DepartmentId;
                emp.PhotoPath = employee.PhotoPath;
                await context.SaveChangesAsync();
                return emp;
            }
            return null;
        }
    }
}