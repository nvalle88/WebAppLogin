namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Sucursal
    {
        [Key]
        public int IdSucursal { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Sucursal:")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string Nombre { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Ciudad:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdCiudad { get; set; }
        public virtual Ciudad Ciudad { get; set; }

        public virtual ICollection<Dependencia> Dependencia { get; set; }

       
    }
}
