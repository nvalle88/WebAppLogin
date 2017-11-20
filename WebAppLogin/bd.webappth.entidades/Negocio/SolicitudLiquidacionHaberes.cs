namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class SolicitudLiquidacionHaberes
    {
        [Key]
        public int IdSolicitudLiquidacionHaberes { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Fecha de solicitud:")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public DateTime FechaSolicitud { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Total vacaciones:")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal TotalVacaciones { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Total décimo Tercero:")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal TotalDecimoTercero { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Total décimo cuarto:")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal TotalDecimoCuarto { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Total fondo de reserva:")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal? TotalFondoReserva { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Total por desahucio:")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal? TotalDesahucio { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Total por despido intempestivo:")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal? TotalDespidoIntempestivo { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Empleado:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdEmpleado { get; set; }
        public virtual Empleado Empleado { get; set; }

    }
}
