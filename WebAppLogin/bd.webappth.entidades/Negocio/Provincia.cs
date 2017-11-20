namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Provincia
    {
        [Key]
        public int IdProvincia { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Provincia:")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string Nombre { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "País:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdPais { get; set; }
        public virtual Pais Pais { get; set; }

        public virtual ICollection<Ciudad> Ciudad { get; set; }

        public virtual ICollection<Empleado> Empleado { get; set; }

    }
}
