namespace bd.webapplogin.entidades.Negocio
{
    using System.ComponentModel.DataAnnotations;

    public partial class EvaluacionCompetenciasTecnicasPuestoDetalle
    {
        [Key]
        public int IdEvaluacionCompetenciasTecnicasPuestoDetalle { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Sub clase de activo fijo:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdEvaluacionCompetenciasTecnicasPuesto { get; set; }
        public virtual EvaluacionCompetenciasTecnicasPuesto EvaluacionCompetenciasTecnicasPuesto { get; set; }

        [Display(Name = "Destreza:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdDestreza { get; set; }
        public virtual Destreza Destreza { get; set; }

        [Display(Name = "Relevancia:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdRelevancia { get; set; }
        public virtual Relevancia Relevancia { get; set; }

        [Display(Name = "Nivel de desarrollo:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdNivelDesarrollo { get; set; }
        public virtual NivelDesarrollo NivelDesarrollo { get; set; }






        
    }
}
