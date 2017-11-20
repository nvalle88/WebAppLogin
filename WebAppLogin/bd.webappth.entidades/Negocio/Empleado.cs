namespace bd.webapplogin.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;


    public partial class Empleado
    {
        [Key]
        public int IdEmpleado { get; set; }

        public DateTime FechaIngreso { get; set; }

        public DateTime? FechaIngresoSectorPublico { get; set; }

        public bool TrabajoSuperintendenciaBanco { get; set; }


        public bool FondosReservas { get; set; }

        public bool Nepotismo { get; set; }

        public bool DeclaracionJurada { get; set; }

        public string IngresosOtraActividad { get; set; }

        public int MesesImposiciones { get; set; }

        public int DiasImposiciones { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        public int IdPersona { get; set; }
        public virtual Persona Persona { get; set; }

        
        public int IdCiudadLugarNacimiento { get; set; }
        public virtual Ciudad CiudadNacimiento { get; set; }

        public int IdProvinciaLugarSufragio { get; set; }
        public virtual Provincia ProvinciaSufragio { get; set; }

        public int IdDependencia { get; set; }
        public virtual Dependencia Dependencia { get; set; }

        public virtual ICollection<RolPagos> RolPagos { get; set; }

        public virtual ICollection<AccionPersonal> AccionPersonal { get; set; }

        public virtual ICollection<AdministracionTalentoHumano> AdministracionTalentoHumano { get; set; }

        public virtual ICollection<AprobacionViatico> AprobacionViatico { get; set; }

        public virtual ICollection<CapacitacionEncuesta> CapacitacionEncuesta { get; set; }

        public virtual ICollection<CapacitacionPlanificacion> CapacitacionPlanificacion { get; set; }

        public virtual ICollection<CapacitacionRecibida> CapacitacionRecibida { get; set; }

        public virtual ICollection<ConfirmacionLectura> ConfirmacionLectura { get; set; }

        public virtual ICollection<DatosBancarios> DatosBancarios { get; set; }

        public virtual ICollection<DeclaracionPatrimonioPersonal> DeclaracionPatrimonioPersonal { get; set; }

       

        public virtual ICollection<DocumentosParentescodos> DocumentosParentescodos { get; set; }

        public virtual ICollection<SolicitudPlanificacionVacaciones> SolicitudPlanificacionVacaciones { get; set; }

        public virtual ICollection<SolicitudVacaciones> SolicitudVacaciones { get; set; }

        public virtual ICollection<EmpleadoSaldoVacaciones> EmpleadoSaldoVacaciones { get; set; }

        public virtual ICollection<SolicitudPermiso> SolicitudPermiso { get; set; }

        public virtual ICollection<SolicitudViatico> SolicitudViatico { get; set; }

       

        public virtual ICollection<EmpleadoImpuestoRenta> EmpleadoImpuestoRenta { get; set; }

       

        public virtual ICollection<SolicitudCertificadoPersonal> SolicitudCertificadoPersonal { get; set; }

        public virtual ICollection<SolicitudCertificadoPersonal> SolicitudCertificadoPersonal1 { get; set; }

        public virtual ICollection<FormularioAnalisisOcupacional> FormularioAnalisisOcupacional { get; set; }

        public virtual ICollection<SolicitudModificacionFichaEmpleado> SolicitudModificacionFichaEmpleado { get; set; }

        public virtual ICollection<SolicitudAnticipo> SolicitudAnticipo { get; set; }

        public virtual ICollection<SolicitudAcumulacionDecimos> SolicitudAcumulacionDecimos { get; set; }

        public virtual ICollection<SolicitudLiquidacionHaberes> SolicitudLiquidacionHaberes { get; set; }

       
        //public virtual ICollection<TransferenciaActivoFijo> TransferenciaActivoFijo1 { get; set; }

        //public virtual ICollection<TransferenciaActivoFijo> TransferenciaActivoFijo2 { get; set; }

        public virtual ICollection<EmpleadoNepotismo> EmpleadoNepotismo { get; set; }

        //public virtual ICollection<EmpleadoNepotismo> EmpleadoNepotismo1 { get; set; }

        public virtual ICollection<IndiceOcupacionalModalidadPartida> IndiceOcupacionalModalidadPartida { get; set; }

        public virtual ICollection<EmpleadoFamiliar> EmpleadoFamiliar { get; set; }



        public virtual ICollection<Evaluador> Evaluador { get; set; }

        public virtual ICollection<SolicitudHorasExtras> SolicitudHorasExtras { get; set; }

        public virtual ICollection<ValidacionInmediatoSuperior> ValidacionInmediatoSuperior { get; set; }

        public virtual ICollection<PersonaPaquetesInformaticos> PersonaPaquetesInformaticos { get; set; }

        public virtual ICollection<RealizaExamenInduccion> RealizaExamenInduccion { get; set; }

        public virtual ICollection<EmpleadoFormularioCapacitacion> EmpleadoFormularioCapacitacion { get; set; }

        //public virtual ICollection<EmpleadoFormularioCapacitacion> EmpleadoFormularioCapacitacion1 { get; set; }

        //public virtual ICollection<EmpleadoFormularioCapacitacion> EmpleadoFormularioCapacitacion2 { get; set; }

        //public virtual ICollection<EmpleadoFormularioCapacitacion> EmpleadoFormularioCapacitacion3 { get; set; }

        public virtual ICollection<EmpleadoContactoEmergencia> EmpleadoContactoEmergencia { get; set; }

        public virtual ICollection<EmpleadosFormularioDevengacion> EmpleadosFormularioDevengacion { get; set; }

        public virtual ICollection<FormularioDevengacion> FormularioDevengacion { get; set; }

        public virtual ICollection<FormularioDevengacion> FormularioDevengacion1 { get; set; }

        public virtual ICollection<FormularioDevengacion> FormularioDevengacion2 { get; set; }

        public virtual ICollection<FacturaViatico> FacturaViatico { get; set; }

        public virtual ICollection<PlanGestionCambio> PlanGestionCambio { get; set; }

        public virtual ICollection<PlanGestionCambio> PlanGestionCambio1 { get; set; }

        public virtual ICollection<EmpleadoMovimiento> EmpleadoMovimiento { get; set; }

        public virtual ICollection<RMU> RMU { get; set; }

        public virtual ICollection<EmpleadoIE> EmpleadoIE { get; set; }

        public virtual ICollection<RegistroEntradaSalida> RegistroEntradaSalida { get; set; }

        public virtual ICollection<PlanificacionHE> PlanificacionHE { get; set; }

        public virtual ICollection<Provisiones> Provisiones { get; set; }

       // public virtual ICollection<PlanificacionHE> PlanificacionHE1 { get; set; }

        public virtual ICollection<Liquidacion> Liquidacion { get; set; }

        public virtual ICollection<Eval001> Eval001 { get; set; }


    }
}
