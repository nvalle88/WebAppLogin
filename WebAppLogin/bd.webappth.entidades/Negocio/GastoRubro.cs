namespace bd.webapplogin.entidades.Negocio
{
    using System.ComponentModel.DataAnnotations;

    public partial class GastoRubro
    {
        [Key]
        public int IdGastoRubro { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Gasto proyectado:")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal GastoProyectado { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Empleado impuesto a la renta:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdEmpleadoImpuestoRenta { get; set; }
        public virtual EmpleadoImpuestoRenta EmpleadoImpuestoRenta { get; set; }

        [Display(Name = "Rubro:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdRubro { get; set; }
        public virtual Rubro Rubro { get; set; }
    }
}
