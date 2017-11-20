namespace bd.webapplogin.entidades.Negocio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Candidato
    {
        [Key]
        public int IdCandidato { get; set; }

        //Propiedades Virtuales Referencias a otras clases
        public virtual ICollection<CandidatoConcurso> CandidatoConcurso { get; set; }

    }
}
