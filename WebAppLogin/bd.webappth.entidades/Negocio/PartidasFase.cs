namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class PartidasFase
    {
        [Key]
        public int IdPartidasFase { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "¿Ganador?")]
        public bool? Ganador { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Indice Ocupacional Modalidad Partida:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdIndiceOcupacionalModalidadPartida { get; set; }
        public virtual IndiceOcupacionalModalidadPartida IndiceOcupacionalModalidadPartida { get; set; }

        [Display(Name = "Fase del concurso:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdFaseConcurso { get; set; }
        public virtual FaseConcurso FaseConcurso { get; set; }

        public virtual ICollection<CandidatoConcurso> CandidatoConcurso { get; set; }


    }
}
