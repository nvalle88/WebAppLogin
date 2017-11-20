namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;


    public partial class ActividadesGestionCambio
    {
        [Key]
        public int IdActividadesGestionCambio { get; set; }


        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Fecha de inicio:")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaInicio { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Fecha final:")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaFin { get; set; }


        [Display(Name = "Indicador:")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int Indicador { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Porciento:")]
        public bool Porciento { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Descripción:")]
        [DataType(DataType.Text)]
        public string Descripcion { get; set; }


        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Plan de gestión del cambio")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdPlanGestionCambio { get; set; }
        public virtual PlanGestionCambio PlanGestionCambio { get; set; }


        public virtual ICollection<AvanceGestionCambio> AvanceGestionCambio { get; set; }

        
    }
}
