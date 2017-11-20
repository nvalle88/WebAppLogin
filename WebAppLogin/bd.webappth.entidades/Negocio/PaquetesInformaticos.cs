namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
     
     

    public partial class PaquetesInformaticos
    {
        [Key]
        public int IdPaquetesInformaticos { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Paquetes informáticos:")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Descripción:")]
        [StringLength(500, MinimumLength = 2, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string Descripcion { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        public virtual ICollection<PersonaPaquetesInformaticos> PersonaPaquetesInformaticos { get; set; }
    }
}
