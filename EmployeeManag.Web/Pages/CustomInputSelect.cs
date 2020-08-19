using Microsoft.AspNetCore.Components.Forms;

namespace EmployeeManag.Web.Pages
{
    public class CustomInputSelect<TValue> : InputSelect<TValue>
    {
        protected override bool TryParseValueFromString(string value, out TValue result, 
            out string validationErrorMessage)
        {
            if(typeof(TValue) == typeof(int))
            {
                if(int.TryParse(value, out var resultInt))
                {
                    result = (TValue)(object)resultInt;
                    validationErrorMessage = null;
                    return true;
                }
                else{
                    result = default;
                    validationErrorMessage = $"The selected value {value} is not a valid Number.";
                    return false;
                }
            }
            else{
                return base.TryParseValueFromString(value, out result, out validationErrorMessage);
            }
        }
    }
}