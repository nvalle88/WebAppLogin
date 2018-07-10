using System;
using System.Collections.Generic;
using System.Text;

namespace bd.webapplogin.entidades.ObjectTransfer
{
    public class DependenciaDatosViewModel
    {
        public int IdDependencia { get; set; }
        public string NombreDependencia { get; set; }
        public int IdSucursal { get; set; }
        public string NombreSucursal { get; set; }
        public DatosBasicosEmpleadoViewModel DatosBasicosEmpleadoJefeViewModel { get; set; }
        public List<DependenciaDatosViewModel> ListaDependenciasHijas { get; set; }
        public List<DatosBasicosEmpleadoViewModel> ListaEmpleadosDependencia { get; set; }
    }
}
