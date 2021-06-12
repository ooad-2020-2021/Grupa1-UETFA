using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace UETFA.Models
{
    public class Premium
    {
        public int ID{ get; set; }
        [DisplayName("Ime")]
        public string imeVlasnikaKartice { get; set; }
        [DisplayName("Broj kreditne kartice")]
        public int brojKartice { get; set; }
        [DisplayName("Sigurnosni kod(CVV)")]
        public int cvc { get; set; }
        [DisplayName("Datum isteka kartice")]
        public DateTime datum { get; set; }

        public string IDKor { get; set; }
    }
}
