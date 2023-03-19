using Microsoft.AspNetCore.Mvc;

namespace DemoProject_MVC.Areas.Admin.Controllers;
[Area("Admin")]
[Route("admin/dashboard")]
public class DashboardController : Controller
{
    [Route("index")]
    [Route("")]

    public IActionResult Index()
    {
        return View();
    }
}
