namespace bd.webapplogin.entidades.Negocio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class EscalaGrados
    {
        [Key]
        public int IdEscalaGrados { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Grado:")]
        [Range(1, 22, ErrorMessage = "El {0} debe estar entre {1} y {2} ")]
        public int? Grado { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Remuneración:")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal? Remuneracion { get; set; }


        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Grupo ocupacional:")]
        public int? IdGrupoOcupacional { get; set; }
        public virtual GrupoOcupacional GrupoOcupacional { get; set; }

        public virtual ICollection<IndiceOcupacional> IndiceOcupacional { get; set; }

       
    }
}
