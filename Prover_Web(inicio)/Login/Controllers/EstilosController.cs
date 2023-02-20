using Login.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Login.Controllers
{
    public class EstilosController : Controller
    {
        private readonly ILogger<EstilosController> _logger;

        public EstilosController(ILogger<EstilosController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}