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
    public class TimController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TimController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Tim
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tim.ToListAsync());
        }

        // GET: Tim/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tim = await _context.Tim
                .FirstOrDefaultAsync(m => m.ID == id);
            if (tim == null)
            {
                return NotFound();
            }

            return View(tim);
        }

        // GET: Tim/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tim/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ime,datiGolovi,primljeniGolovi,brojOdigranihUtakmica,trener")] Tim tim)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tim);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tim);
        }

        // GET: Tim/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tim = await _context.Tim.FindAsync(id);
            if (tim == null)
            {
                return NotFound();
            }
            return View(tim);
        }

        // POST: Tim/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ime,datiGolovi,primljeniGolovi,brojOdigranihUtakmica,trener")] Tim tim)
        {
            if (id != tim.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tim);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TimExists(tim.ID))
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
            return View(tim);
        }

        // GET: Tim/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tim = await _context.Tim
                .FirstOrDefaultAsync(m => m.ID == id);
            if (tim == null)
            {
                return NotFound();
            }

            return View(tim);
        }

        // POST: Tim/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tim = await _context.Tim.FindAsync(id);
            _context.Tim.Remove(tim);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TimExists(int id)
        {
            return _context.Tim.Any(e => e.ID == id);
        }
    }
}
