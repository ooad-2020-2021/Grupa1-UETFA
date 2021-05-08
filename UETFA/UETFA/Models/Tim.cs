using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UETFA.Models
{
    public class Tim
    {
        public string ime { get; set; }
        public int datiGolovi { get; set; }
        public int primljeniGolovi { get; set; }
        public int brojOdigranihUtakmica { get; set; }
        public string trener { get; set; }

        [NotMapped]
        public List<Igrac> igraci { get; set; }

    }
}
