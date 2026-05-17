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
    public class StudentetsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentetsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Studentet.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentet = await _context.Studentet
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentet == null)
            {
                return NotFound();
            }

            return View(studentet);
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
        public async Task<IActionResult> Create([Bind("Id,Emri,Mbiemri,Gjinia,Vendlindja,Vendbanimi,Shteti,DataLindjes,NumriTelefonit,Email,Biografia")] Studentet studentet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studentet);
        }

        // GET: Studentets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentet = await _context.Studentet.FindAsync(id);
            if (studentet == null)
            {
                return NotFound();
            }
            return View(studentet);
        }

        // POST: Studentets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Emri,Mbiemri,Gjinia,Vendlindja,Vendbanimi,Shteti,DataLindjes,NumriTelefonit,Email,Biografia")] Studentet studentet)
        {
            if (id != studentet.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentetExists(studentet.Id))
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
            return View(studentet);
        }

        // GET: Studentets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentet = await _context.Studentet
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentet == null)
            {
                return NotFound();
            }

            return View(studentet);
        }

        // POST: Studentets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentet = await _context.Studentet.FindAsync(id);
            if (studentet != null)
            {
                _context.Studentet.Remove(studentet);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentetExists(int id)
        {
            return _context.Studentet.Any(e => e.Id == id);
        }
    }
}
