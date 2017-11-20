namespace bd.webapplogin.entidades.Negocio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class ConfiguracionContabilidad
    {
        [Key]
        public int IdConfiguracionContabilidad { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Cuenta Debe:")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal ValorD { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Cuenta haber:")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal ValorH { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        

        public virtual ICollection<MotivoAsiento> MotivoAsiento { get; set; }
    }
}
