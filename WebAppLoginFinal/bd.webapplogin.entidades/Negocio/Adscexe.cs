using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace bd.webappth.entidades.Negocio
{
    public partial class Adscexe
    {
        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Base de datos")]
        [StringLength(32, MinimumLength = 4, ErrorMessage = "Debe introducir {0}")]
        public string AdexBdd { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Grupo")]
        [StringLength(32, MinimumLength = 4, ErrorMessage = "Debe introducir {0}")]
        public string AdexGrupo { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Sistema")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Debe introducir {0}")]
        public string AdexSistema { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Aplicación")]
        [StringLength(32, MinimumLength = 4, ErrorMessage = "Debe introducir {0}")]
        public string AdexAplicacion { get; set; }

        
        [Display(Name = "SQL")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string AdexSql { get; set; }

        [Display(Name = "Insertar")]
        public bool Ins { get; set; }

        [Display(Name = "Seleccionar")]
        public bool Sel { get; set; }

        [Display(Name = "Actualizar")]
        public bool Upd { get; set; }

        [Display(Name = "Eliminar")]
        public bool Del { get; set; }

        public virtual Adscgrp Adex { get; set; }
        public virtual Adscmenu AdexNavigation { get; set; }
    }
}
