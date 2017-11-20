using System;
using System.Collections.Generic;

namespace bd.webapplogin.entidades.Negocio
{
    public partial class CapacitacionEncuesta
    {
        public CapacitacionEncuesta()
        {
            CapacitacionPregunta = new HashSet<CapacitacionPregunta>();
        }

        public int IdCapacitacionEncuesta { get; set; }
        public int IdCapacitacionRecibida { get; set; }
        public int IdEmpleado { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<CapacitacionPregunta> CapacitacionPregunta { get; set; }
        public virtual CapacitacionRecibida CapacitacionRecibida { get; set; }
        public virtual Empleado Empleado { get; set; }
    }
}
