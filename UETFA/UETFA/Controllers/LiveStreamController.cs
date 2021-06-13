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
    public class PomocnaLS
    {
        public string Tim1 { get; set; }
        public string Tim2 { get; set; }
        public string Rezultat { get; set; }
        public string FileName { get; set; }
    }
    public class LiveStreamController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LiveStreamController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LiveStream
        // Potrebno promijeniti Index2 u Index
        [Authorize(Roles = "Admin, Premium")]
        public IActionResult Index(int id)
        {
            PomocnaLS info = new PomocnaLS();
            Utakmica trenutna = _context.Utakmica.ToList().Find(ls => ls.statusUtakmice == "U toku");
            info.Tim1 = _context.Tim.ToList().Find(t => t.ID == trenutna.idTima1).ime;
            info.Tim2 = _context.Tim.ToList().Find(t => t.ID == trenutna.idTima2).ime;
            info.Rezultat = trenutna.rezTim1 + " : " + trenutna.rezTim2;
            // ukoliko budemo stvarno htjeli mijenjati streamove, klasa LiveStream će imati svoj video
            // sad taj atribut ne postoji pa je zato zakomentarisan
            // info.FileName = _context.LiveStream.ToList().Find(ls => ls.ID == id).Filename;
            info.FileName = "UCsDpnPJARbH4E0JgWjSDaSA";
            return View(info);
        }

        // testna funkcija za predefinisane podatke
        public IActionResult Index2()
        {
            PomocnaLS info = new PomocnaLS();
            info.Tim1 = "FK Željezničar";
            info.Tim2 = "FK Sarajevo";
            info.Rezultat = "1 : 0";
            // filename je ID kanala koji vrši livestreamanje na YouTube
            info.FileName = "UCOQMD-IluHFLXBRpAMUE-EA";
            return View(info);
        }
    }
}
