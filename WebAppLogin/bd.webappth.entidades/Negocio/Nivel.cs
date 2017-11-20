namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
     
     

    public partial class Nivel
    {
        [Key]
        public int IdNivel { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Nivel:")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string Nombre { get; set; }

        //Propiedades Virtuales Referencias a otras clases
        public virtual ICollection<ComportamientoObservable> ComportamientoObservable { get; set; }
    }
}
