using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetAspRazor.Pages
{
    public class ExceptionTestModel : PageModel
    {
        public string Message { get; private set; } = "Exception handling";

        public void OnGet()
        {
            Message += $" Server time is { DateTime.Now }";
        }
    }
}