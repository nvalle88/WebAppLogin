using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace bd.webappth.entidades.Negocio
{
    public partial class Adscmenu
    {
        public Adscmenu()
        {
            Adscexe = new HashSet<Adscexe>();
        }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Sistema")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string AdmeSistema { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Aplicación")]
        [StringLength(32, MinimumLength = 4, ErrorMessage = "El {0} no puede tener más de {1} y menos de {2}")]
        public string AdmeAplicacion { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Tipo")]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "El {0} no puede tener más de {1} catacter")]
        public string AdmeTipo { get; set; }

       
        [Display(Name = "Menú padre")]
        
        public string AdmePadre { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Objetivo")]
        [StringLength(32, MinimumLength = 6, ErrorMessage = "El {0} no puede tener más de {1} catacter")]
        public string AdmeObjetivo { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Descripción")]
        [StringLength(128, MinimumLength = 1, ErrorMessage = "El {0} no puede tener más de {1} catacter")]
        public string AdmeDescripcion { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Orden")]
        public int? AdmeOrden { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Tipo de objeto")]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "El {0} no puede tener más de {1} catacter")]
        public string AdmeTipoObjeto { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "URL")]
        [StringLength(150, MinimumLength = 1, ErrorMessage = "El {0} no puede tener más de {1} catacter")]
        public string AdmeUrl { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Ensamblado")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "El {0} no puede tener más de {1} catacter")]
        public string AdmeEnsamblado { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Elemento")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "El {0} no puede tener más de {1} catacter")]
        public string AdmeElemento { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Estado")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "El {0} no puede tener más de {1} catacter")]
        public string AdmeEstado { get; set; }

        [Display(Name = "Controlador")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "El {0} no puede tener más de {1} catacter")]
        public string AdmeControlador { get; set; }

        [Display(Name = "Acción del controlador")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "El {0} no puede tener más de {1} catacter")]
        public string AdmeAccionControlador { get; set; }

        public virtual ICollection<Adscexe> Adscexe { get; set; }
        public virtual Adscsist AdmeSistemaNavigation { get; set; }
    }
}
