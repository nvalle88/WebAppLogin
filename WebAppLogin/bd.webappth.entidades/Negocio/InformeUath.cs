namespace bd.webapplogin.entidades.Negocio
{
    using System.ComponentModel.DataAnnotations;

    public partial class InformeUATH
    {
        [Key]
        public int IdInformeUATH { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "¿Revizar?:")]
        public bool? Revizar { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Manual del puesto de origen:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdManualPuestoOrigen { get; set; }
        public virtual ManualPuesto ManualPuestoOrigen { get; set; }

        [Display(Name = "Manual del puesto de destino:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdManualPuestoDestino { get; set; }
        public virtual ManualPuesto ManualPuestoDestino { get; set; }

        [Display(Name = "Administración de talento humano:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdAdministracionTalentoHumano { get; set; }
        public virtual AdministracionTalentoHumano AdministracionTalentoHumano { get; set; }

        

        
    }
}
