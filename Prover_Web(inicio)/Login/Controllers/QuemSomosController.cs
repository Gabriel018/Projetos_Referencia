using Login.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Login.Controllers
{
    public class QuemSomosController : Controller
    {
        private readonly ILogger<QuemSomosController> _logger;

        public QuemSomosController(ILogger<QuemSomosController> logger)
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