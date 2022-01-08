using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class NuvoUser
    {
        [Key]
        public int UsrId { get; set; }

        [Column(TypeName = "Varchar(100)")]
        public string UsrUserName { get; set; }

        [Column(TypeName = "Varchar(100)")]
        public string? UsrName { get; set; }

        [Column(TypeName = "Varchar(100)")]
        public string? UsrSurname { get; set; }

        [Column(TypeName = "Varchar(150)")]
        public string UsrEmail { get; set; }

        [Column(TypeName = "Varchar(150)")]
        public string UsrPassword { get; set; }

        public bool UsrStatus { get; set; }
    }
}
