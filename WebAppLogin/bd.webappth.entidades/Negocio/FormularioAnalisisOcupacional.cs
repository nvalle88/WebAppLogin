namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class FormularioAnalisisOcupacional
    {
        [Key]
        public int IdFormularioAnalisisOcupacional { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "¿Misión del proceso?")]
        public bool? InternoMismoProceso { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "¿Otro porceso?")]
        public bool? InternoOtroProceso { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "¿externos ckiudadanía?")]
        public bool? ExternosCiudadania { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "¿ExtPersJurídicasPubNivelNacional?")]
        public bool? ExtPersJurídicasPubNivelNacional { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Fecha de registro:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaRegistro { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Año:")]
        [Range(1950, 2050, ErrorMessage = "El {0} debe estar entre {1} y {2} ")]
        public int Anio { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Misión del puesto:")]
        [DataType(DataType.Text)]
        public string MisionPuesto { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Empleado:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdEmpleado { get; set; }
        public virtual Empleado Empleado { get; set; }

        public virtual ICollection<ActividadesAnalisisOcupacional> ActividadesAnalisisOcupacional { get; set; }

        public virtual ICollection<AdministracionTalentoHumano> AdministracionTalentoHumano { get; set; }

        public virtual ICollection<ValidacionInmediatoSuperior> ValidacionInmediatoSuperior { get; set; }
    }
}
