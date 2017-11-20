namespace bd.webapplogin.entidades.Negocio
{
    using System.ComponentModel.DataAnnotations;

    public partial class EvaluacionTrabajoEquipoIniciativaLiderazgoDetalle
    {
        [Key]
        public int IdEvaluacionTrabajoEquipoIniciativaLiderazgoDetalle { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Evaluación de Trabajo en Equipo Iniciativa y Liderazgo :")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdEvaluacionTrabajoEquipoIniciativaLiderazgo { get; set; }
        public virtual EvaluacionTrabajoEquipoIniciativaLiderazgo EvaluacionTrabajoEquipoIniciativaLiderazgo { get; set; }

        [Display(Name = "Trabajo en equipo")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdTrabajoEquipoIniciativaLiderazgo { get; set; }
        public virtual TrabajoEquipoIniciativaLiderazgo TrabajoEquipoIniciativaLiderazgo { get; set; }

        [Display(Name = "Relevancia:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdRelevancia { get; set; }
        public virtual Relevancia Relevancia { get; set; }

        [Display(Name = "Frecuencia de aplicación:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdFrecuenciaAplicacion { get; set; }
        public virtual FrecuenciaAplicacion FrecuenciaAplicacion { get; set; }
    }
}
