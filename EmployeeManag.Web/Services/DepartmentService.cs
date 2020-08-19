using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using EmployeeManag.Models;
using Microsoft.AspNetCore.Components;

namespace EmployeeManag.Web.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly HttpClient httpClient;

        public DepartmentService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<Department> GetDepartment(int id)
        {
            return await httpClient.GetJsonAsync<Department>($"api/department/{id}");
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await httpClient.GetJsonAsync<IEnumerable<Department>>("api/department");
        }
    }
}