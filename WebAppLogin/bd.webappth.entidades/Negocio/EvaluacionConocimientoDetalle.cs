namespace bd.webapplogin.entidades.Negocio
{
    using System.ComponentModel.DataAnnotations;

    public partial class EvaluacionConocimientoDetalle
    {
        [Key]
        public int IdEvaluacionConocimientoDetalle { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Evaluación de conocimiento:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdEvaluacionConocimiento { get; set; }
        public virtual EvaluacionConocimiento EvaluacionConocimiento { get; set; }

        [Display(Name = "Nivel de conocimiento:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdNivelConocimiento { get; set; }
        public virtual NivelConocimiento NivelConocimiento { get; set; }


    }
}
