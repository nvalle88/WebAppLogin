using bd.webapplogin.entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Text;

namespace bd.webapplogin.entidades.ViewModels
{
   public class IndiceOcupacionalMisionView
    {
        public int IdIndiceOcupacional { get; set; }
        public List<Mision> ListaMisiones { get; set; }
       
    }
}
