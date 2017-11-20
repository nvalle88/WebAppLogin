namespace bd.webapplogin.entidades.Negocio
{
    using System.ComponentModel.DataAnnotations;

    public partial class EvaluacionConocimientoFactor
    {
        [Key]
        public int IdEvaluacionConocimientoFactor { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Factor:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdFactor { get; set; }
        public virtual Factor Factor { get; set; }

        [Display(Name = "Evaluación de conocimiento:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdEvaluacionConocimiento { get; set; }
        public virtual EvaluacionConocimiento EvaluacionConocimiento { get; set; }



    }
}
