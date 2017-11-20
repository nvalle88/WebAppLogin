namespace bd.webapplogin.entidades.Negocio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class IndiceOcupacional
    {
        [Key]
        public int IdIndiceOcupacional { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Dependencia:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdDependencia { get; set; }
        public virtual Dependencia Dependencia { get; set; }

        [Display(Name = "Manual del puesto:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdManualPuesto { get; set; }
        public virtual ManualPuesto ManualPuesto { get; set; }

        [Display(Name = "Rol del puesto:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdRolPuesto { get; set; }
        public virtual RolPuesto RolPuesto { get; set; }

        [Display(Name = "Escala de grados:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdEscalaGrados { get; set; }
        public virtual EscalaGrados EscalaGrados { get; set; }

        //public string FullName { get {return Dependencia.Nombre +"/ "+ ManualPuesto.Nombre +"/ "+ManualPuesto.Nombre +"/ "+ RolPuesto.Nombre+"/"+ "("+ EscalaGrados.Grado+")" + EscalaGrados.Remuneracion; } set {; } }


        public virtual ICollection<IndiceOcupacionalExperienciaLaboralRequerida> IndiceOcupacionalExperienciaLaboralRequerida { get; set; }

        public virtual ICollection<IndiceOcupacionalModalidadPartida> IndiceOcupacionalModalidadPartida { get; set; }

        public virtual ICollection<MisionIndiceOcupacional> MisionIndiceOcupacional { get; set; }

        public virtual ICollection<RelacionesInternasExternasIndiceOcupacional> RelacionesInternasExternasIndiceOcupacional { get; set; }

        public virtual ICollection<IndiceOcupacionalEstudio> IndiceOcupacionalEstudio { get; set; }

        public virtual ICollection<IndiceOcupacionalAreaConocimiento> IndiceOcupacionalAreaConocimiento { get; set; }

        public virtual ICollection<IndiceOcupacionalConocimientosAdicionales> IndiceOcupacionalConocimientosAdicionales { get; set; }

        public virtual ICollection<IndiceOcupacionalActividadesEsenciales> IndiceOcupacionalActividadesEsenciales { get; set; }

        public virtual ICollection<IndiceOcupacionalCapacitaciones> IndiceOcupacionalCapacitaciones { get; set; }

        public virtual ICollection<IndiceOcupacionalComportamientoObservable> IndiceOcupacionalComportamientoObservable { get; set; }


    }
}
