namespace bd.webapplogin.entidades.Negocio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class EvaluacionConocimiento
    {
        [Key]
        public int IdEvaluacionConocimiento { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Conocimiento:")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string Nombre { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        public virtual ICollection<Eval001> Eval001 { get; set; }

        public virtual ICollection<EvaluacionConocimientoFactor> EvaluacionConocimientoFactor { get; set; }

        public virtual ICollection<EvaluacionConocimientoDetalle> EvaluacionConocimientoDetalle { get; set; }
    }
}
