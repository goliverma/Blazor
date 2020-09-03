using System;
using System.ComponentModel.DataAnnotations;
using EmployeeManag.Models;

namespace EmployeeManag.Web.Models
{
    public class EditEmployeeModel
    {
        public int EmployeeId { get; set; }
        [Required, Display(Name="First Name")]
        public string FirstName { get; set; }
        [Required, Display(Name="Last Name")]
        public string LastName { get; set; }
        [EmailAddress, Display(Name="Email")]
        public string Email { get; set; }
        [Compare("Email"), Display(Name="Confirm Email")]
        public string ConfirmEmail { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int DepartmentId { get; set; }
        public Gender Gender { get; set; }
        public string PhotoPath { get; set; }
        [ValidateComplexType]
        public Department Department { get; set; } = new Department();
    }
}