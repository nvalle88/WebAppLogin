namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class RequisitosNoCumple
    {
        [Key]
        public int IdRequisitosNoCumple { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Detalle:")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string Detalle { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Administración de talento humano:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int AdministracionTalentoHumanoId { get; set; }
        public virtual AdministracionTalentoHumano AdministracionTalentoHumano { get; set; }
    }
}
