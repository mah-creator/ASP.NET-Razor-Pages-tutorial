using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetAspRazor.Pages;

public class IndexModel : PageModel
{
    public string serviceText;

    public IndexModel(IDependency service)
    {
        serviceText = service.DependencyDefinition();
    }
}