using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UETFA.Models
{
    public class Utakmica
    {
        [Key]
        public int ID { get; set; }

        public string statusUtakmice { get; set; }
        public DateTime datumUtakmice { get; set; }

        public Sudija sudija { get; set; }
        public Tim tim1 { get; set; }
        public Tim tim2 { get; set; }
        public Rezultat rezultat { get; set; }

        [NotMapped]
        public List<Igrac> strijelci { get; set; }

        [NotMapped]
        public List<Igrac> asistenti { get; set; }

    }
}
