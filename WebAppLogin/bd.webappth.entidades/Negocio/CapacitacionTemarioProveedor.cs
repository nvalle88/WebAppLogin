
namespace bd.webapplogin.entidades.Negocio {

    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class CapacitacionTemarioProveedor
    {
        public CapacitacionTemarioProveedor()
        {
            CapacitacionRecibida = new HashSet<CapacitacionRecibida>();
        }

        public int IdCapacitacionTemarioProveedor { get; set; }
        public int IdCapacitacionTemario { get; set; }
        public int IdCapacitacionProveedor { get; set; }
        public int NumeroHoras { get; set; }
        public decimal Costo { get; set; }
        public int IdCapacitacionModalidad { get; set; }

        public virtual ICollection<CapacitacionRecibida> CapacitacionRecibida { get; set; }
        public virtual CapacitacionModalidad CapacitacionModalidad { get; set; }
        public virtual CapacitacionProveedor CapacitacionProveedor { get; set; }
        public virtual CapacitacionTemario CapacitacionTemario { get; set; }

    }
}

