using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PesquisaCrypto.Models;

namespace PesquisaCrypto.Controllers
{
    public class Moedas1Controller : Controller
    {
        private readonly MoedasContext _context;

        public Moedas1Controller(MoedasContext context)
        {
            _context = context;
        }

        // GET: Moedas1
        public async Task<IActionResult> Index()
        {
            return View(await _context.Moedas.ToListAsync());
        }

        // GET: Moedas1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moedas = await _context.Moedas
                .FirstOrDefaultAsync(m => m.ID == id);
            if (moedas == null)
            {
                return NotFound();
            }

            return View(moedas);
        }

        // GET: Moedas1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Moedas1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nome,Quantidade")] Moedas moedas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(moedas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(moedas);
        }

        // GET: Moedas1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moedas = await _context.Moedas.FindAsync(id);
            if (moedas == null)
            {
                return NotFound();
            }
            return View(moedas);
        }

        // POST: Moedas1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nome,Quantidade")] Moedas moedas)
        {
            if (id != moedas.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(moedas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MoedasExists(moedas.ID))
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
            return View(moedas);
        }

        // GET: Moedas1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moedas = await _context.Moedas
                .FirstOrDefaultAsync(m => m.ID == id);
            if (moedas == null)
            {
                return NotFound();
            }

            return View(moedas);
        }

        // POST: Moedas1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var moedas = await _context.Moedas.FindAsync(id);
            _context.Moedas.Remove(moedas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MoedasExists(int id)
        {
            return _context.Moedas.Any(e => e.ID == id);
        }
    }
}
