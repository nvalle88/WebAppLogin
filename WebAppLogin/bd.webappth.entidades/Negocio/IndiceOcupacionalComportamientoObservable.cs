namespace bd.webapplogin.entidades.Negocio
{
    using System.ComponentModel.DataAnnotations;

    public partial class IndiceOcupacionalComportamientoObservable
    {
        [Key]
        public int IdIndiceOcupacionalComportamientoObservable { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Comportamiento observable:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdComportamientoObservable { get; set; }
        public virtual ComportamientoObservable ComportamientoObservable { get; set; }

        [Display(Name = "Índice ocupacional:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdIndiceOcupacional { get; set; }
        public virtual IndiceOcupacional IndiceOcupacional { get; set; }
    }
}
