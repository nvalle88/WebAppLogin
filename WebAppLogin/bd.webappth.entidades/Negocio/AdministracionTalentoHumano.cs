namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class AdministracionTalentoHumano
    {
        [Key]
        public int IdAdministracionTalentoHumano { get; set; }


        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Fecha:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }


        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "¿Aplica política?")]
        public bool SeAplicaraPolitica { get; set; }



        //Propiedades Virtuales Referencias a otras clases

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Rol del puesto:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdRolPuesto { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Análisis ocupacional:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdFormularioAnalisisOcupacional { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Responsable:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int EmpleadoResponsable { get; set; }

        public virtual Empleado Empleado { get; set; }

        public virtual FormularioAnalisisOcupacional FormularioAnalisisOcupacional { get; set; }

        public virtual RolPuesto RolPuesto { get; set; }

        public virtual ICollection<RequisitosNoCumple> RequisitosNoCumple { get; set; }

        public virtual ICollection<InformeUATH> InformeUATH { get; set; }
    }
}
