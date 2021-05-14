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
        public int ID { get; set; }
        // dodati utakmica ID
        [NotMapped] 
        public Utakmica utakmica { get; set; }

        [NotMapped]
        public List<Premium> korisnici { get; set; }

    }
}
