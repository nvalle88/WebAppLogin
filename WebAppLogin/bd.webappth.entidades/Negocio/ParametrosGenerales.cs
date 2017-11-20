using System.ComponentModel.DataAnnotations;

namespace bd.webapplogin.entidades.Negocio
{



    public partial class ParametrosGenerales
    {
        [Key]
        public int IdParametrosGenerales { get; set; }

        public string Nombre { get; set; }

        public string Valor { get; set; }
    }
}
