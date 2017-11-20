using System;
using System.Collections.Generic;

namespace bd.webapplogin.entidades.Negocio
{
    public partial class CapacitacionPregunta
    {
        public int IdCapacitacionPregunta { get; set; }
        public int IdCapacitacionTipoPregunta { get; set; }
        public int IdCapacitacionRespuesta { get; set; }
        public int? IdCapacitacionEncuesta { get; set; }
        public string Descripcion { get; set; }

        public virtual CapacitacionEncuesta CapacitacionEncuesta { get; set; }
        public virtual CapacitacionRespuesta CapacitacionRespuesta { get; set; }
        public virtual CapacitacionTipoPregunta CapacitacionTipoPregunta { get; set; }
    }
}
