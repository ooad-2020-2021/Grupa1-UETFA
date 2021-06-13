using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UETFA.Models;

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

        public DbSet<UETFA.Models.Premium> Premium { get; set; }


        public DbSet<UETFA.Models.Tim> Tim { get; set; }
        public DbSet<UETFA.Models.Utakmica> Utakmica { get; set; }

    }
}
