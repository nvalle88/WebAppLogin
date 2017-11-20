namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class CapacitacionRecibida
    {
        public CapacitacionRecibida()
        {
            CapacitacionEncuesta = new HashSet<CapacitacionEncuesta>();
        }

        public int IdCapacitacionRecibida { get; set; }
        public DateTime Fecha { get; set; }
        public decimal CostoReal { get; set; }
        public int IdCapacitacionTemarioProveedor { get; set; }
        public int IdEmpleado { get; set; }

        public virtual ICollection<CapacitacionEncuesta> CapacitacionEncuesta { get; set; }
        public virtual CapacitacionTemarioProveedor CapacitacionTemarioProveedor { get; set; }
        public virtual Empleado Empleado { get; set; }


    }
}
