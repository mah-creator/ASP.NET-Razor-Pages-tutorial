using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetAspRazor.Pages;

public class IndexModel : PageModel
{
    private IDependancy _service;
    public string serviceText;

    public IndexModel(IDependancy service)
    {
        _service = service;
    }

    public void OnGet()
    {
        serviceText = _service.DependancyDefinition();
    }
}