using Microsoft.AspNetCore.Mvc;
using Personal_Web.Models;
using System.Diagnostics;

namespace Personal_Web.Controllers
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


    }

}