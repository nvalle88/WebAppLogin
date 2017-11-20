namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class FacturaViatico
    {
        [Key]
        public int IdFacturaViatico { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Número de factura:")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string NumeroFactura { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Valor total de la factura:")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal ValorTotalFactura { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Fecha de la factura:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaFactura { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Fecha de aprobado:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? FechaAprobacion { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Valor total aprobado:")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal? ValorTotalAprobacion { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Fecha de aprobado:")]
        [DataType(DataType.Text)]
        public string Observaciones { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Tipo de viático:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdItemViatico { get; set; }
        public virtual ItemViatico ItemViatico { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Itinerario:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int ItinerarioViaticoId { get; set; }
        public virtual ItinerarioViatico ItinerarioViatico { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Aprobado por:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int AprobadoPor { get; set; }
        public virtual Empleado Empleado { get; set; }
    }
}
