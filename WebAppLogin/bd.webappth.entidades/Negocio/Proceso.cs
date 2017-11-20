namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Proceso
    {
        [Key]
        public int IdProceso { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Proceso:")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string Nombre { get; set; }

        public virtual ICollection<ProcesoDetalle> ProcesoDetalle { get; set; }
    }
}
