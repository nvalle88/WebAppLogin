namespace bd.webapplogin.entidades.Negocio
{
    using System.ComponentModel.DataAnnotations;

    public partial class EvaluacionCompetenciasUniversalesDetalle
    {
        [Key]
        public int IdEvaluacionCompetenciasUniversalesDetalle { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Competencias universales:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdEvaluacionCompetenciasUniversales { get; set; }
        public virtual EvaluacionCompetenciasUniversales EvaluacionCompetenciasUniversales { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Destreza:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdDestreza { get; set; }
        public virtual Destreza Destreza { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Relevancia:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdRelevancia { get; set; }
        public virtual Relevancia Relevancia { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Frecuencia de aplicación:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdFrecuenciaAplicacion { get; set; }
        public virtual FrecuenciaAplicacion FrecuenciaAplicacion { get; set; }






       
    }
}
