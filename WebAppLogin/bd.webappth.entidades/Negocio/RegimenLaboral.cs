namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
 
    public partial class RegimenLaboral
    {
        [Key]
        public int IdRegimenLaboral { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Régimen laboral:")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string Nombre { get; set; }

        public virtual ICollection<RelacionLaboral> RelacionLaboral { get; set; }
    }
}
