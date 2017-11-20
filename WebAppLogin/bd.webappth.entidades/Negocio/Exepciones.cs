namespace bd.webapplogin.entidades.Negocio
{
    using System.ComponentModel.DataAnnotations;

    public partial class Exepciones
    {
        [Key]
        public int IdExepciones { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Detalle:")]
        [StringLength(500, MinimumLength = 20, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string Detalle { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Validacion Inmediato Superior:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdValidacionJefe { get; set; }
        public virtual ValidacionInmediatoSuperior ValidacionInmediatoSuperior { get; set; }
    }
}
