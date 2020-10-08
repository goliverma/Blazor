using System;
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
        [Inject]
        public NavigationManager navigationManager { get; set; }
        public string PageHeaderText { get; set; } = null;
        protected async override Task OnInitializedAsync()
        {
            if(id != 0)
            {
                PageHeaderText = "Edit Employee";
                Employee = await EmployeeServices.GetEmployee(id);
            }
            else
            {
                PageHeaderText = "Create Employee";
                Employee = new Employee(){
                    DepartmentId = 1,
                    DateOfBirth = DateTime.Now,
                    PhotoPath = "images/noimage.png"
                };
            }
            Departments = (await departmentService.GetDepartments()).ToList();
            Mapper.Map(Employee, EditEmployeeModel);
        }
        protected async Task HandleValidSubmit()
        {
            Mapper.Map(EditEmployeeModel, Employee);
            Employee result = null;
            if(Employee.EmployeeId != 0)
            {
                result = await EmployeeServices.updateEmployee(Employee);
            }
            else{
                result = await EmployeeServices.createEmployee(Employee);
            }
            if(result != null)
            {
                navigationManager.NavigateTo("/");
            }
        }
    }
}