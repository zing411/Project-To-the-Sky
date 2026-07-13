using Microsoft.AspNetCore.Mvc;
namespace To_the_Sky.Controllers;

public class HomeController : Controller
{
    
    public async Task<IActionResult> Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}