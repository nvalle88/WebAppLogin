namespace bd.webapplogin.entidades.Negocio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Parentesco
    {
        [Key]
        public int IdParentesco { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Parentesco:")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string Nombre { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        public virtual ICollection<EmpleadoContactoEmergencia> EmpleadoContactoEmergencia { get; set; }

        public virtual ICollection<EmpleadoFamiliar> EmpleadoFamiliar { get; set; }
    }
}
