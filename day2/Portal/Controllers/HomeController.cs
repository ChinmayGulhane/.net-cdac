using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;
using BLL;
using BOL;

namespace Portal.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        CompanyManager cmgr= new CompanyManager();
        List<Company> comList=(List<Company>)cmgr.getAllComp();
        ViewData["Coy"]=comList;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
