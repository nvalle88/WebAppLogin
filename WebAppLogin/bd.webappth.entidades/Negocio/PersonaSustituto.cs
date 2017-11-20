using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace bd.webapplogin.entidades.Negocio
{
    public class PersonaSustituto
    {
        public PersonaSustituto()
        {
            DiscapacidadSustituto = new HashSet<DiscapacidadSustituto>();
            EnfermedadSustituto = new HashSet<EnfermedadSustituto>();
        }

        public int IdPersonaSustituto { get; set; }
        public int IdParentesco { get; set; }
        public int IdPersona { get; set; }
        public int IdPersonaDiscapacidad { get; set; }

        public virtual ICollection<DiscapacidadSustituto> DiscapacidadSustituto { get; set; }
        public virtual ICollection<EnfermedadSustituto> EnfermedadSustituto { get; set; }
        public virtual Parentesco Parentesco { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual Persona PersonaDiscapacidad { get; set; }

    }
}
