using System;
using System.ComponentModel.DataAnnotations;
using EmployeeManag.Models;

namespace EmployeeManag.Web.Models
{
    public class EditEmployeeModel
    {
        public int EmployeeId { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Compare("Email")]
        public string ConfirmEmail { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int DepartmentId { get; set; }
        public Gender Gender { get; set; }
        public string PhotoPath { get; set; }
        public Department Department { get; set; }
    }
}