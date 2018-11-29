using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    [Table("Instrument")]
    public class Instrument
    {
        [Key]
        public int instrumentID { get; set; }

        public string desc { get; set; }
        public string type { get; set; }
        public decimal price { get; set; }

        [ForeignKey("Client")]
        public int clientID { get; set; }
        public virtual Client Client { get; set; }
    }
}