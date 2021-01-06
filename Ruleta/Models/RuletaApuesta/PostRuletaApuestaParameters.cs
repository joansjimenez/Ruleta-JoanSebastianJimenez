using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ruleta.Models.RuletaApuesta
{
    public class PostRuletaApuestaParameters
    {
        [Required]
        public int? CodigoApuesta { get; set; }
        [Required]
        public int? NumeroID { get; set; }
        [Required]
        public int? ColorID { get; set; }
        [Required]
        public float? Cantidad { get; set; }
        [Required]
        public int? UsuarioID { get; set; }
        [Required]
        public int? UsuarioCreditos { get; set; }
    }
}