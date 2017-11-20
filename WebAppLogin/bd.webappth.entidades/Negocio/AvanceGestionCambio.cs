namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class AvanceGestionCambio
    {
        [Key]
        public int IdAvanceGestionCambio { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Fecha:")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Indicador real:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int Indicadorreal { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Gestión del cambio:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdActividadesGestionCambio { get; set; }
        public virtual ActividadesGestionCambio ActividadesGestionCambio { get; set; }
    }
}
