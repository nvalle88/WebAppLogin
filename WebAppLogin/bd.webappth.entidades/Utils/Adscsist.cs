using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace bd.webapplogin.entidades.Utils
{
    public partial class Adscsist
    {

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Sistema")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string AdstSistema { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Descripción")]
        [StringLength(64, MinimumLength = 4, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string AdstDescripcion { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Tipo")]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "El {0} debe tener {1} caracteres")]
        public string AdstTipo { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Host")]
        [StringLength(250, MinimumLength =10, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string AdstHost { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Base de Datos")]
        public string AdstBdd { get; set; }
    }
}
