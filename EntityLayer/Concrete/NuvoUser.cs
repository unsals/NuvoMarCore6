using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class NuvoUser
    {
        [Key]
        public int UsrId { get; set; }
        public string UsrUserName { get; set; }
        public string? UsrName { get; set; }
        public string? UsrSurname { get; set; }
        public string UsrEmail { get; set; }
        public string UsrPassword { get; set; }
        public bool UsrStatus { get; set; }
    }
}
