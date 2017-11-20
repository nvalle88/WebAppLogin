namespace bd.webapplogin.entidades.Negocio
{
    using System.ComponentModel.DataAnnotations;

    public partial class EvaluacionActividadesPuestoTrabajoFactor
    {
        [Key]
        public int IdEvaluacionActividadesPuestoTrabajoFactor { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Actividades puesto de trabajo:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdEvaluacionActividadesPuestoTrabajo { get; set; }
        public virtual EvaluacionActividadesPuestoTrabajo EvaluacionActividadesPuestoTrabajo { get; set; }

        [Display(Name = "Factor:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdFactor { get; set; }
        public virtual Factor Factor { get; set; }
    }
}
