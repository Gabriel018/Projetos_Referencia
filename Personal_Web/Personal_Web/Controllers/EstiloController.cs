using Microsoft.AspNetCore.Mvc;
using Personal_Web.Models;
using System.Diagnostics;

namespace Personal_Web.Controllers
{
    public class EstiloController : Controller
    {
        private readonly ILogger<EstiloController> _logger;

        public EstiloController(ILogger<EstiloController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


    }

}