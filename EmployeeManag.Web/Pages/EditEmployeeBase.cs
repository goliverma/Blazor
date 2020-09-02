using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManag.Models;
using EmployeeManag.Web.Models;
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
        public EditEmployeeModel Employee1 { get; set; } = new EditEmployeeModel();
        [Parameter]
        public int id { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Employee = await EmployeeServices.GetEmployee(id);
            Departments = (await departmentService.GetDepartments()).ToList();
            var Employee1 = new EditEmployeeModel{
                FirstName = Employee.FirstName,
                LastName = Employee.LastName,
                Email = Employee.Email,
                ConfirmEmail = Employee.Email,
                DepartmentId =Employee.DepartmentId,
                Gender = Employee.Gender,
                DateOfBirth = Employee.DateOfBirth,
                PhotoPath = Employee.PhotoPath
            };
        }
    }
}