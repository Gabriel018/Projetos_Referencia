using Microsoft.AspNetCore.Mvc;
using Personal_Web.Models;
using System.Diagnostics;

namespace Personal_Web.Controllers
{
    public class ServicosController : Controller
    {
        private readonly ILogger<ServicosController> _logger;

        public ServicosController(ILogger<ServicosController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}