namespace bd.webapplogin.entidades.Negocio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class IngresoEgresoRMU
    {
        [Key]
        public int IdIngresoEgresoRMU { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Descripción:")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Cuenta contable:")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string CuentaContable { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Fórmula RMU:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdFormulaRMU { get; set; }
        public virtual FormulasRMU FormulasRMU { get; set; }

        public virtual ICollection<EmpleadoIE> EmpleadoIE { get; set; }

    }
}
