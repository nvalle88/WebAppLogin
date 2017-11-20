namespace bd.webapplogin.entidades.Negocio
{
    using System.ComponentModel.DataAnnotations;

    public partial class ActividadesAnalisisOcupacional
    {
        [Key]
        public int IdActividadesAnalisisOcupacional { get; set; }

        [Display(Name = "Actividades:")]
        [DataType(DataType.Text)]
        public string Actividades { get; set; }

        [Display(Name = "Cumplido:")]
        [Required(ErrorMessage = "Debe introducir {0}")]
        public bool Cumple { get; set; }

        //Referencias a tablas Propiedades Virtuales

        [Display(Name = "Ánalisis ocupacional")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdFormularioAnalisisOcupacional { get; set; }

        public virtual FormularioAnalisisOcupacional FormularioAnalisisOcupacional { get; set; }
    }
}
