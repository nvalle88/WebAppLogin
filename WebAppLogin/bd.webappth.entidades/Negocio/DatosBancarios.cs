namespace bd.webapplogin.entidades.Negocio
{
    using System.ComponentModel.DataAnnotations;

    public partial class DatosBancarios
    {
        [Key]
        public int IdDatosBancarios { get; set; }

        [Display(Name = "Número de cuenta")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [MaxLength(15, ErrorMessage = "El campo {0} no puede ser mayor de {1}")]
        public string NumeroCuenta { get; set; }

        [Display(Name = "¿Cuenta de ahorros?")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public bool Ahorros { get; set; }

        [Display(Name = "Empleado")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar {0}")]
        public int IdEmpleado { get; set; }
        public virtual Empleado Empleado { get; set; }

        [Display(Name = "Institución Financiera")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar {0}")]
        public int IdInstitucionFinanciera { get; set; }
        public virtual InstitucionFinanciera InstitucionFinanciera { get; set; }

        

       

        
    }
}
