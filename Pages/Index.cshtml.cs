using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace comp4952_happyweb.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        var processes = Process.GetProcesses();
        ViewData["ProcessCount"] = processes;
    }
}
