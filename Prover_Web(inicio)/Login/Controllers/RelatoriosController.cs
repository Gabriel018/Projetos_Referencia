using Login.Data;
using Login.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prover_Web.Models;
using System.Diagnostics;

namespace Login.Controllers
{
    public class RelatoriosController : Controller
    {
        private readonly ILogger<RelatoriosController> _logger;
        private readonly ApplicationDbContext _context;

        public RelatoriosController(ILogger<RelatoriosController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {

            var clientes = from c in _context.Cliente select c;

            return View(clientes.ToList());
        }


    }
}

    

