using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UETFA.Data;
using UETFA.Models;

namespace UETFA.Controllers
{
    public class PremiumsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PremiumsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult PogledajPogodnosti()
        {
            return View();
        }

 

        // GET: Premiums
        public async Task<IActionResult> Index()
        {
            return View(await _context.Premium.ToListAsync());
        }

        // GET: Premiums/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var premium = await _context.Premium
                .FirstOrDefaultAsync(m => m.ID == id);
            if (premium == null)
            {
                return NotFound();
            }

            return View(premium);
        }

        // GET: Premiums/Create
        public IActionResult Create()
        {
 
            string currentUserId = User.Identity.Name;
            ViewBag.id = new List<SelectListItem>();
            ViewBag.id.Add(new SelectListItem() { Text = currentUserId, Value = currentUserId.ToString() });


            return View();
        }

        // POST: Premiums/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,imeVlasnikaKartice,brojKartice,cvc,datum,IDKor")] Premium premium)
        {

            if (ModelState.IsValid)
            {
                _context.Add(premium);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(premium);
        }

        // GET: Premiums/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var premium = await _context.Premium.FindAsync(id);
            if (premium == null)
            {
                return NotFound();
            }
            return View(premium);
        }

        // POST: Premiums/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,imeVlasnikaKartice,brojKartice,cvc,datum,IDKor")] Premium premium)
        {
            if (id != premium.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(premium);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PremiumExists(premium.ID))
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
            return View(premium);
        }

        // GET: Premiums/Delete/5
        [Authorize(Roles = "Premium")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var premium = await _context.Premium
                .FirstOrDefaultAsync(m => m.ID == id);
            if (premium == null)
            {
                return NotFound();
            }

            return View(premium);
        }

        // POST: Premiums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Premium")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var premium = await _context.Premium.FindAsync(id);
            _context.Premium.Remove(premium);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PremiumExists(int id)
        {
            return _context.Premium.Any(e => e.ID == id);
        }
    }
}
