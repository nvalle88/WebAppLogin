namespace bd.webapplogin.entidades.Negocio
{
    using System.ComponentModel.DataAnnotations;

    public partial class BrigadaSSORol
    {
        [Key]
        public int IdBrigadaSSORol { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Rol:")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string Nombre { get; set; }

        //Propiedades Virtuales Referencias a otras clases
        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Brigada SSO:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdBrigadaSSO { get; set; }
        public virtual BrigadaSSO BrigadaSSO { get; set; }
    }
}
