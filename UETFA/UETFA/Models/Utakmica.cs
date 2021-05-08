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

        public int idUtakmice { get; set; }
        public string statusUtakmice { get; set; }
        public DateTime datumUtakmice { get; set; }

        [NotMapped]

        public Sudija sudija { get; set; }
        public Tim tim1 { get; set; }
        public Tim tim2 { get; set; }
        public Rezultat rezultat { get; set; }
        public List<Igrac> strijelci { get; set; }
        public List<Igrac> asistenti { get; set; }

    }
}
