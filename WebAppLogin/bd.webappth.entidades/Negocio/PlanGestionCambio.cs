namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class PlanGestionCambio
    {
        [Key]
        public int IdPlanGestionCambio { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Título:")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Descripción:")]
        [DataType(DataType.MultilineText)]
        [StringLength(500, MinimumLength = 2, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Fecha de inicio:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? FechaInicio { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Fecha final:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? FechaFin { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Realizado por:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int RealizadoPor { get; set; }
        public virtual Empleado EmpleadoRealizadoPor { get; set; }

        [Display(Name = "Aprobado por:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int AprobadoPor { get; set; }
        public virtual Empleado EmpleadoAprobadoPor { get; set; }

        public virtual ICollection<ActividadesGestionCambio> ActividadesGestionCambio { get; set; }


    }
}
