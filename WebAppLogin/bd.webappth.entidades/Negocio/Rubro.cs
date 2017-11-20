namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Rubro
    {
        [Key]
        public int IdRubro { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Rubro:")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Tasa porcentual máxima:")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal? TasaPorcentualMaxima { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        public virtual ICollection<GastoRubro> GastoRubro { get; set; }
    }
}
