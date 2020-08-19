using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManag.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int DepartmentId { get; set; }
        public Gender Gender { get; set; }
        public string PhotoPath { get; set; }
        public Department Department { get; set; }
    }
}