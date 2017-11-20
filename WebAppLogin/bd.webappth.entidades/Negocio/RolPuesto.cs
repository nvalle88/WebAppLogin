namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
     
    public partial class RolPuesto
    {
        [Key]
        public int IdRolPuesto { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Rol del puesto:")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string Nombre { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        public virtual ICollection<AdministracionTalentoHumano> AdministracionTalentoHumano { get; set; }

        public virtual ICollection<IndiceOcupacional> IndiceOcupacional { get; set; }
    }
}
