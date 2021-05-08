using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UETFA.Models
{
    public class Bodovi
    {
        public int brojPobjeda { get; set; }
        public int brojPoraza { get; set; }
        public int brojNerijesenih { get; set; }

        public int izracunajBodove()
        {
            int bodovi = brojPobjeda * 3 + brojNerijesenih;
            return bodovi;
        }
    }
}
