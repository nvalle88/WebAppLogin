namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class SolicitudCertificadoPersonal
    {
        [Key]
        public int IdSolicitudCertificadoPersonal { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Fecha de solicitud:")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime FechaSolicitud { get; set; }

        [Display(Name = "Observaciones:")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string Observaciones { get; set; }

        [Display(Name = "Estado:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdEstado { get; set; }
        public virtual Estado Estado { get; set; }

        [Display(Name = "Tipo certificado:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdTipoCertificado { get; set; }
        public virtual TipoCertificado TipoCertificado { get; set; }

        [Display(Name = "Empleado solicitante:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        [ForeignKey("IdEmpleadoSolicitud")]
        public int? IdEmpleadoSolicitante { get; set; }
        public virtual Empleado EmpleadoSolicitante { get; set; }

        [Display(Name = "Dirigido a:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        [ForeignKey("IdEmpleado")]
        public int? IdEmpleadoDirigidoA { get; set; }
        public virtual Empleado EmpleadoDirigidoA { get; set; }

    }
}
