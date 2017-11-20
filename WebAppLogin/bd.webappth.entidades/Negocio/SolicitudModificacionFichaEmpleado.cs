namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
     
    public partial class SolicitudModificacionFichaEmpleado
    {
        [Key]
        public int IdSolicitudModificacionFichaEmpleado { get; set; }

        public DateTime FechaSolicitud { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string TelefonoPrivado { get; set; }

        public string TelefonoCasa { get; set; }

        public string Direccion { get; set; }

        public string CapacitacionesRecibidas { get; set; }

        public string ExperienciaLaboral { get; set; }

        public string FormacionAcademica { get; set; }

        public string ParentescosFamiliares { get; set; }

        public int IdEmpleado { get; set; }
        public virtual Empleado Empleado { get; set; }

        public int? IdEstado { get; set; }
        public virtual Estado Estado { get; set; }

       


    }
}
