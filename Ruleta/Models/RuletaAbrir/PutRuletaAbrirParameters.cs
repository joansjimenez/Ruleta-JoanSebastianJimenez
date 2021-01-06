using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ruleta.Models.RuletaAbrir
{
    public class PutRuletaAbrirParameters
    {
        [Required]
        public int? RuletaID { get; set; }
        [Required]
        public bool? Estado { get; set; }
    }
}