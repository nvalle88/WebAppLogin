namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class Permiso
    {
        [Key]
        public int IdPermiso { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Tipo de permiso:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdTipoPermiso { get; set; }
        public virtual TipoPermiso TipoPermiso { get; set; }

        public virtual ICollection<SolicitudPermiso> SolicitudPermiso { get; set; }

    }
}
