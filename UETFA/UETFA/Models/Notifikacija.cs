using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UETFA.Models
{
    public class Notifikacija
    {
        [Key]
        public int idNotifikacije { get; set; }
        [NotMapped]
        public Utakmica utakmica { get; set; }
        public List<Premium> korisnici { get; set; }

    }
}
