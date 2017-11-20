using bd.webapplogin.entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Text;

namespace bd.webapplogin.entidades.ViewModels
{
  public  class IndiceOcupacionalComportamientoObservableView
    {
        public int IdIndiceOcupacional { get; set; }
        public List<ComportamientoObservable> ComportamientoObservables { get; set; }
    }
}
