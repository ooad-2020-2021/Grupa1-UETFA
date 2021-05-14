using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UETFA.Models
{
   
    public class Igrac
    {
        [Key]
        public int ID { get; set; }
        // dodati TimID
        public string imePrezime { get; set; }
        public int brojGolova { get; set; }
        public int brojAsistencija { get; set; }
        public int brojCrvenihKartona { get; set; }
        public int brojZutihKartona { get; set; }

    }
}
