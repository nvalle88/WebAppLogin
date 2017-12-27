using bd.log.guardar.Inicializar;
using bd.webappth.entidades.Negocio;
using bd.webappth.entidades.Utils;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace bd.webappth.servicios.Servicios
{

    /// <summary>
    /// Está clase es la encargada de inicializar variables necesarias para el uso de la aplicación 
    /// estas variables son los host donde se encuentran los servicios web 
    /// Ejemplo:WebApp.BaseAddressSeguridad es el host donde se encuentran los servicios de Seguridad.
    ///  AppGuardarLog.BaseAddress es el host donde se encuentran los servicios de Log.
    /// </summary>
    public class InicializarWebApp
    {
        #region Methods
        /// <summary>
        /// Se obtiene el host del sistema que se pase por párametro desde la base de datos
        /// </summary>
        /// <param name="id">Nombre del sistema</param>
        /// <param name="baseAddreess">Host del servicio de seguridad</param>
        /// <returns>Objeto Sistema desde la base de datos</returns>
        private static async Task<Adscsist> ObtenerHostSistema(string id, Uri baseAddreess)
        {
            using (HttpClient client = new HttpClient())
             {
                var url = string.Format("{0}/{1}", "/api/Adscsists", id);
                var uri = string.Format("{0}{1}", baseAddreess, url);
                var respuesta = await client.GetAsync(new Uri(uri));

                var resultado = await respuesta.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<Response>(resultado);
                var sistema = JsonConvert.DeserializeObject<Adscsist>(response.Resultado.ToString());
                return sistema;
            }
        }
        /// <summary>
        /// Inicializar el host de Seguridad para poder consumir los servicios de seguridad
        /// </summary>
        /// <param name="baseAddreess">Host donde se encuentra el servicio de seguridad (appsetting.json)</param>
        /// <returns></returns>
        public static async Task InicializarSeguridad(string baseAddreess)
        {
            try
            {
                WebApp.BaseAddressSeguridad = baseAddreess;
            }
            catch (Exception)
            {

            }

        }
        /// <summary>
        /// Inicializar en la variable AppGuardarLog.BaseAddress el host de los Log 
        /// para poder consumir los servicios de log
        /// </summary>
        /// <param name="id">Nombre del sistema de log igual que como esté en la base de datos</param>
        /// <param name="baseAddress">Host donde se encuentra el servicio de seguridad (appsetting.json)</param>
        /// <returns></returns>
        public static async Task InicializarLogEntry(string id, Uri baseAddress)
        {
            try
            {
                var sistema = await ObtenerHostSistema(id, baseAddress);
                AppGuardarLog.BaseAddress = sistema.AdstHost;
            }
            catch (Exception)
            {

            }
        }
        #endregion
    }
}