using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace bd.webapplogin.entidades.ViewModels
{
   public class CambiarContrasenaViewModel
    {
        public string Usuario { get; set; }
        [DisplayName("Contraseña actual")]
        [Required(ErrorMessage ="Debe introducir la contraseña actual")]
        public string ContrasenaActual { get; set; }
        [DisplayName("Nueva contraseña")]
        [Required(ErrorMessage = "Debe introducir la nueva contraseña")]
        public string NuevaContrasena { get; set; }
        [DisplayName("Confirmación de la nueva contraseña")]
        [Required(ErrorMessage = "Debe introducir la confirmación de la nueva contraseña")]
        public string ConfirmacionContrasena { get; set; }

    }
}
