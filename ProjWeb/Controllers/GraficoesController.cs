using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjWeb.Data;
using ProjWeb.Models;

namespace ProjWeb.Controllers
{
    public class GraficoesController : Controller
    {
        private readonly ProjWebContext _context;

        public GraficoesController(ProjWebContext context)
        {
            _context = context;
        }

        // GET: Graficoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Grafico.ToListAsync());
        }

        // GET: Graficoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grafico = await _context.Grafico
                .FirstOrDefaultAsync(m => m.Id == id);
            if (grafico == null)
            {
                return NotFound();
            }

            return View(grafico);
        }

        // GET: Graficoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Graficoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,QtdA,QtdB")] Grafico grafico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(grafico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(grafico);
        }

        // GET: Graficoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grafico = await _context.Grafico.FindAsync(id);
            if (grafico == null)
            {
                return NotFound();
            }
            return View(grafico);
        }

        // POST: Graficoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,QtdA,QtdB")] Grafico grafico)
        {
            if (id != grafico.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(grafico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GraficoExists(grafico.Id))
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
            return View(grafico);
        }

        // GET: Graficoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grafico = await _context.Grafico
                .FirstOrDefaultAsync(m => m.Id == id);
            if (grafico == null)
            {
                return NotFound();
            }

            return View(grafico);
        }

        // POST: Graficoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var grafico = await _context.Grafico.FindAsync(id);
            _context.Grafico.Remove(grafico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GraficoExists(int id)
        {
            return _context.Grafico.Any(e => e.Id == id);
        }
    }
}
