using System;
using System.Collections.Generic;

namespace bd.webapplogin.entidades.Negocio
{
    public partial class IndiceOcupacionalExperienciaLaboralRequerida
    {
        public int IdIndiceOcupacionalExperienciaLaboralRequerida { get; set; }
        public int IdIndiceOcupacional { get; set; }
        public int IdExperienciaLaboralRequerida { get; set; }

        public virtual ExperienciaLaboralRequerida ExperienciaLaboralRequerida { get; set; }
        public virtual IndiceOcupacional IndiceOcupacional { get; set; }
    }
}
