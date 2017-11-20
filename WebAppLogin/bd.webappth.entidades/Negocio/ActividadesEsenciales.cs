namespace bd.webapplogin.entidades.Negocio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class ActividadesEsenciales
    {
        [Key]
        public int IdActividadesEsenciales { get; set; }

        [Required(ErrorMessage = "Debe introducir  {0}")]
        [Display(Name = "Actividades esenciales:")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string Descripcion { get; set; }


        //Propiedades Virtuales
        public virtual ICollection<IndiceOcupacionalActividadesEsenciales> IndiceOcupacionalActividadesEsenciales { get; set; }
    }
}
