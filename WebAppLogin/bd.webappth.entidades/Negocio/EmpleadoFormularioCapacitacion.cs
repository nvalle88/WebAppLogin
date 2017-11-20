using System.ComponentModel.DataAnnotations;

namespace bd.webapplogin.entidades.Negocio
{

    public partial class EmpleadoFormularioCapacitacion
    {
        [Key]
        public int IdEmpleadoFormularioCapacitacion { get; set; }

        public int? IdEvento { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Servidor público:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdServidor { get; set; }
        public virtual Empleado Servidor { get; set; }

        //[Display(Name = "Servidor responsable:")]
        //[Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        //public int ResponsableArea { get; set; }
        //public virtual Empleado EmpleadoResponsableArea { get; set; }

        //[Display(Name = "Aprobado por:")]
        //[Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        //public int AporbadoPor { get; set; }
        //public virtual Empleado AprobadoPor { get; set; }

        //[Display(Name = "Revisado por:")]
        //[Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        //public int RevisadoPor { get; set; }
        //public virtual Empleado EmpleadoRevisadoPor { get; set; }

        [Display(Name = "Formulario de capacitación:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdFormularioCapacitacion { get; set; }
        public virtual FormularioCapacitacion FormularioCapacitacion { get; set; }
    }
}
