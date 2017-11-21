
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace bd.webappth.entidades.Negocio
{
    public partial class Adscbdd
    {
        public Adscbdd()
        {
            Adscgrp = new HashSet<Adscgrp>();
            Adscsist = new HashSet<Adscsist>();
        }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Base de Datos")]
        [StringLength(32, MinimumLength = 4, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string AdbdBdd { get; set; }

        [Display(Name = "Descripción")]
        [StringLength(64, MinimumLength = 4, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string AdbdDescripcion { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Servidor")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string AdbdServidor { get; set; }

        public virtual ICollection<Adscgrp> Adscgrp { get; set; }
        public virtual ICollection<Adscsist> Adscsist { get; set; }
    }
}
