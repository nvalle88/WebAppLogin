namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
     
     

 
    public partial class Temporal
    {
        [Key]
        public int IdTemporal { get; set; }

        [Required(ErrorMessage = "Debe introducir  {0}")]
        [StringLength(50)]
        public string Nombre { get; set; }
    }
}
