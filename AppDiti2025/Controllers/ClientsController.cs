using Microsoft.AspNetCore.Mvc;

namespace AppDiti2025.Controllers;

public class ClientsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
