using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace bd.webappth.entidades.ViewModels
{
    public class Login
    {
        [Display(Name = "Usuario")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string Usuario { get; set; }

        [Display(Name ="Contraseña")]
        [Required(ErrorMessage ="El {0} es obligatorio")]
        [DataType(DataType.Password)]
        public string Contrasena { get; set; }

    }
}
