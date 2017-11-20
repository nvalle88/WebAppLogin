namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class DeclaracionPatrimonioPersonal
    {
        [Key]
        public int IdDeclaracionPatrimonioPersonal { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Fecha de declaración:")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime FechaDeclaracion { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Total de activos año anterior:")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal TotalActivosAnioAnterior { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Total de pasivos año anterior:")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal TotalPasivosAnioAnterior { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Total de activos año actual:")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal TotalActivosAnioActual { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Total de pasivos año actual:")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal TotalPasivosAnioActual { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Promedio mensual de ingresos")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal PromedioMensualIngresos { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Promedio mensual de otros ingresos:")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal PromedioMensualOtrosIngresos { get; set; }


        //Propiedades Virtuales Referencias a otras clases
        [Display(Name = "Sub clase de activo fijo:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdEmpleado { get; set; }
        public virtual Empleado Empleado { get; set; }
    }
}
