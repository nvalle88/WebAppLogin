namespace bd.webapplogin.entidades.Negocio
{
    using System.ComponentModel.DataAnnotations;

    public partial class EmpleadosFormularioDevengacion
    {
        [Key]
        public int IdEmpleadosFormularioDevengacion { get; set; }
        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Empleado:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdEmpleado { get; set; }
        public virtual Empleado Empleado { get; set; }

        [Display(Name = "Formulario de devengación:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdFormularioDevengacion { get; set; }
        public virtual FormularioDevengacion FormularioDevengacion { get; set; }
    }
}
