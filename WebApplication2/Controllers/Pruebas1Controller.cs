using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class Pruebas1Controller : Controller
    {
        private readonly WebApplication2Context _context;

        public Pruebas1Controller(WebApplication2Context context)
        {
            _context = context;
        }

        // GET: Pruebas1
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pruebas.ToListAsync());
        }

        // GET: Pruebas1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pruebas = await _context.Pruebas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pruebas == null)
            {
                return NotFound();
            }

            return View(pruebas);
        }

        // GET: Pruebas1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pruebas1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Appellido,Nombre,Fecha")] Pruebas pruebas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pruebas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pruebas);
        }

        // GET: Pruebas1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pruebas = await _context.Pruebas.FindAsync(id);
            if (pruebas == null)
            {
                return NotFound();
            }
            return View(pruebas);
        }

        // POST: Pruebas1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Appellido,Nombre,Fecha")] Pruebas pruebas)
        {
            if (id != pruebas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pruebas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PruebasExists(pruebas.Id))
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
            return View(pruebas);
        }

        // GET: Pruebas1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pruebas = await _context.Pruebas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pruebas == null)
            {
                return NotFound();
            }

            return View(pruebas);
        }

        // POST: Pruebas1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pruebas = await _context.Pruebas.FindAsync(id);
            if (pruebas != null)
            {
                _context.Pruebas.Remove(pruebas);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PruebasExists(int id)
        {
            return _context.Pruebas.Any(e => e.Id == id);
        }
    }
}
