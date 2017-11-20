namespace bd.webapplogin.entidades.Negocio
{
    using System.ComponentModel.DataAnnotations;

    public partial class InstruccionFormal
    {
        [Key]
        public int IdInstruccionFormal { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Instrucción formal:")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string Nombre { get; set; }
    }
}
