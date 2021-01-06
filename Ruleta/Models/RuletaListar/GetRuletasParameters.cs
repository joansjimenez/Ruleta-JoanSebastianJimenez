using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ruleta.Models.RuletaListar
{
    public class GetRuletasParameters
    {
        public int? RuletaID { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "El valor no puede superar 50 Caracteres")]
        public string Codigo { get; set; }
        public bool? Estado { get; set; }
    }
}