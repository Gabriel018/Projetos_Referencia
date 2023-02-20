using Microsoft.AspNetCore.Mvc;

namespace Login.Controllers
{
    public class Menu_AdmController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
}
