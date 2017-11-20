namespace bd.webapplogin.entidades.Negocio
{
    using System.ComponentModel.DataAnnotations;

    public partial class IndiceOcupacionalActividadesEsenciales
    {
        [Key]
        public int IdIndiceOcupacionalActividadesEsenciales { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Actividades esenciales:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdActividadesEsenciales { get; set; }
        public virtual ActividadesEsenciales ActividadesEsenciales { get; set; }

        [Display(Name = "Índice ocupacional:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdIndiceOcupacional { get; set; }
        public virtual IndiceOcupacional IndiceOcupacional { get; set; }
    }
}
