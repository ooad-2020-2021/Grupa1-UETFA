using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UETFA.Models
{
    public class Korisnik
    {
        [Key]
        public int ID { get; set; }
        public string ime { get; set; }
        public string Email { get; set; }
    }
}
