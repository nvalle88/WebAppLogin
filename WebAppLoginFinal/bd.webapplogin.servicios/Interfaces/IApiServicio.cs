using bd.log.guardar.ObjectTranfer;
using bd.webappth.entidades.Utils;
using bd.webappth.entidades.ViewModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace bd.webappth.servicios.Interfaces
{
    public interface IApiServicio
    {
        Task<Response> SalvarLog<T>(HttpContext context, EntradaLog model);
        Task<Response> SalvarLog<T>(string path,HttpContext context, EntradaLog model,Login login);
        Task<Response> InsertarAsync<T>(T model,Uri baseAddress, string url );
        Task<Response> InsertarAsync<T>(object model, Uri baseAddress, string url);
        Task<Response> ObtenerElementoAsync<T>(T model, Uri baseAddress, string url) where T : class;
        Task<T> ObtenerElementoAsync1<T>(object model, Uri baseAddress, string url) where T : class;
        Task<Response> EliminarAsync(string id, Uri baseAddress, string url);
        Task<Response> EliminarAsync(object model, Uri baseAddress, string url);
        Task<Response> EditarAsync<T>(string id, T model, Uri baseAddress, string url);
        Task<Response> EditarAsync<T>(object model, Uri baseAddress, string url);
        Task<T> SeleccionarAsync<T>(string id, Uri baseAddress, string url) where T : class;
        Task<List<T>> Listar<T>(Uri baseAddress, string url) where T :class;
        Task<List<T>> Listar<T>(object model, Uri baseAddress, string url) where T : class;
    }
}
