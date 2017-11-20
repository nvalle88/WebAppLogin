namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.ComponentModel.DataAnnotations;


    public partial class CapacitacionPlanificacion
    {
        [Key]
        public int IdCapacitacionPlanificacion { get; set; }


        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Número de horas:")]
        [Range(1, 500, ErrorMessage = "Debe seleccionar el {0} ")]
        public int NumeroHoras { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Presupuesto:")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Presupuesto { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Fecha planificación:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }


        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Modalidad:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdCapacitacionTemario { get; set; }
        public virtual CapacitacionModalidad CapacitacionModalidad { get; set; }


        [Display(Name = "Empleado:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdEmpleado { get; set; }
        public virtual Empleado Empleado { get; set; }


        [Display(Name = "Temario:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdCapacitacionModalidad { get; set; }
        public virtual CapacitacionTemario CapacitacionTemario { get; set; }

    }
}
