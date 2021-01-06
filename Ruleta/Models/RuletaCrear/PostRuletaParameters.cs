using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ruleta.Models.RuletaCrear
{
    public class PostRuletaParameters
    {
        [Required]
        [MaxLength(50, ErrorMessage = "El valor no puede superar 50 Caracteres")]
        public string Codigo { get; set; }
    }
}