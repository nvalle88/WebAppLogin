namespace bd.webapplogin.entidades.Negocio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class CapacitacionProveedor
    {



        public CapacitacionProveedor()
        {
            CapacitacionTemarioProveedor = new HashSet<CapacitacionTemarioProveedor>();
        }

        public int IdCapacitacionProveedor { get; set; }
        public string Telefono { get; set; }
        public string Nombre { get; set; }
        public int IdPais { get; set; }
        public string Direccion { get; set; }
        public int IdCapacitacionRecibida { get; set; }

        public virtual ICollection<CapacitacionTemarioProveedor> CapacitacionTemarioProveedor { get; set; }
        public virtual Pais Pais { get; set; }

    }
}
