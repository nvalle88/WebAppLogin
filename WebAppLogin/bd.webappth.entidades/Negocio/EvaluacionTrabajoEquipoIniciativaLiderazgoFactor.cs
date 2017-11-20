namespace bd.webapplogin.entidades.Negocio
{
    using System.ComponentModel.DataAnnotations;

    public partial class EvaluacionTrabajoEquipoIniciativaLiderazgoFactor
    {
        [Key]
        public int IdEvalTjoEquiInicLidFac { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Factor:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdFactor { get; set; }
        public virtual Factor Factor { get; set; }

        [Display(Name = "Evaluacion Trabajo Equipo Iniciativa Liderazgo:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdEvaluacionTrabajoEquipoIniciativaLiderazgo { get; set; }
        public virtual EvaluacionTrabajoEquipoIniciativaLiderazgo EvaluacionTrabajoEquipoIniciativaLiderazgo { get; set; }

    }
}
