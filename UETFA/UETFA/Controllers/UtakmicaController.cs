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
    public class UtakmicaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UtakmicaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Utakmica
        public async Task<IActionResult> Index()
        {
          ViewBag.nazivi1 = new List<SelectListItem>();
            ViewBag.nazivi2 = new List<SelectListItem>();
            List<Utakmica> utakmice = _context.Utakmica.ToList();
            List<Tim> timovi = _context.Tim.ToList();
            foreach (var u in utakmice)
           {
                Tim t1 = timovi.Find(t => t.ID == u.idTima1);
                Tim t2 = timovi.Find(t => t.ID == u.idTima2);
              ViewBag.nazivi1.Add(new SelectListItem() { Text=t1.ime , Value=(t1.ID).ToString() });
              ViewBag.nazivi2.Add(new SelectListItem() { Text=t2.ime, Value=(t2.ID).ToString() });
               
            }
            return View(await _context.Utakmica.ToListAsync());
        }

        // GET: Utakmica/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utakmica = await _context.Utakmica
                .FirstOrDefaultAsync(m => m.ID == id);
            if (utakmica == null)
            {
                return NotFound();
            }

            return View(utakmica);
        }

        // GET: Utakmica/Create
        public IActionResult Create()
        {
            ViewBag.Timovi = new List<SelectListItem>();
            List<Tim> timovi = _context.Tim.ToList();
            foreach (var p in timovi)
                ViewBag.Timovi.Add(new SelectListItem() { Text = p.ime, Value = p.ID.ToString() });
            return View();
        }

        // POST: Utakmica/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,statusUtakmice,datumUtakmice,idTima1,idTima2")] Utakmica utakmica)
        {
            if (ModelState.IsValid)
            {
                _context.Add(utakmica);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(utakmica);
        }

        // GET: Utakmica/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utakmica = await _context.Utakmica.FindAsync(id);
            if (utakmica == null)
            {
                return NotFound();
            }
            ViewBag.Timovi = new List<SelectListItem>();
            List<Tim> timovi = _context.Tim.ToList();
            foreach (var p in timovi)
                ViewBag.Timovi.Add(new SelectListItem() { Text = p.ime, Value = p.ID.ToString() });
            return View();
        }

        // POST: Utakmica/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,statusUtakmice,datumUtakmice,idTima1,idTima2")] Utakmica utakmica)
        {
            if (id != utakmica.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(utakmica);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UtakmicaExists(utakmica.ID))
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
            return View(utakmica);
        }

        // GET: Utakmica/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utakmica = await _context.Utakmica
                .FirstOrDefaultAsync(m => m.ID == id);
            if (utakmica == null)
            {
                return NotFound();
            }

            return View(utakmica);
        }

        // POST: Utakmica/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var utakmica = await _context.Utakmica.FindAsync(id);
            _context.Utakmica.Remove(utakmica);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Utakmica/DeleteAll
        public async Task<IActionResult> DeleteAll()
        {
            List<Utakmica> sveUtakmice = _context.Utakmica.ToList();
            foreach (Utakmica u in sveUtakmice)
                _context.Utakmica.Remove(u);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UtakmicaExists(int id)
        {
            return _context.Utakmica.Any(e => e.ID == id);
        }
    }
}
