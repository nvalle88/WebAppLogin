namespace bd.webapplogin.entidades.Negocio
{
    using System.ComponentModel.DataAnnotations;

    public partial class EmpleadoNepotismo
    {
        [Key]
        public int IdEmpleadoNepotismo { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Empleado:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdEmpleado { get; set; }
        public virtual Empleado Empleado { get; set; }
        
        //[Display(Name = "Familiar:")]
        //[Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        //public int IdEmpleadoFamiliar { get; set; }
        //public virtual Empleado EmpleadoFamiliar { get; set; }
        

       
    }
}
