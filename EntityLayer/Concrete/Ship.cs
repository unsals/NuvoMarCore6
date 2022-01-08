using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Ship
    {
        [Key]
        public int ShipId { get; set; }

        [Column(TypeName = "Varchar(50)")]
        public string ShipName { get; set; }

        [Column(TypeName = "Varchar(50)")]
        public string? ShipType { get; set; }

        [Column(TypeName = "decimal(12, 2)")]
        public decimal? ShipGRT { get; set; }

        [Column(TypeName = "decimal(12, 2)")]
        public decimal? ShipNRT { get; set; }

        [Column(TypeName = "decimal(12, 2)")]
        public decimal? ShipDWT { get; set; }

        [Column(TypeName = "Varchar(50)")]
        public string? ShipMMSI { get; set; }

        [Column(TypeName = "Varchar(50)")]
        public string? ShipIMO { get; set; }

        [Column(TypeName = "Varchar(50)")]
        public string? ShipCallSign { get; set; }

        [Column(TypeName = "Varchar(50)")]
        public string? ShipRegistry { get; set; }

        [Column(TypeName = "Varchar(50)")]
        public string? ShipFlag { get; set; }

        [Column(TypeName = "decimal(12, 2)")]
        public decimal? ShipLoa { get; set; }

        [Column(TypeName = "decimal(12, 2)")]
        public decimal? ShipDraft { get; set; }

        public bool? ShipStatus { get; set; }
        public DateTime? ShipCreateDate { get; set; }
        public DateTime? ShipUpdateDate { get; set; }
        public DateTime? ShipDeleteDate { get; set; }

        public List<Voyage> Voyages { get; set; }
    }
}
