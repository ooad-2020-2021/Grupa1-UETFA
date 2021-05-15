using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UETFA.Data;
using UETFA.Models;

namespace UETFA.Controllers
{
    public class IgracController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IgracController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Igrac
        public async Task<IActionResult> Index()
        {
            return View(await _context.Igrac.ToListAsync());
        }

        // GET: Igrac/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var igrac = await _context.Igrac
                .FirstOrDefaultAsync(m => m.ID == id);
            if (igrac == null)
            {
                return NotFound();
            }

            return View(igrac);
        }

        // GET: Igrac/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Igrac/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,imePrezime,brojGolova,brojAsistencija,brojCrvenihKartona,brojZutihKartona")] Igrac igrac)
        {
            if (ModelState.IsValid)
            {
                _context.Add(igrac);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(igrac);
        }

        // GET: Igrac/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var igrac = await _context.Igrac.FindAsync(id);
            if (igrac == null)
            {
                return NotFound();
            }
            return View(igrac);
        }

        // POST: Igrac/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,imePrezime,brojGolova,brojAsistencija,brojCrvenihKartona,brojZutihKartona")] Igrac igrac)
        {
            if (id != igrac.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(igrac);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IgracExists(igrac.ID))
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
            return View(igrac);
        }

        // GET: Igrac/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var igrac = await _context.Igrac
                .FirstOrDefaultAsync(m => m.ID == id);
            if (igrac == null)
            {
                return NotFound();
            }

            return View(igrac);
        }

        // POST: Igrac/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var igrac = await _context.Igrac.FindAsync(id);
            _context.Igrac.Remove(igrac);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IgracExists(int id)
        {
            return _context.Igrac.Any(e => e.ID == id);
        }
    }
}
