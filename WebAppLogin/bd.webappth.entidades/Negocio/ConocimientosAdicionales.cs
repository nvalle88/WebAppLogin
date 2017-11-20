namespace bd.webapplogin.entidades.Negocio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class ConocimientosAdicionales
    {
        [Key]
        public int IdConocimientosAdicionales { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Conocimiento adicional:")]
        [StringLength(250, MinimumLength = 2, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string Descripcion { get; set; }

        //Propiedades Virtuales Referencias a otras clases
        public virtual ICollection<IndiceOcupacionalConocimientosAdicionales> IndiceOcupacionalConocimientosAdicionales { get; set; }
    }
}
