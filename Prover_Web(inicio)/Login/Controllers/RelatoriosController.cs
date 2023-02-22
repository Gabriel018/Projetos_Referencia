using IBM.Cloud.SDK.Core.Http;
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
        public RelatoriosController(ApplicationDbContext context)
        {
            _context = context;
        }



        private readonly ApplicationDbContext _context;


		public IActionResult PesquisarPorNome(string nome)
		{

			var cliente = from c in _context.Cliente
						  where c.Nome == nome
						  select c;
			return View(cliente.ToList());
		}




		public IActionResult PesquisarPorMach(string nome)
        {
            var clientes = from c in _context.Cliente
                           join v in _context.Vendedor on c.Categoria equals v.Categoria
                           where c.Nome.Contains(nome)
                           select new ClienteVendedor { Cliente = c, Vendedor = v };

            return View(clientes.ToList());
        }

        public IActionResult Index()
        {
            var clientes = from c in _context.Cliente
                           join v in _context.Vendedor on c.Categoria equals v.Categoria
                           select new ClienteVendedor { Cliente = c, Vendedor = v };

            return View(clientes.ToList());
        }

    }
}

    

