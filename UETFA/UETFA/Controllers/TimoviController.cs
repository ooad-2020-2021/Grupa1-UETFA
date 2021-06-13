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
    public class TimoviController : Controller
    {
        private readonly ApplicationDbContext _context;
        private int timSize;

        public TimoviController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Timovi
        [Authorize]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tim.OrderByDescending(o => o.bodovi).ToListAsync());
        }

        // GET: Timovi/Details/5
        [Authorize(Roles = "Admin, Premium")]
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
            var igraci =
                await _context.Igrac.Where(m => m.TimID == id).ToListAsync();

            var par = new Dictionary<List<Igrac>, Tim>();
            par.Add(igraci, tim);
            return View(par);
        }

        // GET: Timovi/Create
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateAsync()
        {
            var timovi = await _context.Tim.ToListAsync();
            timSize = timovi.Count;
            if (timSize == 10)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // POST: Timovi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([Bind("ID,ime,datiGolovi,primljeniGolovi,brojOdigranihUtakmica,trener,brojPobjeda,brojNeriješenih,brojPoraza,bodovi")] Tim tim)
        {

           if (ModelState.IsValid)
            {
                _context.Add(tim);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tim);
        }

        // GET: Timovi/Edit/5
        [Authorize(Roles = "Admin, Sudija")]
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

        // POST: Timovi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Sudija")]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ime,datiGolovi,primljeniGolovi,brojOdigranihUtakmica,trener,brojPobjeda,brojNeriješenih,brojPoraza,bodovi")] Tim tim)
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

        // GET: Timovi/Delete/5
        [Authorize(Roles = "Admin")]
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

        // POST: Timovi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tim = await _context.Tim.FindAsync(id);
            _context.Tim.Remove(tim);
            var igraci =
                await _context.Igrac.Where(m => m.TimID == id).ToListAsync();

            foreach(var igrac in igraci)
            {
                _context.Igrac.Remove(igrac);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TimExists(int id)
        {
            return _context.Tim.Any(e => e.ID == id);
        }


        // igraci dio 


        // GET: Timovi/CreateIgrac
        public IActionResult CreateIgraci()
        {
            ViewBag.Timovi = new List<SelectListItem>();
            List<Tim> timovi = _context.Tim.ToList();
            foreach (var p in timovi)
                ViewBag.Timovi.Add(new SelectListItem() { Text = p.ime, Value = p.ID.ToString() });
            return View();
        }

        // POST: Timovi/CreateIgrac
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateIgraci([Bind("ID,TimID,imePrezime,brojGolova,brojAsistencija,brojCrvenihKartona,brojZutihKartona")] Igrac igrac)
        {
            if (ModelState.IsValid)
            {
                _context.Add(igrac);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(igrac);
        }
        // GET: Timovi/Delete/5
        public async Task<IActionResult> DeleteIgraci(int? id)
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

        // POST: Timovi/Delete/5
        [HttpPost, ActionName("DeleteIgraci")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmedIgraci(int id)
        {
            var igrac = await _context.Igrac.FindAsync(id);
            _context.Igrac.Remove(igrac);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        // GET: Timovi/Details/5
        public async Task<IActionResult> DetailsIgraci(int? id)
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

        // GET: Timovi/Edit/5
        public async Task<IActionResult> EditIgraci(int? id)
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

        // POST: Timovi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditIgraci(int id, [Bind("ID,TimID,imePrezime,brojGolova,brojAsistencija,brojCrvenihKartona,brojZutihKartona")] Igrac igrac)
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




        private bool IgracExists(int id)
        {
            return _context.Igrac.Any(e => e.ID == id);
        }

        private async Task izracunajSizeAsync()
        {
            var timovi = await _context.Tim.ToListAsync();
            timSize = timovi.Count;
        }


    }
}

