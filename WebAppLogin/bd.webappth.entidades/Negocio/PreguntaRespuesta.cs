namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
     
    public partial class PreguntaRespuesta
    {
        [Key]
        public int IdPreguntaRespuesta { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "¿Verdadero?")]
        public bool? Verdadero { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Pregunta:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdPregunta { get; set; }
        public virtual Pregunta Pregunta { get; set; }

        [Display(Name = "Respuesta:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdRespuesta { get; set; }
        public virtual Respuesta Respuesta { get; set; }
    }
}
