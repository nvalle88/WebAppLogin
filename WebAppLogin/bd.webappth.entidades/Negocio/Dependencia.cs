namespace bd.webapplogin.entidades.Negocio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Dependencia
    {
        [Key]
        public int IdDependencia { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Dependencia:")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string Nombre { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Dependencia padre:")]
        [Range(0, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdDependenciaPadre { get; set; }
        public virtual Dependencia DependenciaPadre { get; set; }

        [Display(Name = "Sucursal:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdSucursal { get; set; }
        public virtual Sucursal Sucursal { get; set; }

        public virtual ICollection<ConfiguracionViatico> ConfiguracionViatico { get; set; }

        public virtual ICollection<Empleado> Empleado { get; set; }

        public virtual ICollection<Evaluador> Evaluador { get; set; }

        public virtual ICollection<DependenciaDocumento> DependenciaDocumento { get; set; }

        public virtual ICollection<SituacionPropuesta> SituacionPropuesta { get; set; }

        public virtual ICollection<Dependencia> Dependencia1 { get; set; }

        public virtual ICollection<ProcesoDetalle> ProcesoDetalle { get; set; }

        public virtual ICollection<IndiceOcupacional> IndiceOcupacional { get; set; }

        
    }
}
