using Microsoft.AspNetCore.Mvc;
using Personal_Web.Models;
using System.Diagnostics;

namespace Personal_Web.Controllers
{
    public class BuscaController : Controller
    {
        private readonly ILogger<EstiloController> _logger;

        public BuscaController(ILogger<EstiloController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


    }
}