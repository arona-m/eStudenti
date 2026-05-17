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
    public class KursetController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KursetController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Kurset.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kurset = await _context.Kurset
                .FirstOrDefaultAsync(m => m.KursiId == id);
            if (kurset == null)
            {
                return NotFound();
            }

            return View(kurset);
        }

        //GET: Studentets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Studentets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("KursiId,EmriKursit,Ligjerusi,Kredit,Statusi")] Kurset kurset)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kurset);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kurset);
        }

        // GET: Studentets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kurset = await _context.Kurset.FindAsync(id);
            if (kurset == null)
            {
                return NotFound();
            }
            return View(kurset);
        }

        // POST: Studentets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("KursiId,EmriKursit,Ligjerusi,Kredit,Statusi")] Kurset kurset)
        {
            if (id != kurset.KursiId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kurset);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KursetExist(kurset.KursiId))
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
            return View(kurset);
        }

        // GET: Studentets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kurset = await _context.Kurset
                .FirstOrDefaultAsync(m => m.KursiId == id);
            if (kurset == null)
            {
                return NotFound();
            }

            return View(kurset);
        }

        // POST: Studentets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kurset = await _context.Kurset.FindAsync(id);
            if (kurset != null)
            {
                _context.Kurset.Remove(kurset);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KursetExist(int id)
        {
            return _context.Kurset.Any(e => e.KursiId == id);
        }
    }
}

