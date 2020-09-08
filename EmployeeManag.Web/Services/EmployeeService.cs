using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using EmployeeManag.Models;
using Microsoft.AspNetCore.Components;

namespace EmployeeManag.Web.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await httpClient.GetJsonAsync<Employee>($"api/employees/{id}");
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await httpClient.GetJsonAsync<IEnumerable<Employee>>("api/employees");
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
           return await httpClient.PutJsonAsync<Employee>("api/employees", employee); 
        }
    }
}