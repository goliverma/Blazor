using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
        private Employee Employee { get; set; } = new Employee();
        public EditEmployeeModel EditEmployeeModel { get; set; } = new EditEmployeeModel();
        [Parameter]
        public int id { get; set; }
        [Inject]
        public IMapper Mapper { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Employee = await EmployeeServices.GetEmployee(id);
            Departments = (await departmentService.GetDepartments()).ToList();
            Mapper.Map(Employee, EditEmployeeModel);
            // EditEmployeeModel = new EditEmployeeModel{
            //     EmployeeId = Employee.EmployeeId,
            //     FirstName = Employee.FirstName,
            //     LastName = Employee.LastName,
            //     Email = Employee.Email,
            //     ConfirmEmail = Employee.Email,
            //     DepartmentId = Employee.DepartmentId,
            //     Gender = Employee.Gender,
            //     DateOfBirth = Employee.DateOfBirth,
            //     PhotoPath = Employee.PhotoPath,
            //     Department = Employee.Department
            // };
        }
    }
}