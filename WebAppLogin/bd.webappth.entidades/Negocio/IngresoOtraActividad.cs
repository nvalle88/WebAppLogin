namespace bd.webapplogin.entidades.Negocio
{
    using System.ComponentModel.DataAnnotations;

    public class IngresoOtraActividad
    {
        [Key]
        public int IdIngresoOtraActividad { get; set; }


        [Display(Name = "Empleado")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar {0}")]
        public int IdEmpleado { get; set; }

        [Display(Name = "Año de imposición")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy}", ApplyFormatInEditMode = true)]
        public string Ano { get; set; }


        [Display(Name = "Monto")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [Range(0, double.MaxValue, ErrorMessage = "Debe introducir {0}")]
        [DisplayFormat(DataFormatString ="{0:C2}",ApplyFormatInEditMode =false)]
        public decimal Monto { get; set; }


        //Propiedades Virtuales Relaciones con otras Clase

        public virtual Empleado Empleado { get; set; }
    }
}