using bd.webapplogin.entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Text;

namespace bd.webapplogin.entidades.ViewModels
{
    public class EmpleadoViewModel
    {
        public Persona Persona { get; set; }
        public EmpleadoContactoEmergencia EmpleadoContactoEmergencia { get; set; }
        public List<EmpleadoFamiliar> EmpleadoFamiliar { get; set; }
        public List<PersonaEstudio> PersonaEstudio { get; set; }
        public List<PersonaDiscapacidad> PersonaDiscapacidad { get; set; }
        public List<PersonaEnfermedad> PersonaEnfermedad { get; set; }
        //List<EmpleadoFamiliar> Empleadofamiliar { get; set; }
        public Empleado Empleado { get; set; }
        public DatosBancarios DatosBancarios { get; set; }
        public List<TrayectoriaLaboral> TrayectoriaLaboral { get; set; }
        public PersonaSustituto PersonaSustituto { get; set; }
        public List<DiscapacidadSustituto> DiscapacidadSustituto { get; set; }
        public List<EnfermedadSustituto> EnfermedadSustituto { get; set; }
        public IndiceOcupacionalModalidadPartida IndiceOcupacionalModalidadPartida { get; set; }

    }

    
}
