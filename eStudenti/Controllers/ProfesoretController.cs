using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using eStudenti.Data;
using eStudenti.Models;

namespace eStudenti.Controllers
{
    public class ProfesoretController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProfesoretController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Profesoret.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profesoret = await _context.Profesoret
                .FirstOrDefaultAsync(m => m.ProfId == id);
            if (profesoret == null)
            {
                return NotFound();
            }

            return View(profesoret);
        }

        // GET: Studentets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Studentets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProfId,ProfEmri,ProfMbiemri,ProfGjinia,ProfDataLindjes,ProfNumriTelefonit,ProfEmail,TitulliAkademik")] Profesoret profesoret)
        {
            if (ModelState.IsValid)
            {
                _context.Add(profesoret);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(profesoret);
        }

        // GET: Studentets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profesoret = await _context.Profesoret.FindAsync(id);
            if (profesoret == null)
            {
                return NotFound();
            }
            return View(profesoret);
        }

        // POST: Studentets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProfId,ProfEmri,ProfMbiemri,ProfGjinia,ProfDataLindjes,ProfNumriTelefonit,ProfEmail,TitulliAkademik")] Profesoret profesoret)
        {
            if (id != profesoret.ProfId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(profesoret);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfesoretExists(profesoret.ProfId))
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
            return View(profesoret);
        }

        // GET: Studentets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profesoret = await _context.Profesoret
                .FirstOrDefaultAsync(m => m.ProfId == id);
            if (profesoret == null)
            {
                return NotFound();
            }

            return View(profesoret);
        }

        // POST: Studentets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var profesoret = await _context.Studentet.FindAsync(id);
            if (profesoret != null)
            {
                _context.Studentet.Remove(profesoret);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfesoretExists(int id)
        {
            return _context.Profesoret.Any(e => e.ProfId == id);
        }
    }
}
