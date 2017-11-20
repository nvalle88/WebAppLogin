namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
     
     

    public partial class MisionIndiceOcupacional
    {
        [Key]
        public int IdMisionIndiceOcupacional { get; set; }

        public int IdMision { get; set; }

        public int IdIndiceOcupacional { get; set; }

        public virtual IndiceOcupacional IndiceOcupacional { get; set; }

        public virtual Mision Mision { get; set; }
    }
}
