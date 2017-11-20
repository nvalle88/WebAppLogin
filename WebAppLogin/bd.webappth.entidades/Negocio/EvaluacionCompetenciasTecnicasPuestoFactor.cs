namespace bd.webapplogin.entidades.Negocio
{
    using System.ComponentModel.DataAnnotations;

    public partial class EvaluacionCompetenciasTecnicasPuestoFactor
    {
        [Key]
        public int IdEvaluacionCompetenciasTecnicasPuestoFactor { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Factor:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdFactor { get; set; }
        public virtual Factor Factor { get; set; }

        [Display(Name = "Evaluación técnica del puesto:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdEvaluacionCompetenciasTecnicasPuesto { get; set; }
        public virtual EvaluacionCompetenciasTecnicasPuesto EvaluacionCompetenciasTecnicasPuesto { get; set; }

       
    }
}
