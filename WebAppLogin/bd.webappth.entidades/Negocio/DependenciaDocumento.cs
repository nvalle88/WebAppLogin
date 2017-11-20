namespace bd.webapplogin.entidades.Negocio
{
    using System.ComponentModel.DataAnnotations;


    public partial class DependenciaDocumento
    {
        [Key]
        public int IdDependenciaDocumento { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Documentos en el Servidor:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdDocumentosSubidos { get; set; }
        public virtual DocumentosParentescodos DocumentosParentescodos { get; set; }

        [Display(Name = "Dependencia:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdDependencia { get; set; }
        public virtual Dependencia Dependencia { get; set; }


    }
}
