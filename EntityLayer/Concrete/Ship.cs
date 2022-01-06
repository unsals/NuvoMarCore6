using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Ship
    {
        [Key]
        public int ShipId { get; set; }
        public string? ShipName { get; set; }
        public string? ShipType { get; set; }
        public string? ShipGRT { get; set; }
        public string? ShipNRT { get; set; }
        public string? ShipDWT { get; set; }
        public string? ShipMMSI { get; set; }
        public string? ShipIMO { get; set; }
        public string? ShipCallSign { get; set; }
        public string? ShipRegistry { get; set; }
        public string? ShipFlag { get; set; }
        public string? ShipLoa { get; set; }
        public string? ShipDraft { get; set; }
        public bool? ShipStatus { get; set; }
        public DateTime? ShipCreateDate { get; set; }
        public DateTime? ShipUpdateDate { get; set; }
        public DateTime? ShipDeleteDate { get; set; }

        public List<Voyage> Voyages { get; set; }
    }
}
