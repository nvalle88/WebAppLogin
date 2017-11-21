using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace bd.webappth.entidades.Negocio
{
    public partial class Adscgrp
    {
        public Adscgrp()
        {
            Adscexe = new HashSet<Adscexe>();
            Adscmiem = new HashSet<Adscmiem>();
        }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Base de datos")]
        [StringLength(32, MinimumLength = 4, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string AdgrBdd { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Grupo")]
        [StringLength(32, MinimumLength = 4, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string AdgrGrupo { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Nombre")]
        [StringLength(32, MinimumLength = 4, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string AdgrNombre { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Descripción")]
        [StringLength(64, MinimumLength = 4, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string AdgrDescripcion { get; set; }

        public virtual ICollection<Adscexe> Adscexe { get; set; }
        public virtual ICollection<Adscmiem> Adscmiem { get; set; }
      
        public virtual Adscbdd AdgrBddNavigation { get; set; }
    }
}
