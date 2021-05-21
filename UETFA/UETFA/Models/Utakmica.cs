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
        [DisplayName("Tim 1")]
        public int idTima1 { get; set; }
        [DisplayName("Tim 2")]
        public int idTima2 { get; set; }
        [DisplayName("Golovi domaćina")]
        public int rezTim1 { get; set; }
        [DisplayName("Golovi gosta")]
        public int rezTim2 { get; set; }
        [NotMapped]
        public List<Igrac> strijelci { get; set; }

        [NotMapped]
        public List<Igrac> asistenti { get; set; }


    }
}
