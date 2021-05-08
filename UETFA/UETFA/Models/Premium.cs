using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UETFA.Models
{
    public class Premium
    {
        public string imeVlasnikaKartice { get; set; }
        public int brojKartice { get; set; }
        public int cvc { get; set; }
        public DateTime datum { get; set; }
    }
}
