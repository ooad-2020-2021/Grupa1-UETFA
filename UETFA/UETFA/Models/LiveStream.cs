using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UETFA.Models
{
    public class LiveStream
    {
    
        public int ID { get; set; }
        //dodati utakmica ID
        [NotMapped]  
        public Utakmica utakmica { get; set; }

    }
}
