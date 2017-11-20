namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
     
     

    public partial class PersonaPaquetesInformaticos
    {
        [Key]
        public int IdPersonaPaquetesInformaticos { get; set; }
        
        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Paquetes informáticos:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdPaquetesInformaticos { get; set; }
        public virtual PaquetesInformaticos PaquetesInformaticos { get; set; }

        [Display(Name = "Empleado:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdEmpleado { get; set; }
        public virtual Empleado Empleado { get; set; }

    }
}
