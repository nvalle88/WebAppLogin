namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
     
    public partial class ProcesoDetalle
    {
        [Key]
        public int IdProcesoDetalle { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Proceso:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdProceso { get; set; }
        public virtual Proceso Proceso { get; set; }

        [Display(Name = "Dependencia:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdDependencia { get; set; }
        public virtual Dependencia Dependencia { get; set; }
    }
}
