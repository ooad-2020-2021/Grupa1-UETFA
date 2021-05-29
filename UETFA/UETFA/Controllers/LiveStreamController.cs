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
        public IActionResult Index2(int id)
        {
            PomocnaLS info = new PomocnaLS();
            Utakmica trenutna = _context.LiveStream.ToList().Find(ls => ls.ID == id).utakmica;
            info.Tim1 = _context.Tim.ToList().Find(t => t.ID == trenutna.idTima1).ime;
            info.Tim2 = _context.Tim.ToList().Find(t => t.ID == trenutna.idTima2).ime;
            info.Rezultat = trenutna.rezTim1 + " : " + trenutna.rezTim2;
            // ukoliko budemo stvarno htjeli mijenjati streamove, klasa LiveStream će imati svoj video
            // sad taj atribut ne postoji pa je zato zakomentarisan
            // info.FileName = _context.LiveStream.ToList().Find(ls => ls.ID == id).Filename;
            info.FileName = "ID_YOUTUBE_KANALA";
            return View(info);
        }

        // testna funkcija za predefinisane podatke
        public IActionResult Index()
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
