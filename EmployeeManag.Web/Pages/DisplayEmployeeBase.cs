using System.Threading.Tasks;
using EmployeeManag.Models;
using EmployeeManag.Web.Services;
using Microsoft.AspNetCore.Components;

namespace EmployeeManag.Web.Pages
{
    public class DisplayEmployeeBase : ComponentBase
    {
        [Parameter]
        public Employee Employee { get; set; }
        [Parameter]
        public bool ShowFooter { get; set; }
        [Parameter]
        public EventCallback<bool> OnEmployeeSelection { get; set; }
        [Parameter]
        public EventCallback<int> OnEmployeeDeleted { get; set; }
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        [Inject]
        public NavigationManager nm { get; set; }
        protected async Task CheckBoxChanged(ChangeEventArgs e)
        {
            await OnEmployeeSelection.InvokeAsync((bool)e.Value);
        }
        protected async Task Delete_User()
        {
            await EmployeeService.deleteEmployee(Employee.EmployeeId);
            await OnEmployeeDeleted.InvokeAsync(Employee.EmployeeId);
            // nm.NavigateTo("/", true);
        }
    }
}