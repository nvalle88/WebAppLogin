namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Pregunta
    {
        [Key]
        public int IdPregunta { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Pregunta:")]
        [StringLength(250, MinimumLength = 2, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string Nombre { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Evaluación de indución:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdEvaluacionInduccion { get; set; }
        public virtual EvaluacionInducion EvaluacionInducion { get; set; }

        public virtual ICollection<DetalleExamenInduccion> DetalleExamenInduccion { get; set; }

        public virtual ICollection<PreguntaRespuesta> PreguntaRespuesta { get; set; }
    }
}
