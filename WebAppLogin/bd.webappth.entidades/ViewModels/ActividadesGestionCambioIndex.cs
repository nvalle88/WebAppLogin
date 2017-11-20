using bd.webapplogin.entidades.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace bd.webapplogin.entidades.ViewModels
{
    public partial class ActividadesGestionCambioIndex
    {
        [Key]
        public int IdActividadesGestionCambio { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public int Indicador { get; set; }

        public bool Porciento { get; set; }

        public string Descripcion { get; set; }

        public decimal? Suma { get; set; }

        public decimal? Porcentaje { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        public int IdPlanGestionCambio { get; set; }
        public virtual PlanGestionCambio PlanGestionCambio { get; set; }


        public virtual ICollection<AvanceGestionCambio> AvanceGestionCambio { get; set; }


    }
}
