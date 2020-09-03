using AutoMapper;
using EmployeeManag.Models;

namespace EmployeeManag.Web.Models
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EditEmployeeModel>();
            CreateMap<EditEmployeeModel, Employee>();
        }
    }
}