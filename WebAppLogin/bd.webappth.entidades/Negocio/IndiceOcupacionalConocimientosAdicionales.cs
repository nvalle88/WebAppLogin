namespace bd.webapplogin.entidades.Negocio
{
    using System.ComponentModel.DataAnnotations;

    public partial class IndiceOcupacionalConocimientosAdicionales
    {
        [Key]
        public int IdIndiceOcupacionalConocimientosAdicionales { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Conocimientos adicionales:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdConocimientosAdicionales { get; set; }
        public virtual ConocimientosAdicionales ConocimientosAdicionales { get; set; }

        [Display(Name = "Índice ocupacional:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdIndiceOcupacional { get; set; }
        public virtual IndiceOcupacional IndiceOcupacional { get; set; }
    }
}
