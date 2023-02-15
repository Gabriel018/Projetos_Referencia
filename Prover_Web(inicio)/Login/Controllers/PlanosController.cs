using Login.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Login.Controllers
{

    [Authorize]
    public class PlanosController : Controller
    {
        private readonly ILogger<PlanosController> _logger;

        public PlanosController(ILogger<PlanosController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}