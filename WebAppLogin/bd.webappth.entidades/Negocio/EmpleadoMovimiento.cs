namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class EmpleadoMovimiento
    {
        [Key]
        public int IdEmpleadoMovimiento { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Fecha inicio:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaDesde { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Fecha final:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? FechaHasta { get; set; }


        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Tipo de movimiento interno:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdTipoMovimientoInterno { get; set; }
        public virtual TipoMovimientoInterno TipoMovimientoInterno { get; set; }

        [Display(Name = "Índice ocupacional:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdIndiceOcupacionalModalidadPartida { get; set; }
        public virtual IndiceOcupacionalModalidadPartida IndiceOcupacionalModalidadPartida { get; set; }

        [Display(Name = "Empleado:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdEmpleado { get; set; }
        public virtual Empleado Empleado { get; set; }

       

       
    }
}
