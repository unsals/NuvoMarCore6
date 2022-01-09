using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Port
    {
        [Key]
        public int PortId { get; set; }

        [Column(TypeName = "Varchar(50)")]
        public string PortName { get; set; }

        [Column(TypeName = "Varchar(50)")]
        public string? PortCity { get; set; }

        public DateTime? PortCreateDate { get; set; }
        public DateTime? PortUpdateDate { get; set; }
        public DateTime? PortDeleteDate { get; set; }
        public bool PortStatus { get; set; }

        public List<Voyage>? Voyages { get; set; }
    }
}
