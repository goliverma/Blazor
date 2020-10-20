using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace EmployeeManag.Web.Pages
{
    public class ConfirmBase : ComponentBase
    {
        protected bool ShowConfirmation { get; set; }
        [Parameter]
        public EventCallback<bool> ConfirmationChange { get; set; }
        public void Show()
        {
            ShowConfirmation = true;
            StateHasChanged();
        }
        protected async Task OnConfirmationChange(bool value)
        {
            ShowConfirmation = false;
            await ConfirmationChange.InvokeAsync(value);
        }
    }
}