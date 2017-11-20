using System;
using System.Collections.Generic;

namespace bd.webapplogin.entidades.Negocio
{
    public partial class CapacitacionTipoPregunta
    {
        public CapacitacionTipoPregunta()
        {
            CapacitacionPregunta = new HashSet<CapacitacionPregunta>();
        }

        public int IdCapacitacionTipoPregunta { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<CapacitacionPregunta> CapacitacionPregunta { get; set; }
    }
}
