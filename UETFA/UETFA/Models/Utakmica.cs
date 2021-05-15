using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UETFA.Models
{
    public class Utakmica
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("Status Utakmice")]
        public string statusUtakmice { get; set; }
        [DisplayName("Datum Utakmice")]
        public DateTime datumUtakmice { get; set; }
        [DisplayName("Sudija")]
        public Sudija sudija { get; set; }
        [DisplayName("Tim 1")]
        public Tim tim1 { get; set; }
        [DisplayName("Tim 2")]
        public Tim tim2 { get; set; }
        [DisplayName("Rezultat")]
        public Rezultat rezultat { get; set; }

        [NotMapped]
        public List<Igrac> strijelci { get; set; }

        [NotMapped]
        public List<Igrac> asistenti { get; set; }

    }
}
