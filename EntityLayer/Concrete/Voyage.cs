using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Voyage
    {
        [Key]
        public int VoyageId { get; set; }
        public int? ShipId { get; set; }
        public int? PortId { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? VoyageArrivalDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? VoyageDepartureDate { get; set; }

        public DateTime? VoyageCreateDate { get; set; }
        public DateTime? VoyageUpdateDate { get; set; }
        public DateTime? VoyageDeleteDate { get; set; }

        public Port Port { get; set; }
        public Ship Ship { get; set; }

    }
}
