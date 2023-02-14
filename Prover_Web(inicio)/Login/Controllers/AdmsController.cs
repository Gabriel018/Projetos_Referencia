using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Login.Data;
using Prover_Web.Models;

namespace Login.Controllers
{
    public class AdmsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdmsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Adms
        public async Task<IActionResult> Index()
        {
              return _context.Adm != null ? 
                          View(await _context.Adm.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Adm'  is null.");
        }

        // GET: Adms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Adm == null)
            {
                return NotFound();
            }

            var adm = await _context.Adm
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adm == null)
            {
                return NotFound();
            }

            return View(adm);
        }

        // GET: Adms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Adms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Cpf,Telefone")] Adm adm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(adm);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(adm);
        }

        // GET: Adms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Adm == null)
            {
                return NotFound();
            }

            var adm = await _context.Adm.FindAsync(id);
            if (adm == null)
            {
                return NotFound();
            }
            return View(adm);
        }

        // POST: Adms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Cpf,Telefone")] Adm adm)
        {
            if (id != adm.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(adm);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdmExists(adm.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(adm);
        }

        // GET: Adms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Adm == null)
            {
                return NotFound();
            }

            var adm = await _context.Adm
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adm == null)
            {
                return NotFound();
            }

            return View(adm);
        }

        // POST: Adms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Adm == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Adm'  is null.");
            }
            var adm = await _context.Adm.FindAsync(id);
            if (adm != null)
            {
                _context.Adm.Remove(adm);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdmExists(int id)
        {
          return (_context.Adm?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
