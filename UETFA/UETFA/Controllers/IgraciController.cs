using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UETFA.Data;
using UETFA.Models;

namespace UETFA.Controllers
{
    public class IgraciController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IgraciController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Igraci
        [Authorize]
        public async Task<IActionResult> Index()
        {
            ViewBag.nazivi1 = new List<SelectListItem>();
            List<Igrac> igraci = _context.Igrac.ToList();
            List<Tim> timovi = _context.Tim.ToList();
            foreach (var u in igraci)
            {
                Tim t1 = timovi.Find(t => t.ID == u.TimID);
                ViewBag.nazivi1.Add(new SelectListItem() { Text = t1.ime, Value = (t1.ID).ToString() });
            }
            return View(await _context.Igrac.OrderByDescending(m => m.brojGolova).ToListAsync());
        }

        // GET: Asistenti
        [Authorize(Roles = "Admin, Premium")]
        public async Task<IActionResult> Asistenti()
        {
            ViewBag.nazivi1 = new List<SelectListItem>();
            List<Igrac> igraci = _context.Igrac.ToList();
            List<Tim> timovi = _context.Tim.ToList();
            foreach (var u in igraci)
            {
                Tim t1 = timovi.Find(t => t.ID == u.TimID);
                ViewBag.nazivi1.Add(new SelectListItem() { Text = t1.ime, Value = (t1.ID).ToString() });
            }
            return View(await _context.Igrac.OrderByDescending(m => m.brojAsistencija).ToListAsync());
        }


        // GET: Igraci/Details/5
        [Authorize(Roles = "Admin, Premium")]
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
            ViewBag.nazivi1 = new List<SelectListItem>();
            List<Igrac> igraci = _context.Igrac.ToList();
            List<Tim> timovi = _context.Tim.ToList();
            foreach (var u in igraci)
            {
                if (u.ID == id)
                {
                    Tim t1 = timovi.Find(t => t.ID == u.TimID);
                    ViewBag.nazivi1.Add(new SelectListItem() { Text = t1.ime, Value = (t1.ID).ToString() });
                }
            }
            return View(igrac);
        }

        // GET: Igraci/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            ViewBag.Timovi = new List<SelectListItem>();
            List<Tim> timovi = _context.Tim.ToList();
            foreach (var p in timovi)
                ViewBag.Timovi.Add(new SelectListItem() { Text = p.ime, Value = p.ID.ToString() });
            return View();
        }

        // POST: Igraci/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([Bind("ID,TimID,imePrezime,brojGolova,brojAsistencija,brojCrvenihKartona,brojZutihKartona")] Igrac igrac)
        {
            if (ModelState.IsValid)
            {
                _context.Add(igrac);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(igrac);
        }

        // GET: Igraci/Edit/5
        [Authorize(Roles = "Admin, Sudija")]
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
            ViewBag.Timovi = new List<SelectListItem>();
            List<Tim> timovi = _context.Tim.ToList();
            foreach (var p in timovi)
                ViewBag.Timovi.Add(new SelectListItem() { Text = p.ime, Value = p.ID.ToString() });
            return View(igrac);
        }

        // POST: Igraci/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Sudija")]
        public async Task<IActionResult> Edit(int id, [Bind("ID,TimID,imePrezime,brojGolova,brojAsistencija,brojCrvenihKartona,brojZutihKartona")] Igrac igrac)
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

        // GET: Igraci/Delete/5
        [Authorize(Roles = "Admini")]
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
            ViewBag.nazivi1 = new List<SelectListItem>();
            List<Igrac> igraci = _context.Igrac.ToList();
            List<Tim> timovi = _context.Tim.ToList();
            foreach (var u in igraci)
            {
                if (u.ID == id)
                {
                    Tim t1 = timovi.Find(t => t.ID == u.TimID);
                    ViewBag.nazivi1.Add(new SelectListItem() { Text = t1.ime, Value = (t1.ID).ToString() });
                }
                }
            return View(igrac);
        }

        // POST: Igraci/Delete/5
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
