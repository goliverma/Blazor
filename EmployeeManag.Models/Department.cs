using System.ComponentModel.DataAnnotations;

namespace EmployeeManag.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        [Required, Display(Name="Department Name"]
        public string DepartmentName { get; set; }
    }
}