namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class RelacionLaboral
    {
        [Key]
        public int IdRelacionLaboral { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Relación laboral:")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string Nombre { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Régimen laboral:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdRegimenLaboral { get; set; }
        public virtual RegimenLaboral RegimenLaboral { get; set; }

        public virtual ICollection<ModalidadPartida> ModalidadPartida { get; set; }

        public virtual ICollection<TipoNombramiento> TipoNombramiento { get; set; }
    }
}
