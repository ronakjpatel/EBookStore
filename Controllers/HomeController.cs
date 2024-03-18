using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ECommerceBookStore.Models;

namespace ECommerceBookStore.Controllers;
// Any name followed by controller keyword is valid name 
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //returns the view same named as Index as the name is not defined
        return View();
    }

    public IActionResult Privacy()
    {
        //returns the Privacy same named as Index as the name is not defined
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
