namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class Eval001
    {
        [Key]
        public int IdEval001 { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "¿Está conforme?:")]
        public bool? EstaConforme { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Fecha de registro:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaRegistro { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Fecha inicio:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaEvaluacionDesde { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Fecha final:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaEvaluacionHasta { get; set; }

        
        [Display(Name = "Observaciones:")]
        [DataType(DataType.Text)]
        public string Observaciones { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Empleado:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdEmpleadoEvaluado { get; set; }
        public virtual Empleado Empleado { get; set; }

        [Display(Name = "Evaluación total:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdEscalaEvaluacionTotal { get; set; }
        public virtual EscalaEvaluacionTotal EscalaEvaluacionTotal { get; set; }

        [Display(Name = "Evaluación puesto de trabajo:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdEvaluacionActividadesPuestoTrabajo { get; set; }
        public virtual EvaluacionActividadesPuestoTrabajo EvaluacionActividadesPuestoTrabajo { get; set; }

        [Display(Name = "Evaluación de conocimiento:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdEvaluacionConocimiento { get; set; }
        public virtual EvaluacionConocimiento EvaluacionConocimiento { get; set; }

        [Display(Name = "Evaluación técnica del puesto:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdEvaluacionCompetenciasTecnicasPuesto { get; set; }
        public virtual EvaluacionCompetenciasTecnicasPuesto EvaluacionCompetenciasTecnicasPuesto { get; set; }

        [Display(Name = "EmEvaluación universalpleado:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdEvaluacionCompetenciasUniversales { get; set; }
        public virtual EvaluacionCompetenciasUniversales EvaluacionCompetenciasUniversales { get; set; }

        [Display(Name = "Evaluación trabajo en equipo:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdEvaluacionTrabajoEquipoIniciativaLiderazgo { get; set; }
        public virtual EvaluacionTrabajoEquipoIniciativaLiderazgo EvaluacionTrabajoEquipoIniciativaLiderazgo { get; set; }

        [Display(Name = "Evaluador:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdEvaluador { get; set; }
        public virtual Evaluador Evaluador { get; set; }
  
    }
}
