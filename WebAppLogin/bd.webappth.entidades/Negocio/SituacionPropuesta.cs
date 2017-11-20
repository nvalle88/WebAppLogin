namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class SituacionPropuesta
    {
        [Key]
        public int IdSituacionPropuesta { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Año:")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Ano { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Número de propuesta:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? NumeroPropuesta { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Brecha:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? Brecha { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Observaciones:")]
        [DataType(DataType.MultilineText)]
        [StringLength(400, MinimumLength = 2, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string Observaciones { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Dependencia:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdDependencia { get; set; }
        public virtual Dependencia Dependencia { get; set; }


    }
}
