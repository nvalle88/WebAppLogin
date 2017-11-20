namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Respuesta
    {
        [Key]
        public int IdRespuesta { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Respuesta:")]
        [StringLength(400, MinimumLength = 2, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string Nombre { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        public virtual ICollection<DetalleExamenInduccion> DetalleExamenInduccion { get; set; }

        public virtual ICollection<PreguntaRespuesta> PreguntaRespuesta { get; set; }
    }
}
