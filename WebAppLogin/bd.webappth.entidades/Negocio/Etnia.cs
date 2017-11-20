namespace bd.webapplogin.entidades.Negocio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Etnia
    {
        [Key]
        public int IdEtnia { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Etnia:")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string Nombre { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        public virtual ICollection<Persona> Persona { get; set; }

        public virtual ICollection<NacionalidadIndigena> NacionalidadIndigena { get; set; }
    }
}
