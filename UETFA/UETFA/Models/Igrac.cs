using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UETFA.Models
{
   
    public class Igrac
    {
        [Key]
        public int ID { get; set; }
        // dodati TimID
        public int TimID { get; set; }
        [DisplayName("Ime i prezime")]
        public string imePrezime { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Broj golova mora biti nenegativan broj.")]
        [DisplayName("Broj Golova")]
        public int brojGolova { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Broj asistencija mora biti nenegativan broj.")]
        [DisplayName("Broj Asistencija")]
        public int brojAsistencija { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Broj crvenih kartona mora biti nenegativan broj.")]
        [DisplayName("Broj Crvnenih Kartona")]
        public int brojCrvenihKartona { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Broj žutih kartona mora biti nenegativan broj.")]
        [DisplayName("Broj Zutih Kartona")]
        public int brojZutihKartona { get; set; }

    }
}
