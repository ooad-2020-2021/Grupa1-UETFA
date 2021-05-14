using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace UETFA.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<UETFA.Models.Igrac> Igrac { get; set; }
        public DbSet<UETFA.Models.LiveStream> LiveStream { get; set; }
        public DbSet<UETFA.Models.Notifikacija> Notifikacija { get; set; }
        public DbSet<UETFA.Models.Premium> Premium { get; set; }
        public DbSet<UETFA.Models.Rezultat> Rezultat { get; set; }
        public DbSet<UETFA.Models.Sudija> Sudija { get; set; }
        public DbSet<UETFA.Models.Tim> Tim { get; set; }
        public DbSet<UETFA.Models.Utakmica> Utakmica { get; set; }
    }
}
