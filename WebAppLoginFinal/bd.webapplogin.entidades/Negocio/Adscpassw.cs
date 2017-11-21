using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace bd.webappth.entidades.Negocio
{
    public partial class Adscpassw
    {
        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Base de Datos")]
        [StringLength(32, MinimumLength = 4, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string AdpsLogin { get; set; }
        public string AdpsPassword { get; set; }
        public DateTime? AdpsFechaCambio { get; set; }
        public DateTime? AdpsFechaVencimiento { get; set; }
        public string AdpsLoginAdm { get; set; }
        public int? AdpsIntentos { get; set; }
        public string AdpsPasswCg { get; set; }
        public string AdpsTipoUso { get; set; }
        public string AdpsIdContacto { get; set; }
        public string AdpsIdEntidad { get; set; }
        public string AdpsPreguntaRecuperacion { get; set; }
        public string AdpsRespuestaRecuperacion { get; set; }
        public string AdpsCodigoEmpleado { get; set; }
    }
}
