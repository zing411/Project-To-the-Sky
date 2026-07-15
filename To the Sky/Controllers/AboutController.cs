using Microsoft.AspNetCore.Mvc;

namespace To_the_Sky.Controllers;

public class AboutController : Controller
{
    public async Task<IActionResult> About()
    {
        return View();
    }
    
    public IActionResult Contact()
    {
        return View();
    }
}