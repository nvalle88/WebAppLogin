namespace bd.webapplogin.entidades.Negocio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class InstitucionFinanciera
    {
        [Key]
        public int IdInstitucionFinanciera { get; set; }



        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Institución financiera:")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "SPI:")]
        public int SPI { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        public virtual ICollection<DatosBancarios> DatosBancarios { get; set; }
    }
}
