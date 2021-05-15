using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UETFA.Models
{
    public class Tim
    {
        public int ID { get; set; }
        [DisplayName("Ime")]
        public string ime { get; set; }
        [DisplayName("Dati Golovi")]
        public int datiGolovi { get; set; }
        [DisplayName("Primljeni Golovi")]
        public int primljeniGolovi { get; set; }
        [DisplayName("Broj Odigranih Utakmica")]
        public int brojOdigranihUtakmica { get; set; }
        [DisplayName("Trener")]
        public string trener { get; set; }

        [NotMapped]
        public List<Igrac> igraci { get; set; }

    }
}
