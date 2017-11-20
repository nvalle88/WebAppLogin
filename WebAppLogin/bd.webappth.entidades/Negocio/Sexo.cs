namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
     
    public partial class Sexo
    {
        [Key]
        public int IdSexo { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Sexo:")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        public string Nombre { get; set; }

        //Propiedades Virtuales Referencias a otras clases
        public virtual ICollection<Persona> Persona { get; set; }
    }
}
