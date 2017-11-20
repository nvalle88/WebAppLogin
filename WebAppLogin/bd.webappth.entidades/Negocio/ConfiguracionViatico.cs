namespace bd.webapplogin.entidades.Negocio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class ConfiguracionViatico
    {
        [Key]
        public int IdConfiguracionViatico { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Entrega por día:")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal ValorEntregadoPorDia { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "% a justificar:")]
        [Range(0, 100, ErrorMessage = "El {0} de estar entre {2} y {1} ")]
        public decimal PorCientoAJustificar { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Dependencia:")]
        [Range(0, double.MaxValue, ErrorMessage = "El {0} de estar entre {2} y {1} ")]
        public int IdDependencia { get; set; }
        public virtual Dependencia Dependencia { get; set; }

        public virtual ICollection<SolicitudViatico> SolicitudViatico { get; set; }

    }
}
