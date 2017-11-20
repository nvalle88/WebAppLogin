namespace bd.webapplogin.entidades.Negocio
{
    using System.ComponentModel.DataAnnotations;

    public partial class EvaluacionCompetenciasUniversalesFactor
    {
        [Key]
        public int IdEvaluacionCompetenciasUniversalesFactor { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Factor:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdFactor { get; set; }
        public virtual Factor Factor { get; set; }

        [Display(Name = "Competencias universales:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdEvaluacionCompetenciasUniversales { get; set; }
        public virtual EvaluacionCompetenciasUniversales EvaluacionCompetenciasUniversales { get; set; }


    }
}
