namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
     
     

    public partial class ValidacionInmediatoSuperior
    {
        [Key]
        public int IdValidacionJefe { get; set; }

        public int IdFormularioAnalisisOcupacional { get; set; }

        public int IdEmpleado { get; set; }

        public DateTime? Fecha { get; set; }

        public virtual Empleado Empleado { get; set; }

        public virtual ICollection<Exepciones> Exepciones { get; set; }

        public virtual FormularioAnalisisOcupacional FormularioAnalisisOcupacional { get; set; }
    }
}
