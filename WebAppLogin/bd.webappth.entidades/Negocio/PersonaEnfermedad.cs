namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class PersonaEnfermedad
    {
        [Key]
        public int IdPersonaEnfermedad { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Institucion que emite:")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string InstitucionEmite { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Tipo de enfermedad:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdTipoEnfermedad { get; set; }
        public virtual TipoEnfermedad TipoEnfermedad { get; set; }

        [Display(Name = "Persona:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdPersona { get; set; }
        public virtual Persona Persona { get; set; }

    }
}
