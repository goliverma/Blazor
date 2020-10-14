using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManag.Models;
using EmployeeManag.Web.Services;
using Microsoft.AspNetCore.Components;

namespace EmployeeManag.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject]
        public IEmployeeService employeeService { get; set; }
        public bool ShowFooter { get; set; } = true;
        public IEnumerable<Employee> Employees { get; set; }
        public int SelectedEmployeeCount { get; private set; }

        // protected void LoadEmployee()
        // {
        //     Employee e1 = new Employee(){
        //         EmployeeId = 1,
        //         FirstName = "Gaurav",
        //         LastName = "Verma",
        //         Email = "gaurav@gmail.com",
        //         DateOfBirth = new DateTime(1995, 12, 17),
        //         Gender = Gender.Male,
        //         DepartmentId = 0,
        //         PhotoPath = "images/employee1.png"
        //     };
        //     Employee e2 = new Employee(){
        //         EmployeeId = 2,
        //         FirstName = "Gopal",
        //         LastName = "Bhat",
        //         Email = "gopal@gmail.com",
        //         DateOfBirth = new DateTime(1996, 1, 27),
        //         Gender = Gender.Male,
        //         DepartmentId = 0,
        //         PhotoPath = "images/employee2.png"
        //     };
        //     Employee e3 = new Employee(){
        //         EmployeeId = 3,
        //         FirstName = "Gagan",
        //         LastName = "Sharma",
        //         Email = "gagan@gmail.com",
        //         DateOfBirth = new DateTime(1996, 2, 22),
        //         Gender = Gender.Male,
        //         DepartmentId = 1,
        //         PhotoPath = "images/employee3.png"
        //     };
        //     Employee e4 = new Employee(){
        //         EmployeeId = 4,
        //         FirstName = "Neeraj",
        //         LastName = "Kashyap",
        //         Email = "neeraj@gmail.com",
        //         DateOfBirth = new DateTime(1996, 05, 19),
        //         Gender = Gender.Male,
        //         DepartmentId = 3,
        //         PhotoPath = "images/employee4.png"
        //     };
        //     Employees = new List<Employee>{ e1, e2, e3, e4 };
        // }
        protected override async Task OnInitializedAsync()
        {
            Employees = (await employeeService.GetEmployees()).ToList();
        }
        protected async Task EmployeeDeleted()
        {
            Employees = (await employeeService.GetEmployees()).ToList();
        }
        protected void EmployeeSelectionCh(bool isSelected)
        {
            if(isSelected)
            {
                SelectedEmployeeCount++;
            }
            else
            {
                SelectedEmployeeCount--;
            }
        }
    }
}