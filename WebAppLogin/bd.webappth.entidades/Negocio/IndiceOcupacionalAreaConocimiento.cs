namespace bd.webapplogin.entidades.Negocio
{
    using System.ComponentModel.DataAnnotations;

    public partial class IndiceOcupacionalAreaConocimiento
    {
        [Key]
        public int IdIndiceOcupacionalAreaConocimiento { get; set; }
        
        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Área de conocimiento:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdAreaConocimiento { get; set; }
        public virtual AreaConocimiento AreaConocimiento { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Índice ocupacional:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdIndiceOcupacional { get; set; }
        public virtual IndiceOcupacional IndiceOcupacional { get; set; }
    }
}
