namespace bd.webapplogin.entidades.Negocio
{
    using System.ComponentModel.DataAnnotations;

    public partial class ImpuestoRentaParametros
    {
        [Key]
        public int IdImpuestoRentaParametros { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Fracción básica:")]
        public decimal FraccionBasica { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Exceso de hasta:")]
        public decimal ExcesoHasta { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Impuesto de fracción básica:")]
        public int? ImpuestoFraccionBasica { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Range(0, 100, ErrorMessage = "El porcentaje debería ser entre 0 y 100")]
        [Display(Name = "Porcentaje de impuesto de fracción excedente:")]
        public int PorcentajeImpuestoFraccionExcedente { get; set; }
    }
}
