using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManag.Models;
using EmployeeManag.Web.Services;
using Microsoft.AspNetCore.Components;

namespace EmployeeManag.Web.Pages
{
    public class EditEmployeeBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeServices { get; set; }
        [Inject]
        public IDepartmentService departmentService { get; set; }
        public List<Department> Departments = new List<Department>();
        public Employee Employee { get; set; } = new Employee();
        [Parameter]
        public int id { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Employee = await EmployeeServices.GetEmployee(id);
            Departments = (await departmentService.GetDepartments()).ToList();
        }
    }
}