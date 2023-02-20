using Microsoft.AspNetCore.Mvc;
using Personal_Web.Models;
using System.Diagnostics;

namespace Personal_Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


    }

}