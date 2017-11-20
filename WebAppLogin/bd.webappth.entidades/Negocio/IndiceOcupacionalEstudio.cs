namespace bd.webapplogin.entidades.Negocio
{
    using System.ComponentModel.DataAnnotations;


    public partial class IndiceOcupacionalEstudio
    {
        [Key]
        public int IdIndiceOcupacionalEstudio { get; set; }
        
        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Índice ocupacional:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdIndiceOcupacional { get; set; }
        public virtual IndiceOcupacional IndiceOcupacional { get; set; }

        [Display(Name = "Estudio:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdEstudio { get; set; }
        public virtual Estudio Estudio { get; set; }

    }
}
