namespace bd.webapplogin.entidades.Negocio
{
    using System.ComponentModel.DataAnnotations;

    public partial class EvaluacionActividadesPuestoTrabajoDetalle
    {
        [Key]
        public int IdEvaluacionActividadesPuestoTrabajoDetalle { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Descripción de la actividad:")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string DescripcionActividad { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Meta del periódo:")]
        [Range(1, 100, ErrorMessage = "Debe seleccionar el {0} ")]
        public int MetaPeriodo { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Actividades cumplidas:")]
        [Range(1, 100, ErrorMessage = "Debe seleccionar el {0} ")]
        public int ActividadesCumplidas { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Actividades del puesto de trabajo:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdEvaluacionActividadesPuestoTrabajo { get; set; }
        public virtual EvaluacionActividadesPuestoTrabajo EvaluacionActividadesPuestoTrabajo { get; set; }

        [Display(Name = "Indicador:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdIndicador { get; set; }
        public virtual Indicador Indicador { get; set; }
    }
}
