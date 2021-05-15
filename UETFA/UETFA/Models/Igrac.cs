using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace UETFA.Models
{
   
    public class Igrac
    {
        [Key]
        public int ID { get; set; }
        // dodati TimID
        [DisplayName("Ime i prezime")]
        public string imePrezime { get; set; }
        [DisplayName("Broj Golova")]
        public int brojGolova { get; set; }
        [DisplayName("Broj Asistencija")]
        public int brojAsistencija { get; set; }
        [DisplayName("Broj Crvnenih Kartona")]
        public int brojCrvenihKartona { get; set; }
        [DisplayName("Broj Zutih Kartona")]
        public int brojZutihKartona { get; set; }

    }
}
