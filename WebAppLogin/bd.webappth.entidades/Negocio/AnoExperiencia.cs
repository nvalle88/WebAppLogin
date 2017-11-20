namespace bd.webapplogin.entidades.Negocio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class AnoExperiencia
    {

        [Key]
        public int IdAnoExperiencia { get; set; }

        [Required(ErrorMessage = "Debe introducir  {0}")]
        [Display(Name = "Años de experiencia:")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string Descripcion { get; set; }

        public virtual ICollection<ExperienciaLaboralRequerida> ExperienciaLaboralRequerida { get; set; }
    }
}
