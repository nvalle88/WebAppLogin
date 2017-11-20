using bd.webapplogin.entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Text;

namespace bd.webapplogin.entidades.ViewModels
{
    public class ActividadesGestionCambioViewModel
    {
        public int IdPlanGestionCambio { get; set; }
        public List<ActividadesGestionCambioIndex> ListaActividadesGestionCambio { get; set; }
    }
}
