using System;
using System.Collections.Generic;
using System.Text;

namespace bd.webapplogin.entidades.ViewModels
{
 public class CapacitacionPlanificacionViewModel
    {
        public int IdCapacitacionPlanificacion { get; set; }
        public string IdentificacionEmpleado { get; set; }
        public string NombreApellido { get; set; }
        public string Dependencia { get; set; }
        public string Sucurzal { get; set; }
        public string CapacitacionModalidad { get; set; }
        public string CapacitacionTemario { get; set; }
        public DateTime Fecha { get; set; }
        public int NumeroHoras { get; set; }
        public decimal Presupuesto { get; set; }
    }
}
