using System;
using EmployeeManag.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManag.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().HasData(new Department{
                DepartmentId = 1,
                DepartmentName = "IT"
            });
            modelBuilder.Entity<Department>().HasData(new Department{
                DepartmentId = 2,
                DepartmentName = "HR"
            });
            modelBuilder.Entity<Department>().HasData(new Department{
                DepartmentId = 3,
                DepartmentName = "Payroll"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee{
                EmployeeId = 1,
                FirstName = "Gaurav",
                LastName = "Verma",
                Email = "gaurav@gmail.com",
                DateOfBirth = new DateTime(1995, 12, 17),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/employee1.png"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee{
                EmployeeId = 2,
                FirstName = "Gopal",
                LastName = "Bhat",
                Email = "gopal@gmail.com",
                DateOfBirth = new DateTime(1996, 1, 27),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/employee2.png"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee{
                EmployeeId = 3,
                FirstName = "Gagan",
                LastName = "Sharma",
                Email = "gagan@gmail.com",
                DateOfBirth = new DateTime(1996, 2, 22),
                Gender = Gender.Male,
                DepartmentId = 2,
                PhotoPath = "images/employee3.png"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee{
                EmployeeId = 4,
                FirstName = "Neeraj",
                LastName = "Kashyap",
                Email = "neeraj@gmail.com",
                DateOfBirth = new DateTime(1996, 05, 19),
                Gender = Gender.Male,
                DepartmentId = 3,
                PhotoPath = "images/employee4.png"
            });
        }
    }
}