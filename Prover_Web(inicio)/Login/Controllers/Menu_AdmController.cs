using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Login.Controllers
{
    [Authorize(Roles ="Admin")]
    public class Menu_AdmController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
}
