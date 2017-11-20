namespace bd.webapplogin.entidades.Negocio
{
    using System.ComponentModel.DataAnnotations;

    public partial class AprobacionViatico
    {
        [Key]
        public int IdAprobacionViatico { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Valor justificado:")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal ValorJustificado { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Valor a descontar:")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal ValorADescontar { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Servidor público:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdEmpleado { get; set; }
        public virtual Empleado Empleado { get; set; }

        [Display(Name = "Solicitud de viático:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdSolicitudViatico { get; set; }
        public virtual SolicitudViatico SolicitudViatico { get; set; }
    }
}
