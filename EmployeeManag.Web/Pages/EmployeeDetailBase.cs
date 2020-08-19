using System.Threading.Tasks;
using EmployeeManag.Models;
using EmployeeManag.Web.Services;
using Microsoft.AspNetCore.Components;

namespace EmployeeManag.Web.Pages
{
    public class EmployeeDetailBase : ComponentBase
    {
        [Parameter]
        public int id { get; set;}
        [Inject]
        public IEmployeeService context { get; set; }
        public Employee Employee { get; set; } = new Employee();

        protected override async Task OnInitializedAsync()
        {
            Employee = await context.GetEmployee(id);
        }
    }
}