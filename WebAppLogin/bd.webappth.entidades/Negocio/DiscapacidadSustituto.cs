using System;
using System.Collections.Generic;
using System.Text;

namespace bd.webapplogin.entidades.Negocio
{
  public  class DiscapacidadSustituto
    {
        public int IdDiscapacidadSustituto { get; set; }
        public int IdTipoDiscapacidad { get; set; }
        public int PorcentajeDiscapacidad { get; set; }
        public string NumeroCarnet { get; set; }
        public int IdPersonaSustituto { get; set; }

        public virtual PersonaSustituto PersonaSustituto { get; set; }
        public virtual TipoDiscapacidad TipoDiscapacidad { get; set; }
    }
}
