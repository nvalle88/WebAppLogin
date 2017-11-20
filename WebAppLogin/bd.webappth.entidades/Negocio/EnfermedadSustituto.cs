using System;
using System.Collections.Generic;
using System.Text;

namespace bd.webapplogin.entidades.Negocio
{
    public class EnfermedadSustituto
    {
        public int IdEnfermedadSustituto { get; set; }
        public int? IdTipoEnfermedad { get; set; }
        public string InstitucionEmite { get; set; }
        public int? IdPersonaSustituto { get; set; }

        public virtual PersonaSustituto PersonaSustituto { get; set; }
        public virtual TipoEnfermedad TipoEnfermedad { get; set; }
    }
}
