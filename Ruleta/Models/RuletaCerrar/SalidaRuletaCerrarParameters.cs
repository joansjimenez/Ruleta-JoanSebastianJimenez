using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ruleta.Models.RuletaCerrar
{
    public class SalidaRuletaCerrarParameters
    {
        [Required]
        public int? RuletaID { get; set; }
        [Required]
        public bool? Estado { get; set; }
    }
}