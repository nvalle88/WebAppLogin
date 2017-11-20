namespace bd.webapplogin.entidades.Negocio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class CapacitacionModalidad
    {
        public CapacitacionModalidad()
        {
            CapacitacionPlanificacion = new HashSet<CapacitacionPlanificacion>();
            CapacitacionTemarioProveedor = new HashSet<CapacitacionTemarioProveedor>();
        }

        public int IdCapacitacionModalidad { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<CapacitacionPlanificacion> CapacitacionPlanificacion { get; set; }
        public virtual ICollection<CapacitacionTemarioProveedor> CapacitacionTemarioProveedor { get; set; }
    }
}
