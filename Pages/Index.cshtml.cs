using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetAspRazor.Pages;

public class IndexModel : PageModel
{
    private IDependency _service;
    public string serviceText;

    public IndexModel(IDependency service)
    {
        _service = service;
    }

    public void OnGet()
    {
        serviceText = _service.DependencyDefinition();
    }
}